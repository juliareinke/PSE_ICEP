using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace PSE_ICEP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Slide> Slides { get; set; } = new();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Slides = new List<Slide>
            {
                 new Slide
                {
                    ImagePath = "/images/transformando-geracoes.png",
                    Title = "TRANSFORMANDO GERA��ES",
                    Description = "Cremos que o evangelho � o poder de Deus para transformar vidas e fam�lias. Neste ano, somos desafiados a viver uma f� que inspira e ensina a nova gera��o a andar com Cristo, moldando cora��es e hist�rias segundo a Palavra.",
                    Link = "/TransformandoGeracoes"
                },
                new Slide
                {
                    ImagePath = "/images/zelo-escrituras.png",
                    Title = "ZELO PELAS ESCRITURAS",
                    Description = "Cremos que a Palavra de Deus � viva, suficiente e inspirada pelo Esp�rito Santo. Como igreja, buscamos crescer no conhecimento das Escrituras, para que nossa f� seja firmada na verdade e nossa pr�tica reflita a vontade do Senhor.",
                    Link = "/Teologia"
                },
                new Slide
                {
                    ImagePath = "/images/ainda-ha-lugar.png",
                    Title = "AINDA H� LUGAR",
                    Description = "Jesus convida todos a se achegarem a Ele. O projeto Ainda H� Lugar � um movimento evangel�stico da ICE que leva a mensagem do evangelho com amor, esperan�a e verdade, para que mais pessoas encontrem salva��o em Cristo.",
                    Link = "/Evangelizacao"
                }
            };
        }
    }

    public class Slide
    {
        public string ImagePath { get; set; } = "";
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Link { get; set; } = "";
    }
}
