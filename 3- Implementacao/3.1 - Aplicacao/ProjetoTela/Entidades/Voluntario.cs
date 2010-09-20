using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Voluntario
    {
        private int? _codigoVoluntario;
        private int? _pessoa_CodigoPessoa;
        private string _motivoVoluntariado;
        private string _tempoDisponivel;
        private string _especialidades;
        private string _grauEscolaridade;
        private string _cursoFormacao;
        private string _profissao;
        private string _experienciaProfissional;


        public int? CodigoVoluntario
        {
            get { return _codigoVoluntario; }
            set { _codigoVoluntario = value; }
        }

        public int? Pessoa_CodigoPessoa
        {
            get { return _pessoa_CodigoPessoa; }
            set { _pessoa_CodigoPessoa = value; }
        }

        public string MotivoVoluntariado
        {
            get { return _motivoVoluntariado; }
            set { _motivoVoluntariado = value; }
        }

        public string TempoDisponivel
        {
            get { return _tempoDisponivel; }
            set { _tempoDisponivel = value; }
        }

        public string Especialidades
        {
            get { return _especialidades; }
            set { _especialidades = value; }
        }

        public string GrauEscolaridade
        {
            get { return _grauEscolaridade; }
            set { _grauEscolaridade = value; }
        }

        public string CursoFormacao
        {
            get { return _cursoFormacao; }
            set { _cursoFormacao = value; }
        }

        public string Profissao
        {
            get { return _profissao; }
            set { _profissao = value; }
        }

        public string ExperienciaProfissional
        {
            get { return _experienciaProfissional; }
            set { _experienciaProfissional = value; }
        }

    }
}