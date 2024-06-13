using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;
using System.ComponentModel;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instâncias do tipo cliente
        Cliente  cliente1 = new Cliente(01, "Morheno M Bastos", "054.852.451-51", "teste@gmail.com", "Satanás");
        Cliente  cliente2 = new Cliente(02, "Daniela Bastos", "051.852.453-52", "teste2@gmail.com", "Madruguinha");
        Cliente  cliente3 = new Cliente(03, "Alvarez Bastos", "052.852.458-54", "teste3@gmail.com", "Bitoca");
        Cliente  cliente4 = new Cliente(04, "Samuel Bastos", "053.851.451-56", "teste4@gmail.com", "Shazam");
        Cliente  cliente5 = new Cliente(05, "Gustavo Bastos", "054.855.451-59", "teste5@gmail.com", "Paçoca");

        //lista de clientes e clientes atribuidos
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
        
        ViewBag.listaClientes = listaClientes;


        //instâncias do tipo fornecedor e fornecedores atribuidos
        Fornecedor fornecedor1 = new Fornecedor(01 , "C# PET S/A A", "14.182.102/0001-80", "c sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02 , "Ctrl Alt Dog Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03 , "BootsPet INC INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04 , "TikTok Dogs Dogs", "87.945.350/0001-09","noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05 , "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");
        
        //lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
