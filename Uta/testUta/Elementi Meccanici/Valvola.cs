using System;


namespace testUta
{
    public  class Valvola
    {

        double percentuale_Apertura;

        double flussoAttuale;
        double diametro;
        double velocitaAcqua;
        double temperaturaAcqua;

        string funzione;
        double diametro_Metri;
        double raggio;
        double Area_Sezione_Trasversale_Totale;
        double Area_Sezione_Trasversale_Attuale;
        double massa_acqua;
        public Valvola(double apertura, double velocitaAcqua,double temperaturaAcqua,double diametro)
        {
            this.velocitaAcqua = velocitaAcqua;
            this.temperaturaAcqua = temperaturaAcqua;
            this.diametro = diametro;   

            this.percentuale_Apertura = apertura;

        }
        public void aggiorna()
        {
          
            this.diametro_Metri = this.diametro/ 1000;
            this.raggio = diametro_Metri / 2;
            this.Area_Sezione_Trasversale_Totale = Math.PI * Math.Pow(raggio, 2);
            this.Area_Sezione_Trasversale_Attuale = percentuale_Apertura * Area_Sezione_Trasversale_Totale;
            this.flussoAttuale = Area_Sezione_Trasversale_Attuale * this.velocitaAcqua;//[M^3/s]
            double rho = 997;// kg / m³
            this.massa_acqua = this.Area_Sezione_Trasversale_Attuale * rho * velocitaAcqua;
        }
        public double Get_Flusso_attuale() { return flussoAttuale; }    
        public void Set_Apertura_valvola(double apertura) { this.percentuale_Apertura = apertura; }
        public double Get_Velocita_Acqua() { return this.velocitaAcqua; }
        public double Get_Temperatura_Acqua() { return this.temperaturaAcqua; }
        public double Get_Apertura() { return this.percentuale_Apertura; }

    }
}
