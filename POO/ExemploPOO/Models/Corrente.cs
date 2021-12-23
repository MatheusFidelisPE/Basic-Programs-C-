namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor){
            if(base.saldo == 0){
                base.saldo = valor;
            }
            else{
                base.saldo += valor;
            }
        }        
    }
}