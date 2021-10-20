using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pc3practica.Models
{
    [Table("t_producto")]
    public class Productos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get; set;}

        [Required(ErrorMessage = "Por favor ingrese nombre de producto")]
        [Display(Name="Nombre Producto")]
        public String nombre {get; set;}

        [Required(ErrorMessage = "Porfavor ingrese el precio del producto")]
        [Display(Name="Precio")]
        public Decimal precio { get; set; }

        [Required(ErrorMessage = "Porfavor ingrese la URL de la imagen")]
        [Display(Name="Imagen de Producto")]
        public String imagen { get; set; }

        [Required(ErrorMessage = "Porfavor seleccione la categoría del producto")]
        [Display(Name="Categoria de Producto")]
        public String categoria { get; set; }

         [Required(ErrorMessage = "Porfavor ingrese el telefono de contacto")]
         [Display(Name="Telefono del Contacto")]
        public Decimal telefono { get; set; }

         [Required(ErrorMessage = "Porfavor ingrese una descripcion del producto")]
         [Display(Name="Descripción del Producto")]
        public String descripcion { get; set; }

         [Required(ErrorMessage = "Porfavor ingrese el nombre del comprador ")]
         [Display(Name="Nombre del comprador")]
        public String nombrecomp { get; set; }

         [Required(ErrorMessage = "Porfavor ingrese el lugar de compra")]
         [Display(Name="Lugar de compra")]
        public String lugar { get; set; }


    }
}