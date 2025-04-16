using Microsoft.AspNetCore.Mvc;
using Galindo_Fernando_primera_aplicación_web.Models;
using Galindo_Fernando_primera_aplicación_web.Repositorio;

namespace Galindo_Fernando_primera_aplicación_web.Controllers;

public class EquipoController : Controller
{
    private readonly EquipoRepository _equipoRepository;

    public EquipoController()
    {
        _equipoRepository = new EquipoRepository(); 
        
        
    }

    public IActionResult List()
    {
        var equipos = _equipoRepository.DevuelveListadoEquipos();
        return View(equipos);
    }

    
    public IActionResult Create()
    {
        return View(); 
    }

    
    [HttpPost]
    public IActionResult Create(Equipo equipo)
    {
        if (ModelState.IsValid)
        {
            _equipoRepository.AgregarEquipo(equipo); 
            return RedirectToAction("List");
        }
        return View(equipo); 
    }

   
    public IActionResult EditarEquipos(int id)
    {
        var equipo = _equipoRepository.ObtenerEquipoPorId(id); 
        if (equipo == null)
        {
            return NotFound();
        }
        return View(equipo); 
    }

    
    [HttpPost]
    public IActionResult EditarEquipos(int id, Equipo equipo)
    {
        if (ModelState.IsValid)
        {
            equipo.Id = id;
            _equipoRepository.ActualizarEquipo(equipo); 
            return RedirectToAction("List");
        }
        return View(equipo);
    }

    
    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var equipo = _equipoRepository.ObtenerEquipoPorId(id.Value); 
        if (equipo == null)
        {
            return NotFound();
        }
        return View(equipo); 
    }

    
    public IActionResult Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var equipo = _equipoRepository.ObtenerEquipoPorId(id.Value); 
        if (equipo == null)
        {
            return NotFound();
        }
        return View(equipo); 
    }

    
    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        _equipoRepository.EliminarEquipo(id); 
        return RedirectToAction("List");
    }
}