using Core.Interfaces;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBussinessLogic _bussinessLogic;
        public IndexModel(ILogger<IndexModel> logger, IBussinessLogic bussinessLogic)
        {
            _logger = logger;
            _bussinessLogic = bussinessLogic;
        }

        public void OnGet()
        {

        }

        public IActionResult OnGetCargaPrincipal(DataSourceLoadOptions loadOptions) {
            LoadResult Resultado = new LoadResult();
            try
            {

                Resultado = DataSourceLoader.Load(_bussinessLogic.ObtenerOrganismosAsync(), loadOptions);

            }
            catch (Exception e)
            {

            }
            return new JsonResult(Resultado);

        }


        public IActionResult OnGetCargaPaises(DataSourceLoadOptions loadOptions)
        {
            LoadResult Resultado = new LoadResult();
            try
            {

                Resultado = DataSourceLoader.Load(_bussinessLogic.ObtenerPaises(), loadOptions);

            }
            catch (Exception e)
            {

            }
            return new JsonResult(Resultado);

        }

        public IActionResult OnGetCargaComunidades(DataSourceLoadOptions loadOptions)
        {
            LoadResult Resultado = new LoadResult();
            try
            {

                Resultado = DataSourceLoader.Load(_bussinessLogic.ObtenerComunidades(), loadOptions);

            }
            catch (Exception e)
            {

            }
            return new JsonResult(Resultado);

        }

        public IActionResult OnGetCargaProvincias(DataSourceLoadOptions loadOptions)
        {
            LoadResult Resultado = new LoadResult();
            try
            {

                Resultado = DataSourceLoader.Load(_bussinessLogic.ObtenerProvincias(), loadOptions);

            }
            catch (Exception e)
            {

            }
            return new JsonResult(Resultado);

        }

        public IActionResult OnGetCargaSubtiposOrganismos(DataSourceLoadOptions loadOptions)
        {
            LoadResult Resultado = new LoadResult();
            try
            {

                Resultado = DataSourceLoader.Load(_bussinessLogic.ObtenerSubTipoOrganismos(), loadOptions);

            }
            catch (Exception e)
            {

            }
            return new JsonResult(Resultado);

        }

        public IActionResult OnGetCargaTipoOrganismo(DataSourceLoadOptions loadOptions)
        {
            LoadResult Resultado = new LoadResult();
            try
            {

                Resultado = DataSourceLoader.Load(_bussinessLogic.ObtenerTipoOrganismo(), loadOptions);

            }
            catch (Exception e)
            {

            }
            return new JsonResult(Resultado);

        }

        public IActionResult OnGetCargaCuentas(DataSourceLoadOptions loadOptions, int Id)
        {
            LoadResult Resultado = new LoadResult();
            try
            {

                Resultado = DataSourceLoader.Load(_bussinessLogic.ObtenerCuentas(Id), loadOptions);

            }
            catch (Exception e)
            {

            }
            return new JsonResult(Resultado);

        }

        public IActionResult OnGetCargaContactos(DataSourceLoadOptions loadOptions, int Id)
        {
            LoadResult Resultado = new LoadResult();
            try
            {

                Resultado = DataSourceLoader.Load(_bussinessLogic.ObtenerContactos(Id), loadOptions);

            }
            catch (Exception e)
            {

            }
            return new JsonResult(Resultado);

        }
        
        public IActionResult OnPostInsertOrganismo(string values)
        {

            try
            {

                _bussinessLogic.InsertarOrganismo(values);
                return StatusCode(StatusCodes.Status200OK, "EXITO");

            }
            catch (Exception e)
            {
                return BadRequest("Error al Insertar");
            }

        }
       
        public IActionResult OnPutUpdateOrganismo(int key, string values)
        {
            
            try
            {

                _bussinessLogic.ActualizarOrganismo(key,values);
                return StatusCode(StatusCodes.Status200OK, "EXITO");

            }
            catch (Exception e)
            {
                return BadRequest("Error al Actualizar");
            }

        }
       
        public IActionResult OnDeleteKillOrganismo(int key)
        {
            
            try
            {

                _bussinessLogic.KillOrganismo(key);
                return StatusCode(StatusCodes.Status200OK, "EXITO");

            }
            catch (Exception e)
            {
                return BadRequest("Error al Eliminar");
            }

        }
    }
}
