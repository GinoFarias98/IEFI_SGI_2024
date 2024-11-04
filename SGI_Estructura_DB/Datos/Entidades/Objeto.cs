using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Estructura_DB.Datos.Entidades
{
    [Index(nameof(Id), Name = "UQ_Id", IsUnique = true)]
    public class Objeto : EntityBase
    {
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres permitidos: {1}.")]
        public string Nombre { get; set; }

        [MaxLength(200, ErrorMessage = "Máximo número de caracteres permitidos: {1}.")]
        public string Descripcion { get; set; }

        [MaxLength(50, ErrorMessage = "Máximo número de caracteres permitidos: {1}.")]
        public string Marca { get; set; }

        [MaxLength(50, ErrorMessage = "Máximo número de caracteres permitidos: {1}.")]
        public string Modelo { get; set; }

        [MaxLength(100, ErrorMessage = "Máximo número de caracteres permitidos: {1}.")]
        public string NumeroSerie { get; set; }

        public int TipoObjetoId { get; set; }
        public TipoObjeto TipoObjeto { get; set; }

    }
}
