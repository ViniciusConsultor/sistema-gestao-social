﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGS.Entidades.DTO
{

    [Serializable]
    public class EscolarDTO
    {

        #region Construtores

        /// <summary>
        /// Construtor com parâmetro
        /// </summary>
        /// <param name="umEscolar"></param>
        public EscolarDTO(Escolar umEscolar)
        {
            this.Escolar = umEscolar;
        }

        /// <summary>
        /// Construtor sem parâmetro
        /// </summary>
        public EscolarDTO()
        {
            Escolar = new Escolar();
        }

        #endregion

        #region Propriedades

        Escolar _escolar;

        /// <summary>
        /// Um objeto Escolar
        /// </summary>
        public Escolar Escolar
        {
            get { return _escolar; }
            set { _escolar = value; }
        }


        private List<Assistido> _assistidoLista;

        public List<Assistido> AssistidoLista
        {
            set { _assistidoLista = value; }
            get { return _assistidoLista; }
        }

        #endregion

    }
}