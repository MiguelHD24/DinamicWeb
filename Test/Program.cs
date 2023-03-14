using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using BL;
using System.Globalization;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Roles roles = new Roles();

            //roles.Rol = "Caja";
            //roles.IdUsuarioRegistra = 1;
            //Console.WriteLine(BL_Roles.InsertarRoles(roles).IdRol);

            //roles.Rol = "Jefe de Almacen";
            //roles.IdUsuarioRegistra = 1;
            //Console.WriteLine(BL_Roles.InsertarRoles(roles).IdRol);

            //roles.Rol = "Oficial de Bodega";
            //roles.IdUsuarioRegistra = 1;
            //Console.WriteLine(BL_Roles.InsertarRoles(roles).IdRol);

            //roles.Rol = "Jefe de Contabilidad";
            //roles.IdUsuarioRegistra = 1;
            //Console.WriteLine(BL_Roles.InsertarRoles(roles).IdRol);

            //roles.Rol = "Oficial Contable";
            //roles.IdUsuarioRegistra = 1;
            //Console.WriteLine(BL_Roles.InsertarRoles(roles).IdRol);

            //foreach (var item in BL_Roles.Buscar_("ca"))
            //{
            //    Console.WriteLine(item.IdRol + "\t" + item.Rol + "\n");
            //}

            //roles = BL_Roles.Registro___(5);
            //Console.WriteLine(roles.IdRol + "\t" + roles.Rol + "\n");

            Permisos Permiso = new Permisos();
            Permiso.IdPermiso = 3;
            Permiso.Permiso = "Actualizar";
            Permiso.IdUsuarioActualiza = 1;

            Console.WriteLine(BL_Permisos.Update(Permiso));





            Console.ReadLine();


        }
    }
}
