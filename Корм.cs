//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfFarm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Корм
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Корм()
        {
            this.АктСписанияКормов = new HashSet<АктСписанияКормов>();
        }
    
        public int Код { get; set; }
        public string Имя { get; set; }
        public Nullable<int> Количество { get; set; }
        public Nullable<int> Цена { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<АктСписанияКормов> АктСписанияКормов { get; set; }
    }
}
