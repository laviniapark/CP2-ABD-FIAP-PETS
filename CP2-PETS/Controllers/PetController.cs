using CP2_PETS.Models;
using Microsoft.AspNetCore.Mvc;

namespace CP2_PETS.Controllers;

public class PetController : Controller
{
    private static List<Pet> _lista = new List<Pet>();
    private static int _id = 0;

    [HttpPost]
    public IActionResult Remover(int id)
    {
        _lista.RemoveAt(_lista.FindIndex(p => p.Id == id));
        TempData["msg"] = "Pet removido com sucesso!";
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult Editar(Pet pet)
    {
        var index = _lista.FindIndex(p => p.Id == _id);
        _lista[index] = pet;
        TempData["msg"] = "Pet atualizado com sucesso!";
        return RedirectToAction("Editar");
    }
    
    [HttpGet]
    public IActionResult Editar(int id)
    {
        var index = _lista.FindIndex(p => p.Id == id);
        var pet = _lista[index];
        return View(pet);
    }
    
    public IActionResult Index()
    {
        return View(_lista);
    }

    // VISUALIZAR A LISTA DE PETS
    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    // CADASTRO DO PET
    [HttpPost]
    public IActionResult Cadastrar(Pet pet)
    {
        pet.Id = ++_id;
        _lista.Add(pet);
        TempData["msg"] = "Pet cadastrado!";
        return RedirectToAction("Cadastrar");
    }
}