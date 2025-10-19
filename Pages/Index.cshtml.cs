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
                    Title = "TRANSFORMANDO GERAÇÕES",
                    Description = "Cremos que o evangelho é o poder de Deus para transformar vidas e famílias. Neste ano, somos desafiados a viver uma fé que inspira e ensina a nova geração a andar com Cristo, moldando corações e histórias segundo a Palavra.",
                    Link = "/TransformandoGeracoes"
                },
                new Slide
                {
                    ImagePath = "/images/zelo-escrituras.png",
                    Title = "ZELO PELAS ESCRITURAS",
                    Description = "Cremos que a Palavra de Deus é viva, suficiente e inspirada pelo Espírito Santo. Como igreja, buscamos crescer no conhecimento das Escrituras, para que nossa fé seja firmada na verdade e nossa prática reflita a vontade do Senhor.",
                    Link = "/Teologia"
                },
                new Slide
                {
                    ImagePath = "/images/ainda-ha-lugar.png",
                    Title = "AINDA HÁ LUGAR",
                    Description = "Jesus convida todos a se achegarem a Ele. O projeto Ainda Há Lugar é um movimento evangelístico da ICE que leva a mensagem do evangelho com amor, esperança e verdade, para que mais pessoas encontrem salvação em Cristo.",
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
