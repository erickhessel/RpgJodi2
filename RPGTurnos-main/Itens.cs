 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGturnos1
{
    public class Itens
    {
        string[,] equipamento = new string[21, 6];  

        public void cadastrarItem()
        {
            equipamento[0, 0] = "ITEM";
            equipamento[0, 1] = "TIPO";
            equipamento[0, 2] = "VALOR";
            equipamento[0, 3] = "DANO";
            equipamento[0, 4] = "DEFESA";
            equipamento[0, 5] = "SLOTS";
            equipamento[0, 6] = "VELOCIDADE";

            equipamento[1, 0] = "ADAGA";
            equipamento[1, 1] = "ARMA";
            equipamento[1, 2] = "10";
            equipamento[1, 3] = "2";
            equipamento[1, 4] = "1";
            equipamento[1, 5] = "1";
            equipamento[1, 6] = "4";
                
            equipamento[2, 0] = "ESPADA";
            equipamento[2, 1] = "ARMA";
            equipamento[2, 2] = "15";
            equipamento[2, 3] = "4";
            equipamento[2, 4] = "2";
            equipamento[2, 5] = "2";
            equipamento[2, 6] = "2";

            equipamento[3, 0] = "Arco";
            equipamento[3, 1] = "ARMA";
            equipamento[3, 2] = "12";
            equipamento[3, 3] = "4";
            equipamento[3, 4] = "1";
            equipamento[3, 5] = "3";
            equipamento[3, 6] = "3";


            equipamento[4, 0] = "CAJADO";
            equipamento[4, 1] = "ARMA";
            equipamento[4, 2] = "11";
            equipamento[4, 3] = "3";
            equipamento[4, 4] = "2";
            equipamento[4, 5] = "3";
            equipamento[4, 6] = "1";
                
            equipamento[5, 0] = "BASTÃO";
            equipamento[5, 1] = "ARMA";
            equipamento[5, 2] = "8";
            equipamento[5, 3] = "2";
            equipamento[5, 4] = "3";
            equipamento[5, 5] = "3";
            equipamento[5, 6] = "3";

            equipamento[6, 0] = "PEITORAL FERRO";
            equipamento[6, 1] = "ARMADURA";
            equipamento[6, 2] = "16";
            equipamento[6, 3] = "1";
            equipamento[6, 4] = "4";
            equipamento[6, 5] = "3";
                
            equipamento[7, 0] = "PEITORAL COTA DE MALHA";
            equipamento[7, 1] = "ARMADURA";
            equipamento[7, 2] = "12";
            equipamento[7, 3] = "1";
            equipamento[7, 4] = "3";
            equipamento[7, 5] = "2";

            equipamento[8, 0] = "PEITORAL COURO";
            equipamento[8, 1] = "ARMADURA";
            equipamento[8, 2] = "8";
            equipamento[8, 3] = "1";
            equipamento[8, 4] = "2";
            equipamento[8, 5] = "1";


            equipamento[9, 0] = "CAPACETE FERRO";
            equipamento[9, 1] = "ARMADURA";
            equipamento[9, 2] = "12";
            equipamento[9, 3] = "1";
            equipamento[9, 4] = "4";
            equipamento[9, 5] = "2";

            equipamento[10, 0] = "CAPACETE COTA DE MALHA";
            equipamento[10, 1] = "ARMADURA";
            equipamento[10, 2] = "8";
            equipamento[10, 3] = "1";
            equipamento[10, 4] = "3";
            equipamento[10, 5] = "2";


            equipamento[11, 0] = "TOCA COURO";
            equipamento[11, 1] = "ARMADURA";
            equipamento[11, 2] = "6";
            equipamento[11, 3] = "1";
            equipamento[11, 4] = "2";
            equipamento[11, 5] = "1";


            equipamento[12, 0] = "BOTAS FERRO";
            equipamento[12, 1] = "ARMADURA";
            equipamento[12, 2] = "10";
            equipamento[12, 3] = "1";
            equipamento[12, 4] = "3";
            equipamento[12, 5] = "3";

            equipamento[13, 0] = "BOTAS REFORÇADAS";
            equipamento[13, 1] = "ARMADURA";
            equipamento[13, 2] = "8";
            equipamento[13, 3] = "1";
            equipamento[13, 4] = "2";
            equipamento[13, 5] = "2";


            equipamento[14, 0] = "BOTAS COURO";
            equipamento[14, 1] = "ARMADURA";
            equipamento[14, 2] = "5";
            equipamento[14, 3] = "1";
            equipamento[14, 4] = "1";
            equipamento[14, 5] = "2";
                

            equipamento[15, 0] = "LUVAS FERRO";
            equipamento[15, 1] = "ARMADURA";
            equipamento[15, 2] = "8";
            equipamento[15, 3] = "1";
            equipamento[15, 4] = "4";
            equipamento[15, 5] = "3";

            equipamento[16, 0] = "LUVAS REFORÇADAS";
            equipamento[16, 1] = "ARMADURA";
            equipamento[16, 2] = "6";
            equipamento[16, 3] = "1";
            equipamento[16, 4] = "3";
            equipamento[16, 5] = "3";
                
            equipamento[17, 0] = "LUVAS COURO";
            equipamento[17, 1] = "ARMADURA";
            equipamento[17, 2] = "4";
            equipamento[17, 3] = "1";
            equipamento[17, 4] = "2";
            equipamento[17, 5] = "2";

            equipamento[18, 0] = "CALÇAS FERRO";
            equipamento[18, 1] = "ARMADURA";
            equipamento[18, 2] = "12";
            equipamento[18, 3] = "1";
            equipamento[18, 4] = "4";
            equipamento[18, 5] = "4";

            equipamento[19, 0] = "CALÇAS COTA DE MALA";
            equipamento[19, 1] = "ARMADURA";
            equipamento[19, 2] = "8";
            equipamento[19, 3] = "1";
            equipamento[19, 4] = "3";
            equipamento[19, 5] = "3";

            equipamento[20, 0] = "CALÇAS COURO";
            equipamento[20, 1] = "ARMADURA";
            equipamento[20, 2] = "6";
            equipamento[20, 3] = "1";
            equipamento[20, 4] = "2";
            equipamento[20, 5] = "2";
                
            listarItens();
        }


        public void listarItens()
       {
          Console.Write(equipamento);
       }
    }
}
