//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logistics
{
    using System;
    using System.Collections.Generic;
    
    public partial class RouteDetail
    {
        public int RouteID { get; set; }
        public int WarehouseID { get; set; }
        public int Sequence { get; set; }
    
        public virtual Route Route { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}