using Microsoft.AspNetCore.Mvc;
using Galindo_Fernando_primera_aplicación_web.Models;
using Galindo_Fernando_primera_aplicación_web.Repositorio;

namespace Galindo_Fernando_primera_aplicación_web.Controllers;

public class EquipoController : Controller
{
    private readonly EquipoRepository _equipoRepository;

    public EquipoController()
    {
        _equipoRepository = new EquipoRepository(); // Considera usar Inyección de Dependencias
        
        
    }

    public IActionResult List()
    {
        var equipos = _equipoRepository.DevuelveListadoEquipos();
        return View(equipos);
    }

    // Acción para mostrar el formulario de creación
    public IActionResult Create()
    {
        return View(); // Necesitarás una vista llamada Create.cshtml
    }

    // Acción para procesar el envío del formulario de creación
    [HttpPost]
    public IActionResult Create(Equipo equipo)
    {
        if (ModelState.IsValid)
        {
            _equipoRepository.AgregarEquipo(equipo); // Implementa este método en tu repositorio
            return RedirectToAction("List");
        }
        return View(equipo); // Vuelve a la vista con errores si el modelo no es válido
    }

    // Acción para mostrar el formulario de edición
    public IActionResult EditarEquipos(int id)
    {
        var equipo = _equipoRepository.ObtenerEquipoPorId(id); // Implementa este método
        if (equipo == null)
        {
            return NotFound();
        }
        return View(equipo); // Necesitarás una vista llamada EditarEquipos.cshtml
    }

    // Acción para procesar el envío del formulario de edición
    [HttpPost]
    public IActionResult EditarEquipos(int id, Equipo equipo)
    {
        if (ModelState.IsValid)
        {
            equipo.Id = id;
            _equipoRepository.ActualizarEquipo(equipo); // Implementa este método
            return RedirectToAction("List");
        }
        return View(equipo);
    }

    // Acción para mostrar los detalles de un equipo
    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var equipo = _equipoRepository.ObtenerEquipoPorId(id.Value); // Implementa este método
        if (equipo == null)
        {
            return NotFound();
        }
        return View(equipo); // Necesitarás una vista llamada Details.cshtml
    }

    // Acción para mostrar la confirmación de eliminación
    public IActionResult Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var equipo = _equipoRepository.ObtenerEquipoPorId(id.Value); // Implementa este método
        if (equipo == null)
        {
            return NotFound();
        }
        return View(equipo); // Necesitarás una vista llamada Delete.cshtml
    }

    // Acción para procesar la eliminación
    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        _equipoRepository.EliminarEquipo(id); // Implementa este método
        return RedirectToAction("List");
    }
}