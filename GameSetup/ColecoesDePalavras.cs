using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavraCerta.Setup
{
    public sealed class ColecoesDePalavras
    {
        private ColecoesDePalavras instance = new ColecoesDePalavras();
        private ColecoesDePalavras()
        {

        }
        public ColecoesDePalavras Instance => instance ??= new ColecoesDePalavras();
        
        string[] animais = new string[] {
    "abelha",
    "água-viva",
    "arara",
    "baleia",
    "borboleta",
    "cachorro",
    "camelo",
    "canguru",
    "cavalo",
    "cobra",
    "coelho",
    "coruja",
    "crocodilo",
    "elefante",
    "gato",
    "girafa",
    "hamster",
    "hipopótamo",
    "iguana",
    "jacaré",
    "lagosta",
    "leão",
    "leopardo",
    "lhama",
    "lobo",
    "macaco",
    "medusa",
    "mosquito",
    "onça",
    "ornitorrinco",
    "panda",
    "pantera",
    "papagaio",
    "pato",
    "peixe",
    "pinguim",
    "pombo",
    "porco",
    "puma",
    "rato",
    "rinoceronte",
    "sapo",
    "tartaruga",
    "tigre",
    "toupeira",
    "urso",
    "vaca",
    "zebra"
};

        string[] pessoas = new string[] {
    "Isabella Oliveira",
    "Enzo Santos",
    "Maria Souza",
    "Gustavo Silva",
    "Lara Costa",
    "Lucas Lima",
    "Mariana Fernandes",
    "Rafaela Pereira",
    "Pedro Almeida",
    "Luiza Castro",
    "Gabriel Ribeiro",
    "Fernanda Barbosa",
    "João Mendes",
    "Carolina Ferreira",
    "Vinícius Gomes",
    "Ana Luiza Nunes",
    "Matheus Costa",
    "Amanda Santos",
    "Thiago Rodrigues",
    "Lorena Cardoso",
    "Diego Oliveira",
    "Juliana Martins",
    "Raphaela Costa",
    "Leonardo Sousa",
    "Bianca Lima",
    "Daniel Carvalho",
    "Nathália Oliveira",
    "Lucas Fernandes",
    "Fernanda Vieira",
    "Rodrigo Pereira",
    "Natália Alves",
    "Ricardo Santos",
    "Beatriz Castro",
    "Henrique Rodrigues",
    "Julia Oliveira",
    "Lucas Oliveira",
    "Camila Silva",
    "Arthur Ribeiro",
    "Mariana Santos",
    "Bruno Carvalho",
    "Ana Carolina Ferreira",
    "Guilherme Costa",
    "Helena Fernandes",
    "Giovanni Souza",
    "Luana Oliveira",
    "Thiago Martins",
    "Lívia Sousa",
    "Gustavo Pereira",
    "Carla Silva"
};

        string[] motos = {
            "Hayabusa",
            "Ninja",
            "Monster",
            "Ducati",
            "Harley Davidson",
            "Vulcan",
            "Yamaha",
            "Suzuki GSXR",
            "Triumph Rocket",
            "BMW RR",
            "Kawasaki Z",
            "Honda CBR",
            "Aprilia",
            "Moto Guzzi",
            "KTM RC",
            "Ducati Scrambler",
            "Harley Softail",
            "Suzuki Bandit",
            "Yamaha XSR",
            "BMW GS",
            "Triumph Tiger",
            "Kawasaki Versys",
            "Honda Africa Twin",
            "Aprilia Tuono",
            "Moto Guzzi",
            "KTM Adventure",
            "Ducati Diavel",
            "Harley Sportster",
            "Suzuki Intruder",
            "Yamaha Bolt",
            "BMW S",
            "Triumph Bonneville",
            "Kawasaki W",
            "Honda Rebel",
            "Aprilia Shiver",
            "Moto Guzzi V85",
            "KTM Enduro",
            "Ducati Multistrada",
            "Harley Touring",
            "Suzuki Hayate",
            "Yamaha Fazer",
            "BMW R",
            "Triumph Speed",
            "Kawasaki Ninja",
            "Honda Interceptor",
            "Aprilia Mana",
            "Moto Guzzi Griso",
            "KTM Duke"
        };

        string[] carros = {
            "Gol",
            "Clio",
            "Corolla",
            "Civic",
            "Fiesta",
            "Fusca",
            "Fox",
            "Onix",
            "Uno",
            "Palio",
            "Sandero",
            "Logan",
            "Prisma",
            "Versa",
            "Voyage",
            "Siena",
            "Celta",
            "Ka",
            "Fiorino",
            "Saveiro",
            "Strada",
            "Ranger",
            "Hilux",
            "Frontier"
            };

        string[] frutas = {
            "Abacate",
            "Abacaxi",
            "Acerola",
            "Ameixa",
            "Banana",
            "Caju",
            "Carambola",
            "Cereja",
            "Coco",
            "Figo",
            "Goiaba",
            "Grapes",
            "Jabuticaba",
            "Kiwi",
            "Laranja",
            "Limão",
            "Maçã",
            "Manga",
            "Maracujá",
            "Melancia",
            "Melão",
            "Morango",
            "Pêra",
            "Pêssego",
            "Uva"
        };

        string[] paises = {
            "Afeganistão", "África do Sul", "Albânia", "Alemanha", "Andorra",
            "Angola", "Antígua e Barbuda", "Arábia Saudita", "Argélia", "Argentina",
            "Armênia", "Austrália", "Áustria", "Azerbaijão", "Bahamas",
            "Bangladesh", "Barbados", "Bareine", "Belarus", "Bélgica",
            "Belize", "Benin", "Bermudas", "Bolívia", "Bósnia e Herzegovina",
            "Botswana", "Brasil", "Brunei", "Bulgária", "Burkina Faso",
            "Burundi", "Butão", "Cabo Verde", "Camarões", "Camboja",
            "Canadá", "Catar", "Cazaquistão", "Chade", "Chile",
            "China", "Chipre", "Cingapura", "Colômbia", "Comores",
            "Coreia do Norte", "Coreia do Sul", "Costa do Marfim", "Costa Rica", "Croácia",
        };
    
        public string SelecionarPalavra(Categoria categoria)
        {
            var r = new Random();

            switch (categoria)
            {
                case Categoria.animais:
                    return animais[r.Next(0, animais.Length)];
                case Categoria.carros:
                    return carros[r.Next(0, carros.Length)];
                case Categoria.frutas:
                    return frutas[r.Next(0, frutas.Length)];
                case Categoria.motos:
                    return motos[r.Next(0, motos.Length)];
                case Categoria.paises:
                    return paises[r.Next(0, paises.Length)];
                case Categoria.pessoas:
                    return pessoas[r.Next(0, pessoas.Length)];
                default:
                    return animais[r.Next(0, animais.Length)];
            }

        }
        
    }
}
