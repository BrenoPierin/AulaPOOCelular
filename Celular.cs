using System;

namespace AulaPOOCelular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;
        public string desligado;
        public string mensagem;
        public string ligacao;
    public string EnviarMensagem(){

        bool enviado = ligado;
            if(ligado){
                mensagem = Console.WriteLine("Enviando mensagem...");

            }else{
                mensagem = Console.WriteLine("Ligue seu apaelho primeiro");
            }
         return mensagem
    }

    public string ligar(){
        bool chamando = ligado;
            if(ligado){
                ligacao = Console.WriteLine("chamando...");
            }else{
                ligacao = Console.WriteLine("Ligue seu apaelho primeiro");
            }
         return ligacao;

    }


}
}