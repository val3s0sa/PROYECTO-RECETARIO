using System;


internal class Program
{
    private static void Main(string[] args)
    {
        int n2, n3, n4, n5, n6, n7, nX1;
        string nop;

        Console.WriteLine("BUEN DIA, BIENVENIDO A NUESTRO RECETARIO NAVIDEÑO, SE TE DARAN VARIAS OPCIONES DE CADA PLATILLO NAVIDEÑO DE ACUERDO A SU PRESUPUESTO, INGRESE SU PRESUPUESTO PARA HACER UN PLATILLO NAVIDEÑO");
        n2 = int.Parse(Console.ReadLine());
        if (n2 >= 300)
            
        {

            Console.WriteLine("TIENES " + n2 + " PESOS SELECCIONE EL NUMERO DEL PLATILLO NAVIDEÑO DESEADO, A CORDE A SU PRESUPUESTO");
            Console.WriteLine("1- APERITIVOS");
            Console.WriteLine("2- CENA");
            Console.WriteLine("3- POSTRE");
            n3 = int.Parse(Console.ReadLine());

            if (n3 == 1)
            {
                Console.WriteLine("HAS ESCOGIDO LA OPCION DE APERITIVOS, LOS PLATILLOS SON LOS SIGUIENTES, ESCOGE UN NUMERO DE UN PLATILLO:");
                Console.WriteLine("1- FRITURAS");
                Console.WriteLine("2- VERDURA AHUMADA");
                Console.WriteLine("3- CARNES FRIAS");
                Console.WriteLine("4- TARTALETAS");
                Console.WriteLine("5- MINI EMPANADAS");
                n4 = int.Parse(Console.ReadLine());


                Console.WriteLine("FELICIDADES escogiste APERITIVOS tu receta es esta");
                if (n4 == 1)
                {
                    Console.WriteLine("1 COMPRAR FRITURAS");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("2 SERVIR EN UN PLATO ");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("3 AGREGARLE SALSA (OPCIONAL)");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("4 SERVIR");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("DISTRUTE SU APERITIVO :)");
                }
                else if (n4 == 2)
                {
                    Console.WriteLine("1 ");
                    Console.WriteLine("2 ");
                    Console.WriteLine("3 ");
                    Console.WriteLine("4 ");
                    Console.WriteLine(":)");
                }


            }
            else if (n3 == 2)
            {
                Console.WriteLine("HAS ESCOGIDO LA OPCION DE CENA, LOS PLATILLOS SON LOS SIGUIENTES, ESCOGE UN NUMERO DE UN PLATILLO:");
                Console.WriteLine("1- Croquetas de jamón y huevo duro.");
                Console.WriteLine("2- Gambones");
                Console.WriteLine("3- Hojaldras con mole");
                Console.WriteLine("4- Tamales");
                Console.WriteLine("5- Pozole");
                Console.WriteLine("6- Albondigas Suecas");
                Console.WriteLine("7- Crema");

                n5 = int.Parse(Console.ReadLine());

                if (n5 == 1)
                {
                    Console.WriteLine("ESCOJISTE: CROQUETAS DE JAMÓN Y HUEVO DURO, PRESIONE ENTER PARA CONTINUAR");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("INGREDIENTES PARA 6 PERSONAS");
                    Console.WriteLine("Leche entera.....600 ml");
                    Console.WriteLine("1 Cucharada sopera de Mantequilla");
                    Console.WriteLine("1 Cucharada Sopera Colmadade Harina de Trigo");
                    Console.WriteLine("100 G Jamon Ibérico Finamente Picado");
                    Console.WriteLine("2 Huevos");
                    Console.WriteLine("100 G de pan Molido");
                    nop = String.Format(Console.ReadLine());

                    Console.WriteLine("PROCEDIMIENTO");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("Paso Numero 1");
                    Console.WriteLine("Picamos bien el jamón ibérico para que quede en taquitos muy pequeños. Ponemos en la sartén la mantequilla y la harina y en cuanto se funde la primera, removemos y agregamos la mitad del jamón, para que este quede envuelto en esa masa o roux. Muy despacio, vamos añadiendo la leche a chorritos, dejando que la masa la vaya absorbiendo antes de añadir más.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("Paso Numero 2");
                    Console.WriteLine("De esta manera, nunca nos saldrán grumos, mientras que si añadimos toda la leche de golpe, tendremos que trabajar más removiendo para disolverlos correctamente. Mientras, cocemos los huevos y los pelamos, picándolos también muy finamente. Conforme la bechamel va espesando y terminamos de añadir toda la leche, vamos probando de sal, porque el jamón puede ser suficiente para sazonar nuestra pasta de croquetas. Cuando prácticamente esté en su punto, añadimos el resto del jamón y el huevo duro picado.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("Paso Numero 3");
                    Console.WriteLine("Sabremos que ya está lista cuando toda la sartén se llene de burbujas, y al remover la pasta haga un ruidito con la sartén, formando caminitos o pasillos al pasar la cuchara. Sacamos la bechamel y la dejamos enfriar en una fuente. Yo la cubro con un film de cocina para que no haga costra. Cuando la pasta está bien fría, formamos las croquetas y las envolvemos en huevo batido y pan rallado, friéndolas en tandas de cuatro o cinco croquetas en aceite muy caliente. Así conseguimos que no se nos abran y nos lleguen con un aspecto bien apetecible a la mesa.");
                    Console.WriteLine("DISFRUTE SU PLATILLO :)");
                }
                if (n5 == 2)
                {
                    Console.WriteLine("ESCOJISTE: GAMBONES, PRESIONA ENTER PARA CONTINUAR");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("INGREDIENTES");
                    Console.WriteLine("6 Gambones Por Persona");
                    Console.WriteLine("8 Dientes de Ajo");
                    Console.WriteLine("1 guindilla cayena");
                    Console.WriteLine("8 Dientes de Ajo");
                    Console.WriteLine("Aceite de oliva virgen extra");
                    Console.WriteLine("8 Dientes de Ajo");
                    Console.WriteLine("Sal");
                    nop = String.Format(Console.ReadLine());

                    Console.WriteLine("PROCEDIEMIENTO");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 1");
                    Console.WriteLine("omenzaremos pelando los gambones y quitando la tripa de los mismos. Siempre la tenemos que quitar porque es donde está todos sus desperdicios. Pelamos y hacemos un corte a lo largo del cuerpo y quitamos la tripa del gambçon, es muy fácil.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 2");
                    Console.WriteLine("Pelamos y laminamos los dientes de ajo y reservamos.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 3");
                    Console.WriteLine("En una sartén o cazuela de barro, agregamos una buena cantidad de aceite y añadimos los ajos y la cayena. Lo dejamos durante 10 minutos a fuego suave ya que queremos que se hagan muy lentamente. Si los doramos mucho puede que amarguen y no queremos eso.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 4");
                    Console.WriteLine("Cuando tengamos los ajos pochados, añadimos los gambones y subimos el fuego. Cocinamos 1 minuto por cada lado y listo.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("SERVIMOS EN UN PLATO Y A DISFRUTAR");




                }
                if (n5 == 3)
                {
                    Console.WriteLine("ESCOJISTE: OJALDRAS CON MOLE, PRESIONA ENTER PARA CONTINUAR");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("INGREDIENTES");
                    Console.WriteLine("500 Gramos Mole almendrado, en pasta'");
                    Console.WriteLine("1/4 Pieza Cebolla almendrado, en pasta'");
                    Console.WriteLine("1 Pieza Ajo diente");
                    Console.WriteLine("1 Cubo Concentrado de Tomate con Pollo");
                    Console.WriteLine("1 1/2 Taza Agua");
                    Console.WriteLine("1/4 Cucharadita Canela molida");
                    Console.WriteLine("1/4 Cucharadita Pimienta negra molida");
                    Console.WriteLine("1/4 Cucharadita Sal con ajo en polvo");
                    Console.WriteLine("1 Pieza Pechuga de pollo cocida y deshebrada");
                    Console.WriteLine("Chocolate en barra");
                    Console.WriteLine("PRESIONA ENTER PARA CONTINUAR");
                    nop = String.Format(Console.ReadLine());

                    Console.WriteLine("PROCEDIEMIENTO");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 1");
                    Console.WriteLine("Licúa el mole con la cebolla, el ajo, el Concentrado de Tomate con Pollo, el agua, la canela, la pimienta, la sal con ajo, el Chocolate y la Leche Evaporada. Vierte en una olla y calienta hasta que espese ligeramente, moviendo constantemente");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 2");
                    Console.WriteLine("Agrega el pollo, mezcla y cocina por unos minutos más");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 3");
                    Console.WriteLine("'Rellena las hojaldras con la mezcla anterior");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("SERVIMOS EN UN PLATO Y A DISFRUTAR");
                }
                if (n5 == 4)
                {
                    Console.WriteLine("ESCOJISTE: TAMALES, PRESIONA ENTER PARA CONTINUAR");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("INGREDIENTES");
                    Console.WriteLine("250 gramos de manteca de cerdo, (para la masa)");
                    Console.WriteLine("500 gramos de harina para tamales, (para la masa)");
                    Console.WriteLine("1 taza de caldo de pollo, (para la masa)");
                    Console.WriteLine("1 cucharadita de polvo para hornear, (para la masa)");
                    Console.WriteLine("1 cucharadita de sal, (para la masa)");
                    Console.WriteLine("1 cucharadita de pimienta, (para la masa)");
                    Console.WriteLine("1 litro de agua");
                    Console.WriteLine("500 gramos de tomate verde");
                    Console.WriteLine("5 chiles serranos");
                    Console.WriteLine("1 diente de ajo, sin cáscara");
                    Console.WriteLine("1/4 cebollas");
                    Console.WriteLine("3 cucharadas de aceite");
                    Console.WriteLine("2 pizcas de sal, fina");
                    Console.WriteLine("1 pizca de pimienta negra, molida");
                    Console.WriteLine("1 pechuga de pollo sin hueso, cocida y desmenuzada.");
                    Console.WriteLine("10 hojas de maíz, para tamal remojadas en agua");
                    Console.WriteLine("PRESIONA ENTER PARA CONTINUAR");
                    nop = String.Format(Console.ReadLine());

                    Console.WriteLine("PROCEDIEMIENTO");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 1");
                    Console.WriteLine("Para la masa, suaviza la manteca con la batidora por 5 minutos.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 2");
                    Console.WriteLine("Agrega el caldo de pollo a la harina poco a poco hasta formar una masa. (cuida que no te quede aguada)");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 3");
                    Console.WriteLine("Agrega la masa a la manteca poco a poco y mezcla. Agrega el polvo para hornear y sazona. Reserva.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 4");
                    Console.WriteLine("Para la salsa, agrega el agua en una olla y ponla el fuego medio, agrega los tomates, el ajo y la cebolla cuece por 10 minutos. Retírales el agua y muele en la licuadora perfectamente.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 5");
                    Console.WriteLine("Calienta en una ollita, el aceite a fuego medio agrega la salsa cuece por 5 minutos y sazona. Reserva.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 6");
                    Console.WriteLine("Toma una hoja de maíz, agrégale dos cucharadas grandes de masa, extiéndelas muy bien, agrega una cucharada de salsa y una cucharada de pollo.");
                    Console.WriteLine("PASO 7");
                    Console.WriteLine("Cierra la hoja de maíz perfectamente y dóblala de abajo hacia arriba. Amárrala con un pedazo de hoja para que no se desarmen. Así arma todos hasta terminar la masa.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 8");
                    Console.WriteLine("Agrega agua en una vaporera, acomoda los tamales y cuécelos a fuego alto por 55 minutos o hasta que estén cocidos.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("SERVIMOS EN UN PLATO Y A DISFRUTAR");
                }
                if (n5 == 5)
                {
                    Console.WriteLine("ESCOJISTE: POZOLE, PRESIONA ENTER PARA CONTINUAR");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("INGREDIENTES");
                    Console.WriteLine("500 Gramos Mole almendrado, en pasta'");
                    Console.WriteLine("1/4 Pieza Cebolla almendrado, en pasta'");
                    Console.WriteLine("1 Pieza Ajo diente");
                    Console.WriteLine("1 Cubo Concentrado de Tomate con Pollo");
                    Console.WriteLine("1 1/2 Taza Agua");
                    Console.WriteLine("1/4 Cucharadita Canela molida");
                    Console.WriteLine("1/4 Cucharadita Pimienta negra molida");
                    Console.WriteLine("1/4 Cucharadita Sal con ajo en polvo");
                    Console.WriteLine("1 Pieza Pechuga de pollo cocida y deshebrada");
                    Console.WriteLine("Chocolate en barra");
                    Console.WriteLine("PRESIONA ENTER PARA CONTINUAR");
                    nop = String.Format(Console.ReadLine());

                    Console.WriteLine("PROCEDIEMIENTO");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 1");
                    Console.WriteLine("Licúa el mole con la cebolla, el ajo, el Concentrado de Tomate con Pollo, el agua, la canela, la pimienta, la sal con ajo, el Chocolate y la Leche Evaporada. Vierte en una olla y calienta hasta que espese ligeramente, moviendo constantemente");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 2");
                    Console.WriteLine("Agrega el pollo, mezcla y cocina por unos minutos más");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 3");
                    Console.WriteLine("'Rellena las hojaldras con la mezcla anterior");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("SERVIMOS EN UN PLATO Y A DISFRUTAR");
                }
                if (n5 == 6)
                {
                    Console.WriteLine("ESCOJISTE: ALBONDIGAS SUECAS, PRESIONA ENTER PARA CONTINUAR");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("INGREDIENTES");
                    Console.WriteLine("2 Tazas de Puré de tomate");
                    Console.WriteLine("1 Chile chipotle");
                    Console.WriteLine("2 Cubos de Concentrado de Tomate con Pollo");
                    Console.WriteLine("1 Cucharada de Aceite de maíz");
                    Console.WriteLine("800 Gramos Carne de res molida");
                    Console.WriteLine("100 Gramos de Tocino picado y frito");
                    Console.WriteLine("1 Huevo");
                    Console.WriteLine("2 Cucharadas de Jugo MAGGI");
                    Console.WriteLine("1 Cucharada de Salsa Tipo Inglesa");
                    Console.WriteLine("2 Cucharadas de Cebolla finamente picada");
                    Console.WriteLine("PRESIONA ENTER PARA CONTINUAR");
                    nop = String.Format(Console.ReadLine());

                    Console.WriteLine("PROCEDIEMIENTO");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 1");
                    Console.WriteLine("Para la salsa, licúa el puré de tomate, el chile, el agua y el Concentrado de Tomate con Pollo CONSOMATE®. Calienta el aceite en una olla y cocina la salsa a fuego medio por 10 minutos");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 2");
                    Console.WriteLine("Para las albóndigas, mezcla la carne con el tocino, la cebolla, el huevo, el Jugo MAGGI® y la Salsa Tipo Inglesa CROSSE & BLACKWELL®. Forma las albóndigas, colócalas en la salsa, tapa y cocina por 20 minutos a fuego medio o hasta que estén cocidas");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("SERVIMOS EN UN PLATO Y A DISFRUTAR");
                }
                if (n5 == 7)
                {
                    Console.WriteLine("ESCOJISTE: CREMA, PRESIONA ENTER PARA CONTINUAR");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("INGREDIENTES");
                    Console.WriteLine("500 Gramos Mole almendrado, en pasta'");
                    Console.WriteLine("1/4 Pieza Cebolla almendrado, en pasta'");
                    Console.WriteLine("1 Pieza Ajo diente");
                    Console.WriteLine("1 Cubo Concentrado de Tomate con Pollo");
                    Console.WriteLine("1 1/2 Taza Agua");
                    Console.WriteLine("1/4 Cucharadita Canela molida");
                    Console.WriteLine("1/4 Cucharadita Pimienta negra molida");
                    Console.WriteLine("1/4 Cucharadita Sal con ajo en polvo");
                    Console.WriteLine("1 Pieza Pechuga de pollo cocida y deshebrada");
                    Console.WriteLine("Chocolate en barra");
                    Console.WriteLine("PRESIONA ENTER PARA CONTINUAR");
                    nop = String.Format(Console.ReadLine());

                    Console.WriteLine("PROCEDIEMIENTO");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 1");
                    Console.WriteLine("Licúa el mole con la cebolla, el ajo, el Concentrado de Tomate con Pollo, el agua, la canela, la pimienta, la sal con ajo, el Chocolate y la Leche Evaporada. Vierte en una olla y calienta hasta que espese ligeramente, moviendo constantemente");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 2");
                    Console.WriteLine("Agrega el pollo, mezcla y cocina por unos minutos más");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 3");
                    Console.WriteLine("'Rellena las hojaldras con la mezcla anterior");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("SERVIMOS EN UN PLATO Y A DISFRUTAR");
                }
                if (n5 == 3)
                {
                    Console.WriteLine("ESCOJISTE: FRESAS CON CREMA");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("INGREDIENTES");
                    Console.WriteLine("1/2 de fresas");
                    Console.WriteLine("CREMA AL GUSTO");
                    Console.WriteLine("AZÚCAR");
                    Console.WriteLine("1 LATA DE LECHERA");
                    nop = String.Format(Console.ReadLine());

                    Console.WriteLine("PROCEDIMIENTO");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("Paso Numero 1");
                    Console.WriteLine("Picaremos las fresas en cuadros medianos o en su caso aplastamos");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("Paso Numero 2");
                    Console.WriteLine("En un recipiente mezclaremos nuestra crema y lechera junto con nuestras fesas hasta cubrirlas y combinar todo.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("DISFRUTE SU PLATILLO :)");
                }
                if (n5 == 4)
                {
                    Console.WriteLine("ESCOJISTE: ARROZ CON LECHE, PRESIONA ENTER PARA CONTINUAR");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("INGREDIENTES");
                    Console.WriteLine("ARROZ ");
                    Console.WriteLine("LECHE");
                    Console.WriteLine("CANELA");
                    Console.WriteLine("UN POCO DE AGUA ");
                    nop = String.Format(Console.ReadLine());

                    Console.WriteLine("PROCEDIEMIENTO");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 1");
                    Console.WriteLine("Se debe remojar la razón por 10 minutos");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 2");
                    Console.WriteLine("Debemos de calentar la leche junto a su canela par así darle sabor y un poco de azúcar.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("PASO 3");
                    Console.WriteLine("Una vez remojado el arroz vertimos en nuestra lecha para así tenerlo en fuego lento para que cuando esponje el arroz poder ver que esta en su punto.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("SERVIMOS EN UN PLATO Y A DISFRUTAR");
                }

                if (n5 == 5)
                {
                    Console.WriteLine("ESCOJISTE: MANZANAS CON CREMA");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("INGREDIENTES");
                    Console.WriteLine("10 Manzanas medianas ");
                    Console.WriteLine("CREMA AL GUSTO");
                    Console.WriteLine("AZÚCAR");
                    Console.WriteLine("1 LATA DE LECHERA");
                    nop = String.Format(Console.ReadLine());

                    Console.WriteLine("PROCEDIMIENTO");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("Paso Numero 1");
                    Console.WriteLine("Primero lavaremos nuestras manzanas y se pelearán.");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("Paso Numero 2");
                    Console.WriteLine("Se cortaran las manzanas en cuadros medianos");
                    nop = String.Format(Console.ReadLine());
                    Console.WriteLine("Paso Numero 3");
                    Console.WriteLine("Las ponemos en un platón vertimos media taza de crema junto con el azúcar y la lechera para así tener una consistencia espesa");
                    Console.WriteLine("Mezclamos hasta cubrir todas las manzanas, podemos verificar el sabor probando un poco para saber si ya están listas");
                    Console.WriteLine("DISFRUTE SU PLATILLO :)");
                }
                else if (n3 == 4)
            
                Console.WriteLine("HAS ESCOGIDO LA OPCION DE BEBIDA, ESCOJE EL TIPO DE BEBIDA DE TU PREFERENCIA:");
                Console.WriteLine("1 CON ALCOHOL ");
                Console.WriteLine("2 SIN ALCOHOL ");
                n6 = int.Parse(Console.ReadLine());
                if (n6 == 1)
                {
                    Console.WriteLine("HAS ESCOJIDO LA OPCION CON ALCOHOL, LAS BEBIDAS, SON LAS SIGUENTES:");

                }
                if (n6 == 2)
                {
                    Console.WriteLine("HAS ESCOJIDO LA OPCION SIN ALCOHOL, LAS BEBIDAS SON LAS SIGUIENTES");
                }
                else
                {
                    Console.WriteLine("NO ESCOJISTE UN NUMERO VALIDO");
                }

            }
        }

        if (n2 <= 99)
        {
            Console.WriteLine("NO CUENTAS CON EL EFECTIVO SUFICIENTE COMO PARA PREPARAR UN PLATILLO");

        }
    }

}
