﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1_Vagas.Modelos
{
    [Table("Vaga")]
    public class Vagas
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NomeVaga { get; set; }
        public string NomeEmpresa { get; set; }
        public short Quantidade { get; set; }
        public string Cidade { get; set; }
        public double Salario { get; set; }
        public string TipoContratacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

    }
}
