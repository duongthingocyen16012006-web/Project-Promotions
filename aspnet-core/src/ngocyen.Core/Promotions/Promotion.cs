using Abp.Domain.Entities.Auditing;//Import thư viện của ABP chứa class:
using System;

namespace ngocyen.Promotions//Namespace là vùng tên của class.Promotion thuộc module Promotions của hệ thống.
{
    public class Promotion : FullAuditedEntity<int>//Tạo class Promotion kế thừa từ:FullAuditedEntity
    {
        public string Name { get; set; }//Tên chương trình khuyến mãi.

        public string Code { get; set; }//Mã giảm giá.

        public int DiscountType { get; set; }//Loại giảm giá.

        public decimal DiscountValue { get; set; }//Giá trị giảm.

        public decimal? MinOrderValue { get; set; }//Giá trị đơn hàng tối thiểu để áp dụng.

        public decimal? MaxDiscountValue { get; set; }//Giới hạn số tiền giảm tối đa.

        public int Quantity { get; set; }//Tổng số lượt được dùng.

        public int UsedCount { get; set; }//Đã dùng bao nhiêu lượt.

        public DateTime StartDate { get; set; }//Ngày bắt đầu hiệu lực.

        public DateTime EndDate { get; set; }//Ngày hết hạn.

        public bool IsActive { get; set; }//Trạng thái bật/tắt.
    }
}
