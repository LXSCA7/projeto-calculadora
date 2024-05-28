using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {   
        [HttpGet("somar")]
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        [HttpGet("subtrair")]
        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        [HttpGet("multiplicar")]
        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        
        [HttpGet("dividir")]
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        [HttpGet("ehpar")]
        public bool EhPar(int num)
        {
            return num % 2 == 0;
        }

        [HttpGet("raizquadrada")]
        public double Raiz(double num)
        {
            return Math.Sqrt(num);
        }

        [HttpGet("potencia")]
        public double Potencia(double numBase, double numExpoente)
        {
            return Math.Pow(numBase, numExpoente);
        }
    }
}