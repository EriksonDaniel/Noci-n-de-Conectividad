using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latam
{
    public partial class Form1 : Form
    {
        Form2 F2;
        private int N = 155;
        string[] Ciudad;
        private Vuelo objVuelo;
        public Form1()
        {
            InitializeComponent();
            //,this.cbOrigen.SelectedIndex = 0;
            //this.cbDestino.SelectedIndex = 0;

            F2=new Form2();
            objVuelo = new Vuelo();
            Ciudad = new string[N];
            Ciudad[0]= "Buenos Aires (BUE), Argentina";
            Ciudad[1]= "Bariloche(BRC), Argentina";
            Ciudad[2]= "Comodoro Rivadavia (CRD), Argentina";
            Ciudad[3]= "Cordoba (COR), Argentina";
            Ciudad[4]= "Mendoza (MDZ), Argentina";
            Ciudad[5]= "Tucuman (TUC), Argentina";
            Ciudad[6]= "Salta (SLA), Argentina";
            Ciudad[7]= "Rio Gallegos (RGL), Argentina";
            Ciudad[8]= "Rosario (ROS), Argentina";
            Ciudad[9]= "Sao Paulo (SAO) ,Brasil";
            Ciudad[10]= "Brasilia (BSB) ,Brasil";
            Ciudad[11]= "Manaos (MAO) ,Brasil";
            Ciudad[12]= "Fortaleza (FOR) ,Brasil";
            Ciudad[13]= "Belo Horizonte (BHZ ),Brasil";
            Ciudad[14]= "Belem (BEL) ,Brasil";
            Ciudad[15]= "Curitiba (CWB) ,Brasil";
            Ciudad[16]= "Rio de Janeiro (RIO) ,Brasil";
            Ciudad[17]= "Porto Alegre (POA) ,Brasil";
            Ciudad[18]= "Florlanopolis (FLN) ,Brasil";
            Ciudad[19]= "Aracaju (AJU) ,Brasil";
            Ciudad[20]= "Santiago de Chile(SCL) ,Chile";
            Ciudad[21]= "Arica (ARI) ,Chile";
            Ciudad[22]= "Temuco (ZCO) ,Chile";
            Ciudad[23]= "La Serena (LSC) ,Chile";
            Ciudad[24]= "Concepción (CCP) ,Chile";
            Ciudad[25]= "Antofagasta (ANF) ,Chile";
            Ciudad[26]= "Copiapó (CPO) ,Chile";
            Ciudad[27]= "Iquique (IQQ) ,Chile";
            Ciudad[28]= "Puerto Montt (PMC) ,Chile";
            Ciudad[29]= "Isla de Pascua (IPC) ,Chile";
            Ciudad[30]= "Santa Marta(SMR) ,Colombia";
            Ciudad[31]= "Tumaco(TCO) ,Colombia";
            Ciudad[32]= "POPAYAN(PPN) ,Colombia";
            Ciudad[33]= "Bucaramanga(BGA) ,Colombia";
            Ciudad[34]= "Montería(MTR) ,Colombia";
            Ciudad[35]= "Bogotá(BOG) ,Colombia";
            Ciudad[36]= "Barrancabermeja(EJA) ,Colombia";
            Ciudad[37]= "Cali(CLO) ,Colombia";
            Ciudad[38]= "Medellín(MDE) ,Colombia";
            Ciudad[39]= "Barranquilla(BAQ) ,Colombia";
            Ciudad[40]= "Valledupar(VUP) ,Colombia";
            Ciudad[41]= "Leticia(LED) ,Colombia";
            Ciudad[42]= "Isla San Andrés(ADZ) ,Colombia";
            Ciudad[43]= "Cartagena de Indias(CTG) ,Colombia";
            Ciudad[44]= "LOJA (LOH) ,Ecuador";
            Ciudad[45]= "Cuenca (CUE) ,Ecuador";
            Ciudad[46]= "Quito (UIO) ,Ecuador";
            Ciudad[47]= "Guayaquil (GYE) ,Ecuador";
            Ciudad[48]= "Baltra,Islas Galápagos(GPS) ,Ecuador";
            Ciudad[49]= "Asuncion (ASU) ,Paraguay";
            Ciudad[50]= "Ciudad del Este (AGT) ,Paraguay";
            Ciudad[51]= "Jaén (JAE) ,Perú";
            Ciudad[52]= "Iquitos (IQT) ,Perú";
            Ciudad[53]= "Lima (LIM) ,Perú";
            Ciudad[54]= "Chiclayoo (CHI) ,Perú";
            Ciudad[55]= "Cusco (CUZ) ,Perú";
            Ciudad[56]= "Piura (PIU) ,Perú";
            Ciudad[57]= "Tumbes (TBP) ,Perú";
            Ciudad[58]= "Arequipa (AQP) ,Perú";
            Ciudad[59]= "Cajamarca (CJA) ,Perú";
            Ciudad[60]= "Trujillo (TRU) ,Perú";
            Ciudad[61]= "Tacna (TCQ) ,Perú";
            Ciudad[62]= "Montevideo (MVD) ,Uruguay";
            Ciudad[63]= "Punta del Este (PDP) ,Uruguay";
            Ciudad[64]= "La Paz (LPB) ,Bolivia";
            Ciudad[65]= "Cochabamba (CBB) ,Bolivia";
            Ciudad[66]= "Santa Cruz (SRZ) ,Bolivia";
            Ciudad[67]= "Toronto (YTO) (YYZ) , Canadá";
            Ciudad[68]= "Montreal (YMQ) (YUL) ,Canadá";
            Ciudad[69]= "Ottawa (YOW) ,Canadá";
            Ciudad[70]= "Vancouver (YVR) , Canadá";
            Ciudad[71]= "Calgary (YYC) , Canadá";
            Ciudad[72]= "Victoria (YYJ) , Canadá";
            Ciudad[73]= "Charlottetown (YYG) , Canadá";
            Ciudad[74]= "Halifax (YHZ) , Canadá";
            Ciudad[75]= "Ciudad de Mexico(MEX) ,México";
            Ciudad[76]= "Monterrey(MTY) ,México";
            Ciudad[77]= "Mérida(MID) ,México";
            Ciudad[78]= "Cancún(CUN) ,México";
            Ciudad[79]= "Morelia(MLM) ,México";
            Ciudad[80]= "Oaxaca(OAX) ,México";
            Ciudad[81]= "Tijuana(TIJ) ,México";
            Ciudad[82]= "Puerto Vallarta(PVR) ,México";
            Ciudad[83]= "Acapulco(ACA) ,México";
            Ciudad[84]= "Guadalajara(GDL) ,México";
            Ciudad[85]= "San José Cabo(SJD) ,México";
            Ciudad[86]= "Veracruz(VER) ,México";
            Ciudad[87]= "Leon(BJX) ,México";
            Ciudad[88]= "TUXTLA GUTIERREZ (TGZ) ,México";
            Ciudad[89]= "Aguascalientes(AGU) ,México";
            Ciudad[90]= "Ciudad Obregón(CEN) ,México";
            Ciudad[91]= "Chihuahua(CUU) ,México";
            Ciudad[92]= "Mazatlán(MZT) ,México";
            Ciudad[93]= "Nuevo Madero(NLD) ,México";
            Ciudad[94]= "San Luis Potosí(SLP) ,México";
            Ciudad[95]= "Ciudad Juárez(CJS) ,México";
            Ciudad[96]= "PUERTO ESCONDIDO(PXM) ,México";
            Ciudad[97]= "Tampa (TPA) ,Estados Unidos";
            Ciudad[98]= "Denver (DEN) ,Estados Unidos";
            Ciudad[99]= "Atlanta (ATL) ,Estados Unidos";
            Ciudad[100]= "Chicago (CHI) MIDWAY (MDW) ,Estados Unidos";
            Ciudad[101]= "Chicago (CHI) OHARE INTL (ORD) ,Estados Unidos";
            Ciudad[102]= "Detroit (DTT) DETROIT METRO(DTW) ,Estados Unidos";
            Ciudad[103]= "Houston (HOU) G.BUSH INTERCONT(IAH) ,Estados Unidos";
            Ciudad[104]= "Memphis (MEM) ,Estados Unidos";
            Ciudad[105]= "Orlando (ORL) (MCO) ,Estados Unidos";
            Ciudad[106]= "Phoenix (PHX) ,Estados Unidos";
            Ciudad[107]= "Seattle (SEA) ,Estados Unidos";
            Ciudad[108]= "Columbus (CMH) ,Estados Unidos";
            Ciudad[109]= "Anchorage (ANC) ,Estados Unidos";
            Ciudad[110]= "Charlotte (CLT) ,Estados Unidos";
            Ciudad[111]= "San Diego (SAN) ,Estados Unidos";
            Ciudad[112]= "Louisville(SDF) ,Estados Unidos";
            Ciudad[113]= "Nueva York (NYC) LA GUARDIA(LGA) ,Estados Unidos";
            Ciudad[114]= "Nueva York (NYC) NEWARK INTL(EWR) ,Estados Unidos";
            Ciudad[115]= "Nueva York (NYC) Jhon F Kennedy(JFK) ,Estados Unidos";
            Ciudad[116]= "Kansas City (MKC) ,Estados Unidos";
            Ciudad[117]= "Minneapolis(MSP) ,Estados Unidos";
            Ciudad[118]= "Jacksonville(JAX) ,Estados Unidos";
            Ciudad[119]= "Los Angeles (LAX) ,Estados Unidos";
            Ciudad[120]= "Dallas (DFW) ,Estados Unidos";
            Ciudad[121]= "San Francisco(SFO) ,Estados Unidos";
            Ciudad[122]= "Las Vegas(LAS) ,Estados Unidos";
            Ciudad[123]= "Miami(MIA) ,Estados Unidos";
            Ciudad[124]= "Boston(BOS) ,Estados Unidos";
            Ciudad[125]= "Philadelphia (PHL) ,Estados Unidos";
            Ciudad[126]= "Fort Lauderdale (FLL) ,Estados Unidos";
            Ciudad[127]= "Washington DC (WAS) R REAGAN NAT (DCA) ,Estados Unidos";
            Ciudad[128]= "Washington DC (WAS) BALTIMORE (BWI) ,Estados Unidos";
            Ciudad[129]= "Salt Lake City (SLC) ,Estados Unidos";
            Ciudad[130]= "Hunulu Huawaii (HNL) ,Estados Unidos";
            Ciudad[131]= " ,Estados UnidosPortLand (PDX)";
            Ciudad[132]= "La Habana (HAV) ,Cuba";
            Ciudad[133]= "Piarco(POS) ,Trinidad yTobago";
            Ciudad[134]= "Castries (SLU) ,Santa Lucia";
            Ciudad[135]= "San Cristobal (SKB) ,San Cristóbal y Nieves";
            Ciudad[136]= "Santo Domingo (SDQ) ,República Dominicana";
            Ciudad[137]= "Punta Cana (PUJ) República Dominicana";
            Ciudad[138]= "Puerto Plata (POP) República Dominicana";
            Ciudad[139]= "La Romana (LRM) República Dominicana";
            Ciudad[140]= "Ciudad de Panamá (PTY) ,Panamá";
            Ciudad[141]= "Managua (MGA) ,Nicaragua";
            Ciudad[142]= "Kingston (KIN) ,Jamaica";
            Ciudad[143]= "Montego Bay (MBJ) ,Jamaica";
            Ciudad[144]= "Tegucigalpa (TGU) ,Honduras";
            Ciudad[145]= "San Pedro Sula (SAP) ,Honduras";
            Ciudad[146]= "Roatan (RTB) ,Honduras";
            Ciudad[147]= "Puerto Principe (PAP) ,Haití";
            Ciudad[148]= "Ciudad de Guatemala (GUA) ,Guatemala";
            Ciudad[149]= "Granada (GRX) ,Granada";
            Ciudad[150]= "San Salvador (SAL) ,El Salvador";
            Ciudad[151]= "San José (SJO) Costa Rica";
            Ciudad[152]= "Ciudad de Belice (TZA) ,Belice";
            Ciudad[153]= "Freeport (FPO) ,Bahamas";
            Ciudad[154]= "Nassau (NAS) ,Nicaragua";


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbOrigen.SelectedIndex!=-1 && cbDestino.SelectedIndex != -1)
            {
                F2.lbxVuelo.Items.Clear();

                int Origen = cbOrigen.SelectedIndex;
                int Destino = cbDestino.SelectedIndex;
                //Existe Conexion

                int[,] Conexion;
                Conexion = objVuelo.Conexion();
                if (Conexion[Origen, Destino] == 1)
                    F2.lbxVuelo.Items.Add("Existe Conexion");
                else
                    F2.lbxVuelo.Items.Add("NO Existe Conexion");
                //Vuelo Directo
                if (objVuelo.Vuelo_Directo(Origen, Destino))
                {
                    F2.lbxVuelo.Items.Add("Existe Vuelo Directo");
                    F2.lbxVuelo.Items.Add(Ciudad[Origen] + " - " + Ciudad[Destino]);
                }
                else
                    F2.lbxVuelo.Items.Add("No existe Vuelo Directo");
                //Vuelo a 1 escalas
                int[] Indice = new int[N];
                Indice = objVuelo.Una_Escala(Origen, Destino);
                int i = 0;
                F2.lbxVuelo.Items.Add("Conexion a una escala");
                while (Indice[i] != -1)
                {
                    F2.lbxVuelo.Items.Add(Ciudad[Origen] + "  -  " + Ciudad[Indice[i]] + "  -  " + Ciudad[Destino]);
                    i++;
                }

                //Vuelo a 2 escalas
                int[,] Indices = new int[N, 2];
                Indices = objVuelo.Dos_Escalas(Origen, Destino);
                i = 0;
                F2.lbxVuelo.Items.Add("Conexiona a dos escalas");
                while (Indices[i, 0] != -1)
                {
                    F2.lbxVuelo.Items.Add(Ciudad[Origen] + "  -  " + Ciudad[Indices[i, 0]] + "  -  " + Ciudad[Indices[i, 1]] + "  -  " + Ciudad[Destino]);
                    i++;
                }

                //Vuelo a 3 escalas
                int[,] Indices2 = new int[N, 3];
                Indices2 = objVuelo.Tres_Escalas(Origen, Destino);
                i = 0;
                F2.lbxVuelo.Items.Add("Conexiona a tres escalas");
                while (Indices[i, 0] != -1)
                {
                    F2.lbxVuelo.Items.Add(Ciudad[Origen] + "  -  " + Ciudad[Indices2[i, 0]] + "  -  " + Ciudad[Indices2[i, 2]] + "  -  " + Ciudad[Indices2[i, 1]] + "  -  " + Ciudad[Destino]);
                    i++;
                }
                if (Origen != Destino)
                    F2.ShowDialog();
            }
         
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Start();
            i = 1;
            //comboBox1.DataSource = Ciudad;
            //cbOrigen.DataSource = Ciudad;
            //cmbDestino.DataSource = indice_ciudad
            //AutoCompleteStringCollection mylist = new AutoCompleteStringCollection();
            //mylist.AddRange(indice_ciudad);
            //cmbOrigen.AutoCompleteCustomSource = mylist;
            // cmbDestino.AutoCompleteSource = AutoCompleteSource.CustomSource;
            /// cmbDestino.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            // cmbDestino.AutoCompleteCustomSource.AddRange(indice_ciudad);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int i;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 1)
            {
                Fondo.Image=Latam.Properties.Resources.fondolatam1;
                i = 2;
            }
            else if (i == 2)
            {
                Fondo.Image = Latam.Properties.Resources.fondolatam2;
                i = 3;
            }
            else if (i == 3)
            {
                Fondo.Image = Latam.Properties.Resources.fondolatam3;
                i = 4;
            }
            else if (i == 4)
            {
                Fondo.Image = Latam.Properties.Resources.fondolatam4;
                i = 1;
            }

        }

    }
}
