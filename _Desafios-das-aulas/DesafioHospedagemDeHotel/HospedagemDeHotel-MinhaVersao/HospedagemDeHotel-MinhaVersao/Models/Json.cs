using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HospedagemDeHotel_MinhaVersao.Models
{
    public static class Json 
    {
        private static readonly string _filePath = "C:\\Users\\Vágner Alves\\OneDrive\\Documentos\\DioMe-Curso-CSharp\\_Desafios-das-aulas\\DesafioHospedagemDeHotel\\HospedagemDeHotel-MinhaVersao\\HospedagemDeHotel-MinhaVersao\\HospedariaRegistros\\hospedes.json";
        public static void Serializacao(List<NotasDasReservas> registros)
        {
            string? registro = JsonConvert.SerializeObject(registros, Formatting.Indented);
            File.WriteAllText(_filePath, registro);
        }
        public static List<NotasDasReservas> Deserializacao()
        {
            string? registros = File.ReadAllText(_filePath);
            List<NotasDasReservas> json = JsonConvert.DeserializeObject<List<NotasDasReservas>>(registros) ?? [];
            return json;
        }
    }
}