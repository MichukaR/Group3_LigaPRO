

using System.Numerics;
using Galindo_Fernando_primera_aplicación_web.Models;
using Galindo_Fernando_primera_aplicación_web.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Galindo_Fernando_primera_aplicación_web.Controllers;

public class EquipoController : Controller

public EquipoRepository _repository

public EquipoController(){
    _repository = new EEquipoRepository
}
{
    public IActionResult List()
    {
        var equipos = _repository.DevuelveListadoEquipos();

        return View(equipos);
    }


    public IActionResult EditarEquipo(int Id){
        var equipo = _repository.DevuelveInformacionEquipo(Id);
        return View(equipo);
    }


    [HttpPost]
    public IActionResult EditarEquipo(Equipo equipo){
        try{
            var actualizar = _repository.AtualizarEquipo(equipo);
            return View();  //retornar tabla de posiciones actualizada
        }
        catch(Exception e){

            throw;
        }
    }
}