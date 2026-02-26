using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DesafioAbstraindoUmCelular_POO.Models
{
    public static class Json
    {
        private static readonly string _filePath_nokia = "C:\\Users\\Vágner Alves\\OneDrive\\Documentos\\DioMe-Curso-CSharp\\_Desafios-das-aulas\\DesafioAbstraindoUmCelular_POO\\DesafioAbstraindoUmCelular_POO\\DataBase\\Json\\nokia.json";
        private static readonly string _filePath_iphone = "C:\\Users\\Vágner Alves\\OneDrive\\Documentos\\DioMe-Curso-CSharp\\_Desafios-das-aulas\\DesafioAbstraindoUmCelular_POO\\DesafioAbstraindoUmCelular_POO\\DataBase\\Json\\iPhone.json";
        public static void Serializacao(string? register, string? modelo)
        {
            if (modelo == "Nokia")
            {
                File.WriteAllText(_filePath_nokia, register);
            } else if (modelo == "iPhone")
            {
                File.WriteAllText(_filePath_iphone, register);
            }
        }
        public static List<Nokia> Desserializacao_Nokia() => JsonConvert.DeserializeObject<List<Nokia>>(File.ReadAllText(_filePath_nokia)) ?? [];
        public static List<IPhone> Desserializacao_iPhone() => JsonConvert.DeserializeObject<List<IPhone>>(File.ReadAllText(_filePath_iphone)) ?? [];
    }
}
