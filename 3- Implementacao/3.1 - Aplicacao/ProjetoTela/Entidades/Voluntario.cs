using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades
{
    public class Voluntario
    {
        private int _codVoluntario;
        private string _motivoVoluntariado;
        private string _tempoDisponivel;
        private string _especialidades;
        private int _grauEscolaridade;
        private string _cursoFormacao;
        private string _profissao;
        private string _experienciaProfissional;


        public int codVoluntario
        {
            get { return _codVoluntario; }
            set { _codVoluntario = value; }
        }

        public string motivoVoluntariado
        {
            get { return _motivoVoluntariado; }
            set { _motivoVoluntariado = value; }
        }

        public string tempoDisponivel
        {
            get { return _tempoDisponivel; }
            set { _tempoDisponivel = value; }
        }

        public string especialidades
        {
            get { return _especialidades; }
            set { _especialidades = value; }
        }

        public int grauEscolaridade
        {
            get { return _grauEscolaridade; }
            set { _grauEscolaridade = value; }
        }

        public string cursoFormacao
        {
            get { return _cursoFormacao; }
            set { _cursoFormacao = value; }
        }

        public string profissao
        {
            get { return _profissao; }
            set { _profissao = value; }
        }

        public string experienciaProfissional
        {
            get { return _experienciaProfissional; }
            set { _experienciaProfissional = value; }
        }

    }
}