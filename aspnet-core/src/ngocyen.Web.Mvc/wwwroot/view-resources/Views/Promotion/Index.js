console.log("Promotion JS Loaded");

let editingRow = null;
let editingId = null;

$(document).ready(function () {
    loadPromotions();

    $('#searchPromotion').on('keyup', function () {
        loadPromotions();
    });

    $('#filterStatus').on('change', function () {
        loadPromotions();
    });
});

function openCreateModal() {
    $('#PromotionModal').modal('show');
}

function savePromotion() {
    const data = {
        name: $('#Name').val(),
        code: $('#Code').val(),
        discountValue: parseFloat($('#Discount').val()),
        quantity: parseInt($('#Quantity').val())
    };

    if (editingId) {
        data.id = editingId;

        abp.services.app.promotion.update(data)
            .done(function () {
                abp.notify.success("Cập nhật thành công");
                $('#PromotionModal').modal('hide');

                setTimeout(() => location.reload(), 800);
            });
    }
    else {
        abp.services.app.promotion.create(data)
            .done(function () {
                abp.notify.success("Tạo mới thành công");
                $('#PromotionModal').modal('hide');

                setTimeout(() => location.reload(), 800);
            });
    }
}

function deletePromotion(id) {
    console.log("Delete clicked:", id);

    if (!confirm("Bạn muốn xóa voucher này?")) return;

    abp.services.app.promotion.delete({
        id: id
    })
        .done(function () {
            abp.notify.success("Xóa thành công");
            loadPromotions();
        });
}

function editPromotion(id, button) {
    editingId = id;

    const row = $(button).closest('tr');
    

    $('#Name').val(row.find('td:eq(0)').text());
    $('#Code').val(row.find('td:eq(1)').text());
    $('#Quantity').val(row.find('td:eq(2)').text());
    $('#Discount').val(row.data('discount'));
    $('#PromotionModal').modal('show');
}
function loadPromotions() {
    console.log("LOAD PROMOTIONS RUNNING");
    abp.services.app.promotion.getAll()
        .done(function (result) {

            const keyword = $('#searchPromotion').val().toLowerCase();
            const status = $('#filterStatus').val();

            let filtered = result.filter(p => {
                const matchKeyword =
                    p.name.toLowerCase().includes(keyword) ||
                    p.code.toLowerCase().includes(keyword);

                const matchStatus =
                    status === ''
                        ? true
                        : status === 'active'
                            ? p.isActive
                            : !p.isActive;

                return matchKeyword && matchStatus;
            });

            let html = '';

            filtered.forEach(p => {
                html += `
                  <tr data-discount="${p.discountValue}">
                    <td>${p.name}</td>
                    <td>${p.code}</td>
                    <td>${p.quantity}</td>
                    <td>${p.usedCount || 0}</td>
                   <td>
    ${
                    p.isActive
                        ? '<span class="badge badge-success">Hoạt động</span>'
                        : '<span class="badge badge-secondary">Ngừng hoạt động</span>'
                }
</td>
                    <td>
                       <button class="btn btn-warning btn-sm" onclick="editPromotion(${p.id}, this)">
    Sửa
</button>
                        <button class="btn btn-danger btn-sm" onclick="deletePromotion(${p.id})">
    Xóa
</button>
                    </td>
                </tr>`;
            });

            $('#promotionTableBody').html(html);
        });
}