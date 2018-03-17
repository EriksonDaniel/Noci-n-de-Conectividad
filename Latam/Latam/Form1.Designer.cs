namespace Latam
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Fondo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkRed;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(611, 608);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 30);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // cbOrigen
            // 
            this.cbOrigen.AutoCompleteCustomSource.AddRange(new string[] {
            "Buenos Aires (BUE), Argentina",
            "Bariloche(BRC), Argentina",
            "Comodoro Rivadavia (CRD), Argentina",
            "Cordoba (COR), Argentina",
            "Mendoza (MDZ), Argentina",
            "Tucuman (TUC), Argentina",
            "Salta (SLA), Argentina",
            "Rio Gallegos (RGL), Argentina",
            "Rosario (ROS), Argentina",
            "Sao Paulo (SAO) ,Brasil",
            "Brasilia (BSB) ,Brasil",
            "Manaos (MAO) ,Brasil",
            "Fortaleza (FOR) ,Brasil",
            "Belo Horizonte (BHZ ),Brasil",
            "Belem (BEL) ,Brasil",
            "Curitiba (CWB) ,Brasil",
            "Rio de Janeiro (RIO) ,Brasil",
            "Porto Alegre (POA) ,Brasil",
            "Florlanopolis (FLN) ,Brasil",
            "Aracaju (AJU) ,Brasil",
            "Santiago de Chile(SCL) ,Chile",
            "Arica (ARI) ,Chile",
            "Temuco (ZCO) ,Chile",
            "La Serena (LSC) ,Chile",
            "Concepción (CCP) ,Chile",
            "Antofagasta (ANF) ,Chile",
            "Copiapó (CPO) ,Chile",
            "Iquique (IQQ) ,Chile",
            "Puerto Montt (PMC) ,Chile",
            "Isla de Pascua (IPC) ,Chile",
            "Santa Marta(SMR) ,Colombia",
            "Tumaco(TCO) ,Colombia",
            "POPAYAN(PPN) ,Colombia",
            "Bucaramanga(BGA) ,Colombia",
            "Montería(MTR) ,Colombia",
            "Bogotá(BOG) ,Colombia",
            "Barrancabermeja(EJA) ,Colombia",
            "Cali(CLO) ,Colombia",
            "Medellín(MDE) ,Colombia",
            "Barranquilla(BAQ) ,Colombia",
            "Valledupar(VUP) ,Colombia",
            "Leticia(LED) ,Colombia",
            "Isla San Andrés(ADZ) ,Colombia",
            "Cartagena de Indias(CTG) ,Colombia",
            "LOJA (LOH) ,Ecuador",
            "Cuenca (CUE) ,Ecuador",
            "Quito (UIO) ,Ecuador",
            "Guayaquil (GYE) ,Ecuador",
            "Baltra,Islas Galápagos(GPS) ,Ecuador",
            "Asuncion (ASU) ,Paraguay",
            "Ciudad del Este (AGT) ,Paraguay",
            "Jaén (JAE) ,Perú",
            "Iquitos (IQT) ,Perú",
            "Lima (LIM) ,Perú",
            "Chiclayoo (CHI) ,Perú",
            "Cusco (CUZ) ,Perú",
            "Piura (PIU) ,Perú",
            "Tumbes (TBP) ,Perú",
            "Arequipa (AQP) ,Perú",
            "Cajamarca (CJA) ,Perú",
            "Trujillo (TRU) ,Perú",
            "Tacna (TCQ) ,Perú",
            "Montevideo (MVD) ,Uruguay",
            "Punta del Este (PDP) ,Uruguay",
            "La Paz (LPB) ,Bolivia",
            "Cochabamba (CBB) ,Bolivia",
            "Santa Cruz (SRZ) ,Bolivia",
            "Toronto (YTO) (YYZ) , Canadá",
            "Montreal (YMQ) (YUL) ,Canadá",
            "Ottawa (YOW) ,Canadá",
            "Vancouver (YVR) , Canadá",
            "Calgary (YYC) , Canadá",
            "Victoria (YYJ) , Canadá",
            "Charlottetown (YYG) , Canadá",
            "Halifax (YHZ) , Canadá",
            "Ciudad de Mexico(MEX) ,México",
            "Monterrey(MTY) ,México",
            "Mérida(MID) ,México",
            "Cancún(CUN) ,México",
            "Morelia(MLM) ,México",
            "Oaxaca(OAX) ,México",
            "Tijuana(TIJ) ,México",
            "Puerto Vallarta(PVR) ,México",
            "Acapulco(ACA) ,México",
            "Guadalajara(GDL) ,México",
            "San José Cabo(SJD) ,México",
            "Veracruz(VER) ,México",
            "Leon(BJX) ,México",
            "TUXTLA GUTIERREZ (TGZ) ,México",
            "Aguascalientes(AGU) ,México",
            "Ciudad Obregón(CEN) ,México",
            "Chihuahua(CUU) ,México",
            "Mazatlán(MZT) ,México",
            "Nuevo Madero(NLD) ,México",
            "San Luis Potosí(SLP) ,México",
            "Ciudad Juárez(CJS) ,México",
            "PUERTO ESCONDIDO(PXM) ,México",
            "Tampa (TPA) ,Estados Unidos",
            "Denver (DEN) ,Estados Unidos",
            "Atlanta (ATL) ,Estados Unidos",
            "Chicago (CHI) MIDWAY (MDW) ,Estados Unidos",
            "Chicago (CHI) OHARE INTL (ORD) ,Estados Unidos",
            "Detroit (DTT) DETROIT METRO(DTW) ,Estados Unidos",
            "Houston (HOU) G.BUSH INTERCONT(IAH) ,Estados Unidos",
            "Memphis (MEM) ,Estados Unidos",
            "Orlando (ORL) (MCO) ,Estados Unidos",
            "Phoenix (PHX) ,Estados Unidos",
            "Seattle (SEA) ,Estados Unidos",
            "Columbus (CMH) ,Estados Unidos",
            "Anchorage (ANC) ,Estados Unidos",
            "Charlotte (CLT) ,Estados Unidos",
            "San Diego (SAN) ,Estados Unidos",
            "Louisville(SDF) ,Estados Unidos",
            "Nueva York (NYC) LA GUARDIA(LGA) ,Estados Unidos",
            "Nueva York (NYC) NEWARK INTL(EWR) ,Estados Unidos",
            "Nueva York (NYC) Jhon F Kennedy(JFK) ,Estados Unidos",
            "Kansas City (MKC) ,Estados Unidos",
            "Minneapolis(MSP) ,Estados Unidos",
            "Jacksonville(JAX) ,Estados Unidos",
            "Los Angeles (LAX) ,Estados Unidos",
            "Dallas (DFW) ,Estados Unidos",
            "San Francisco(SFO) ,Estados Unidos",
            "Las Vegas(LAS) ,Estados Unidos",
            "Miami(MIA) ,Estados Unidos",
            "Boston(BOS) ,Estados Unidos",
            "Philadelphia (PHL) ,Estados Unidos",
            "Fort Lauderdale (FLL) ,Estados Unidos",
            "Washington DC (WAS) R REAGAN NAT (DCA) ,Estados Unidos",
            "Washington DC (WAS) BALTIMORE (BWI) ,Estados Unidos",
            "Salt Lake City (SLC) ,Estados Unidos",
            "Hunulu Huawaii (HNL) ,Estados Unidos",
            "PortLand (PDX) ,Estados Unidos",
            "La Habana (HAV) ,Cuba",
            "Piarco(POS) ,Trinidad yTobago",
            "Castries (SLU) ,Santa Lucia",
            "San Cristobal (SKB) ,San Cristóbal y Nieves",
            "Santo Domingo (SDQ) ,República Dominicana",
            "Punta Cana (PUJ) República Dominicana",
            "Puerto Plata (POP) República Dominicana",
            "La Romana (LRM) República Dominicana",
            "Ciudad de Panamá (PTY) ,Panamá",
            "Managua (MGA) ,Nicaragua",
            "Kingston (KIN) ,Jamaica",
            "Montego Bay (MBJ) ,Jamaica",
            "Tegucigalpa (TGU) ,Honduras",
            "San Pedro Sula (SAP) ,Honduras",
            "Roatan (RTB) ,Honduras",
            "Puerto Principe (PAP) ,Haití",
            "Ciudad de Guatemala (GUA) ,Guatemala",
            "Granada (GRX) ,Granada",
            "San Salvador (SAL) ,El Salvador",
            "San José (SJO) Costa Rica",
            "Ciudad de Belice (TZA) ,Belice",
            "Freeport (FPO) ,Bahamas",
            "Nassau (NAS) ,Nicaragua"});
            this.cbOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOrigen.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrigen.ForeColor = System.Drawing.Color.Navy;
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Items.AddRange(new object[] {
            "Buenos Aires (BUE), Argentina",
            "Bariloche(BRC), Argentina",
            "Comodoro Rivadavia (CRD), Argentina",
            "Cordoba (COR), Argentina",
            "Mendoza (MDZ), Argentina",
            "Tucuman (TUC), Argentina",
            "Salta (SLA), Argentina",
            "Rio Gallegos (RGL), Argentina",
            "Rosario (ROS), Argentina",
            "Sao Paulo (SAO) ,Brasil",
            "Brasilia (BSB) ,Brasil",
            "Manaos (MAO) ,Brasil",
            "Fortaleza (FOR) ,Brasil",
            "Belo Horizonte (BHZ ),Brasil",
            "Belem (BEL) ,Brasil",
            "Curitiba (CWB) ,Brasil",
            "Rio de Janeiro (RIO) ,Brasil",
            "Porto Alegre (POA) ,Brasil",
            "Florlanopolis (FLN) ,Brasil",
            "Aracaju (AJU) ,Brasil",
            "Santiago de Chile(SCL) ,Chile",
            "Arica (ARI) ,Chile",
            "Temuco (ZCO) ,Chile",
            "La Serena (LSC) ,Chile",
            "Concepción (CCP) ,Chile",
            "Antofagasta (ANF) ,Chile",
            "Copiapó (CPO) ,Chile",
            "Iquique (IQQ) ,Chile",
            "Puerto Montt (PMC) ,Chile",
            "Isla de Pascua (IPC) ,Chile",
            "Santa Marta(SMR) ,Colombia",
            "Tumaco(TCO) ,Colombia",
            "POPAYAN(PPN) ,Colombia",
            "Bucaramanga(BGA) ,Colombia",
            "Montería(MTR) ,Colombia",
            "Bogotá(BOG) ,Colombia",
            "Barrancabermeja(EJA) ,Colombia",
            "Cali(CLO) ,Colombia",
            "Medellín(MDE) ,Colombia",
            "Barranquilla(BAQ) ,Colombia",
            "Valledupar(VUP) ,Colombia",
            "Leticia(LED) ,Colombia",
            "Isla San Andrés(ADZ) ,Colombia",
            "Cartagena de Indias(CTG) ,Colombia",
            "LOJA (LOH) ,Ecuador",
            "Cuenca (CUE) ,Ecuador",
            "Quito (UIO) ,Ecuador",
            "Guayaquil (GYE) ,Ecuador",
            "Baltra,Islas Galápagos(GPS) ,Ecuador",
            "Asuncion (ASU) ,Paraguay",
            "Ciudad del Este (AGT) ,Paraguay",
            "Jaén (JAE) ,Perú",
            "Iquitos (IQT) ,Perú",
            "Lima (LIM) ,Perú",
            "Chiclayoo (CHI) ,Perú",
            "Cusco (CUZ) ,Perú",
            "Piura (PIU) ,Perú",
            "Tumbes (TBP) ,Perú",
            "Arequipa (AQP) ,Perú",
            "Cajamarca (CJA) ,Perú",
            "Trujillo (TRU) ,Perú",
            "Tacna (TCQ) ,Perú",
            "Montevideo (MVD) ,Uruguay",
            "Punta del Este (PDP) ,Uruguay",
            "La Paz (LPB) ,Bolivia",
            "Cochabamba (CBB) ,Bolivia",
            "Santa Cruz (SRZ) ,Bolivia",
            "Toronto (YTO) (YYZ) , Canadá",
            "Montreal (YMQ) (YUL) ,Canadá",
            "Ottawa (YOW) ,Canadá",
            "Vancouver (YVR) , Canadá",
            "Calgary (YYC) , Canadá",
            "Victoria (YYJ) , Canadá",
            "Charlottetown (YYG) , Canadá",
            "Halifax (YHZ) , Canadá",
            "Ciudad de Mexico(MEX) ,México",
            "Monterrey(MTY) ,México",
            "Mérida(MID) ,México",
            "Cancún(CUN) ,México",
            "Morelia(MLM) ,México",
            "Oaxaca(OAX) ,México",
            "Tijuana(TIJ) ,México",
            "Puerto Vallarta(PVR) ,México",
            "Acapulco(ACA) ,México",
            "Guadalajara(GDL) ,México",
            "San José Cabo(SJD) ,México",
            "Veracruz(VER) ,México",
            "Leon(BJX) ,México",
            "TUXTLA GUTIERREZ (TGZ) ,México",
            "Aguascalientes(AGU) ,México",
            "Ciudad Obregón(CEN) ,México",
            "Chihuahua(CUU) ,México",
            "Mazatlán(MZT) ,México",
            "Nuevo Madero(NLD) ,México",
            "San Luis Potosí(SLP) ,México",
            "Ciudad Juárez(CJS) ,México",
            "PUERTO ESCONDIDO(PXM) ,México",
            "Tampa (TPA) ,Estados Unidos",
            "Denver (DEN) ,Estados Unidos",
            "Atlanta (ATL) ,Estados Unidos",
            "Chicago (CHI) MIDWAY (MDW) ,Estados Unidos",
            "Chicago (CHI) OHARE INTL (ORD) ,Estados Unidos",
            "Detroit (DTT) DETROIT METRO(DTW) ,Estados Unidos",
            "Houston (HOU) G.BUSH INTERCONT(IAH) ,Estados Unidos",
            "Memphis (MEM) ,Estados Unidos",
            "Orlando (ORL) (MCO) ,Estados Unidos",
            "Phoenix (PHX) ,Estados Unidos",
            "Seattle (SEA) ,Estados Unidos",
            "Columbus (CMH) ,Estados Unidos",
            "Anchorage (ANC) ,Estados Unidos",
            "Charlotte (CLT) ,Estados Unidos",
            "San Diego (SAN) ,Estados Unidos",
            "Louisville(SDF) ,Estados Unidos",
            "Nueva York (NYC) LA GUARDIA(LGA) ,Estados Unidos",
            "Nueva York (NYC) NEWARK INTL(EWR) ,Estados Unidos",
            "Nueva York (NYC) Jhon F Kennedy(JFK) ,Estados Unidos",
            "Kansas City (MKC) ,Estados Unidos",
            "Minneapolis(MSP) ,Estados Unidos",
            "Jacksonville(JAX) ,Estados Unidos",
            "Los Angeles (LAX) ,Estados Unidos",
            "Dallas (DFW) ,Estados Unidos",
            "San Francisco(SFO) ,Estados Unidos",
            "Las Vegas(LAS) ,Estados Unidos",
            "Miami(MIA) ,Estados Unidos",
            "Boston(BOS) ,Estados Unidos",
            "Philadelphia (PHL) ,Estados Unidos",
            "Fort Lauderdale (FLL) ,Estados Unidos",
            "Washington DC (WAS) R REAGAN NAT (DCA) ,Estados Unidos",
            "Washington DC (WAS) BALTIMORE (BWI) ,Estados Unidos",
            "Salt Lake City (SLC) ,Estados Unidos",
            "Hunulu Huawaii (HNL) ,Estados Unidos",
            "PortLand (PDX) ,Estados Unidos",
            "La Habana (HAV) ,Cuba",
            "Piarco(POS) ,Trinidad yTobago",
            "Castries (SLU) ,Santa Lucia",
            "San Cristobal (SKB) ,San Cristóbal y Nieves",
            "Santo Domingo (SDQ) ,República Dominicana",
            "Punta Cana (PUJ) República Dominicana",
            "Puerto Plata (POP) República Dominicana",
            "La Romana (LRM) República Dominicana",
            "Ciudad de Panamá (PTY) ,Panamá",
            "Managua (MGA) ,Nicaragua",
            "Kingston (KIN) ,Jamaica",
            "Montego Bay (MBJ) ,Jamaica",
            "Tegucigalpa (TGU) ,Honduras",
            "San Pedro Sula (SAP) ,Honduras",
            "Roatan (RTB) ,Honduras",
            "Puerto Principe (PAP) ,Haití",
            "Ciudad de Guatemala (GUA) ,Guatemala",
            "Granada (GRX) ,Granada",
            "San Salvador (SAL) ,El Salvador",
            "San José (SJO) Costa Rica",
            "Ciudad de Belice (TZA) ,Belice",
            "Freeport (FPO) ,Bahamas",
            "Nassau (NAS) ,Nicaragua"});
            this.cbOrigen.Location = new System.Drawing.Point(10, 43);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(280, 30);
            this.cbOrigen.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Location = new System.Drawing.Point(11, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 230);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cbDestino);
            this.panel4.Location = new System.Drawing.Point(371, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 80);
            this.panel4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Destino";
            // 
            // cbDestino
            // 
            this.cbDestino.AutoCompleteCustomSource.AddRange(new string[] {
            "Buenos Aires (BUE), Argentina",
            "Bariloche(BRC), Argentina",
            "Comodoro Rivadavia (CRD), Argentina",
            "Cordoba (COR), Argentina",
            "Mendoza (MDZ), Argentina",
            "Tucuman (TUC), Argentina",
            "Salta (SLA), Argentina",
            "Rio Gallegos (RGL), Argentina",
            "Rosario (ROS), Argentina",
            "Sao Paulo (SAO) ,Brasil",
            "Brasilia (BSB) ,Brasil",
            "Manaos (MAO) ,Brasil",
            "Fortaleza (FOR) ,Brasil",
            "Belo Horizonte (BHZ ),Brasil",
            "Belem (BEL) ,Brasil",
            "Curitiba (CWB) ,Brasil",
            "Rio de Janeiro (RIO) ,Brasil",
            "Porto Alegre (POA) ,Brasil",
            "Florlanopolis (FLN) ,Brasil",
            "Aracaju (AJU) ,Brasil",
            "Santiago de Chile(SCL) ,Chile",
            "Arica (ARI) ,Chile",
            "Temuco (ZCO) ,Chile",
            "La Serena (LSC) ,Chile",
            "Concepción (CCP) ,Chile",
            "Antofagasta (ANF) ,Chile",
            "Copiapó (CPO) ,Chile",
            "Iquique (IQQ) ,Chile",
            "Puerto Montt (PMC) ,Chile",
            "Isla de Pascua (IPC) ,Chile",
            "Santa Marta(SMR) ,Colombia",
            "Tumaco(TCO) ,Colombia",
            "POPAYAN(PPN) ,Colombia",
            "Bucaramanga(BGA) ,Colombia",
            "Montería(MTR) ,Colombia",
            "Bogotá(BOG) ,Colombia",
            "Barrancabermeja(EJA) ,Colombia",
            "Cali(CLO) ,Colombia",
            "Medellín(MDE) ,Colombia",
            "Barranquilla(BAQ) ,Colombia",
            "Valledupar(VUP) ,Colombia",
            "Leticia(LED) ,Colombia",
            "Isla San Andrés(ADZ) ,Colombia",
            "Cartagena de Indias(CTG) ,Colombia",
            "LOJA (LOH) ,Ecuador",
            "Cuenca (CUE) ,Ecuador",
            "Quito (UIO) ,Ecuador",
            "Guayaquil (GYE) ,Ecuador",
            "Baltra,Islas Galápagos(GPS) ,Ecuador",
            "Asuncion (ASU) ,Paraguay",
            "Ciudad del Este (AGT) ,Paraguay",
            "Jaén (JAE) ,Perú",
            "Iquitos (IQT) ,Perú",
            "Lima (LIM) ,Perú",
            "Chiclayoo (CHI) ,Perú",
            "Cusco (CUZ) ,Perú",
            "Piura (PIU) ,Perú",
            "Tumbes (TBP) ,Perú",
            "Arequipa (AQP) ,Perú",
            "Cajamarca (CJA) ,Perú",
            "Trujillo (TRU) ,Perú",
            "Tacna (TCQ) ,Perú",
            "Montevideo (MVD) ,Uruguay",
            "Punta del Este (PDP) ,Uruguay",
            "La Paz (LPB) ,Bolivia",
            "Cochabamba (CBB) ,Bolivia",
            "Santa Cruz (SRZ) ,Bolivia",
            "Toronto (YTO) (YYZ) , Canadá",
            "Montreal (YMQ) (YUL) ,Canadá",
            "Ottawa (YOW) ,Canadá",
            "Vancouver (YVR) , Canadá",
            "Calgary (YYC) , Canadá",
            "Victoria (YYJ) , Canadá",
            "Charlottetown (YYG) , Canadá",
            "Halifax (YHZ) , Canadá",
            "Ciudad de Mexico(MEX) ,México",
            "Monterrey(MTY) ,México",
            "Mérida(MID) ,México",
            "Cancún(CUN) ,México",
            "Morelia(MLM) ,México",
            "Oaxaca(OAX) ,México",
            "Tijuana(TIJ) ,México",
            "Puerto Vallarta(PVR) ,México",
            "Acapulco(ACA) ,México",
            "Guadalajara(GDL) ,México",
            "San José Cabo(SJD) ,México",
            "Veracruz(VER) ,México",
            "Leon(BJX) ,México",
            "TUXTLA GUTIERREZ (TGZ) ,México",
            "Aguascalientes(AGU) ,México",
            "Ciudad Obregón(CEN) ,México",
            "Chihuahua(CUU) ,México",
            "Mazatlán(MZT) ,México",
            "Nuevo Madero(NLD) ,México",
            "San Luis Potosí(SLP) ,México",
            "Ciudad Juárez(CJS) ,México",
            "PUERTO ESCONDIDO(PXM) ,México",
            "Tampa (TPA) ,Estados Unidos",
            "Denver (DEN) ,Estados Unidos",
            "Atlanta (ATL) ,Estados Unidos",
            "Chicago (CHI) MIDWAY (MDW) ,Estados Unidos",
            "Chicago (CHI) OHARE INTL (ORD) ,Estados Unidos",
            "Detroit (DTT) DETROIT METRO(DTW) ,Estados Unidos",
            "Houston (HOU) G.BUSH INTERCONT(IAH) ,Estados Unidos",
            "Memphis (MEM) ,Estados Unidos",
            "Orlando (ORL) (MCO) ,Estados Unidos",
            "Phoenix (PHX) ,Estados Unidos",
            "Seattle (SEA) ,Estados Unidos",
            "Columbus (CMH) ,Estados Unidos",
            "Anchorage (ANC) ,Estados Unidos",
            "Charlotte (CLT) ,Estados Unidos",
            "San Diego (SAN) ,Estados Unidos",
            "Louisville(SDF) ,Estados Unidos",
            "Nueva York (NYC) LA GUARDIA(LGA) ,Estados Unidos",
            "Nueva York (NYC) NEWARK INTL(EWR) ,Estados Unidos",
            "Nueva York (NYC) Jhon F Kennedy(JFK) ,Estados Unidos",
            "Kansas City (MKC) ,Estados Unidos",
            "Minneapolis(MSP) ,Estados Unidos",
            "Jacksonville(JAX) ,Estados Unidos",
            "Los Angeles (LAX) ,Estados Unidos",
            "Dallas (DFW) ,Estados Unidos",
            "San Francisco(SFO) ,Estados Unidos",
            "Las Vegas(LAS) ,Estados Unidos",
            "Miami(MIA) ,Estados Unidos",
            "Boston(BOS) ,Estados Unidos",
            "Philadelphia (PHL) ,Estados Unidos",
            "Fort Lauderdale (FLL) ,Estados Unidos",
            "Washington DC (WAS) R REAGAN NAT (DCA) ,Estados Unidos",
            "Washington DC (WAS) BALTIMORE (BWI) ,Estados Unidos",
            "Salt Lake City (SLC) ,Estados Unidos",
            "Hunulu Huawaii (HNL) ,Estados Unidos",
            "PortLand (PDX) ,Estados Unidos",
            "La Habana (HAV) ,Cuba",
            "Piarco(POS) ,Trinidad yTobago",
            "Castries (SLU) ,Santa Lucia",
            "San Cristobal (SKB) ,San Cristóbal y Nieves",
            "Santo Domingo (SDQ) ,República Dominicana",
            "Punta Cana (PUJ) República Dominicana",
            "Puerto Plata (POP) República Dominicana",
            "La Romana (LRM) República Dominicana",
            "Ciudad de Panamá (PTY) ,Panamá",
            "Managua (MGA) ,Nicaragua",
            "Kingston (KIN) ,Jamaica",
            "Montego Bay (MBJ) ,Jamaica",
            "Tegucigalpa (TGU) ,Honduras",
            "San Pedro Sula (SAP) ,Honduras",
            "Roatan (RTB) ,Honduras",
            "Puerto Principe (PAP) ,Haití",
            "Ciudad de Guatemala (GUA) ,Guatemala",
            "Granada (GRX) ,Granada",
            "San Salvador (SAL) ,El Salvador",
            "San José (SJO) Costa Rica",
            "Ciudad de Belice (TZA) ,Belice",
            "Freeport (FPO) ,Bahamas",
            "Nassau (NAS) ,Nicaragua"});
            this.cbDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDestino.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDestino.ForeColor = System.Drawing.Color.Navy;
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Items.AddRange(new object[] {
            "Buenos Aires (BUE), Argentina",
            "Bariloche(BRC), Argentina",
            "Comodoro Rivadavia (CRD), Argentina",
            "Cordoba (COR), Argentina",
            "Mendoza (MDZ), Argentina",
            "Tucuman (TUC), Argentina",
            "Salta (SLA), Argentina",
            "Rio Gallegos (RGL), Argentina",
            "Rosario (ROS), Argentina",
            "Sao Paulo (SAO) ,Brasil",
            "Brasilia (BSB) ,Brasil",
            "Manaos (MAO) ,Brasil",
            "Fortaleza (FOR) ,Brasil",
            "Belo Horizonte (BHZ ),Brasil",
            "Belem (BEL) ,Brasil",
            "Curitiba (CWB) ,Brasil",
            "Rio de Janeiro (RIO) ,Brasil",
            "Porto Alegre (POA) ,Brasil",
            "Florlanopolis (FLN) ,Brasil",
            "Aracaju (AJU) ,Brasil",
            "Santiago de Chile(SCL) ,Chile",
            "Arica (ARI) ,Chile",
            "Temuco (ZCO) ,Chile",
            "La Serena (LSC) ,Chile",
            "Concepción (CCP) ,Chile",
            "Antofagasta (ANF) ,Chile",
            "Copiapó (CPO) ,Chile",
            "Iquique (IQQ) ,Chile",
            "Puerto Montt (PMC) ,Chile",
            "Isla de Pascua (IPC) ,Chile",
            "Santa Marta(SMR) ,Colombia",
            "Tumaco(TCO) ,Colombia",
            "POPAYAN(PPN) ,Colombia",
            "Bucaramanga(BGA) ,Colombia",
            "Montería(MTR) ,Colombia",
            "Bogotá(BOG) ,Colombia",
            "Barrancabermeja(EJA) ,Colombia",
            "Cali(CLO) ,Colombia",
            "Medellín(MDE) ,Colombia",
            "Barranquilla(BAQ) ,Colombia",
            "Valledupar(VUP) ,Colombia",
            "Leticia(LED) ,Colombia",
            "Isla San Andrés(ADZ) ,Colombia",
            "Cartagena de Indias(CTG) ,Colombia",
            "LOJA (LOH) ,Ecuador",
            "Cuenca (CUE) ,Ecuador",
            "Quito (UIO) ,Ecuador",
            "Guayaquil (GYE) ,Ecuador",
            "Baltra,Islas Galápagos(GPS) ,Ecuador",
            "Asuncion (ASU) ,Paraguay",
            "Ciudad del Este (AGT) ,Paraguay",
            "Jaén (JAE) ,Perú",
            "Iquitos (IQT) ,Perú",
            "Lima (LIM) ,Perú",
            "Chiclayoo (CHI) ,Perú",
            "Cusco (CUZ) ,Perú",
            "Piura (PIU) ,Perú",
            "Tumbes (TBP) ,Perú",
            "Arequipa (AQP) ,Perú",
            "Cajamarca (CJA) ,Perú",
            "Trujillo (TRU) ,Perú",
            "Tacna (TCQ) ,Perú",
            "Montevideo (MVD) ,Uruguay",
            "Punta del Este (PDP) ,Uruguay",
            "La Paz (LPB) ,Bolivia",
            "Cochabamba (CBB) ,Bolivia",
            "Santa Cruz (SRZ) ,Bolivia",
            "Toronto (YTO) (YYZ) , Canadá",
            "Montreal (YMQ) (YUL) ,Canadá",
            "Ottawa (YOW) ,Canadá",
            "Vancouver (YVR) , Canadá",
            "Calgary (YYC) , Canadá",
            "Victoria (YYJ) , Canadá",
            "Charlottetown (YYG) , Canadá",
            "Halifax (YHZ) , Canadá",
            "Ciudad de Mexico(MEX) ,México",
            "Monterrey(MTY) ,México",
            "Mérida(MID) ,México",
            "Cancún(CUN) ,México",
            "Morelia(MLM) ,México",
            "Oaxaca(OAX) ,México",
            "Tijuana(TIJ) ,México",
            "Puerto Vallarta(PVR) ,México",
            "Acapulco(ACA) ,México",
            "Guadalajara(GDL) ,México",
            "San José Cabo(SJD) ,México",
            "Veracruz(VER) ,México",
            "Leon(BJX) ,México",
            "TUXTLA GUTIERREZ (TGZ) ,México",
            "Aguascalientes(AGU) ,México",
            "Ciudad Obregón(CEN) ,México",
            "Chihuahua(CUU) ,México",
            "Mazatlán(MZT) ,México",
            "Nuevo Madero(NLD) ,México",
            "San Luis Potosí(SLP) ,México",
            "Ciudad Juárez(CJS) ,México",
            "PUERTO ESCONDIDO(PXM) ,México",
            "Tampa (TPA) ,Estados Unidos",
            "Denver (DEN) ,Estados Unidos",
            "Atlanta (ATL) ,Estados Unidos",
            "Chicago (CHI) MIDWAY (MDW) ,Estados Unidos",
            "Chicago (CHI) OHARE INTL (ORD) ,Estados Unidos",
            "Detroit (DTT) DETROIT METRO(DTW) ,Estados Unidos",
            "Houston (HOU) G.BUSH INTERCONT(IAH) ,Estados Unidos",
            "Memphis (MEM) ,Estados Unidos",
            "Orlando (ORL) (MCO) ,Estados Unidos",
            "Phoenix (PHX) ,Estados Unidos",
            "Seattle (SEA) ,Estados Unidos",
            "Columbus (CMH) ,Estados Unidos",
            "Anchorage (ANC) ,Estados Unidos",
            "Charlotte (CLT) ,Estados Unidos",
            "San Diego (SAN) ,Estados Unidos",
            "Louisville(SDF) ,Estados Unidos",
            "Nueva York (NYC) LA GUARDIA(LGA) ,Estados Unidos",
            "Nueva York (NYC) NEWARK INTL(EWR) ,Estados Unidos",
            "Nueva York (NYC) Jhon F Kennedy(JFK) ,Estados Unidos",
            "Kansas City (MKC) ,Estados Unidos",
            "Minneapolis(MSP) ,Estados Unidos",
            "Jacksonville(JAX) ,Estados Unidos",
            "Los Angeles (LAX) ,Estados Unidos",
            "Dallas (DFW) ,Estados Unidos",
            "San Francisco(SFO) ,Estados Unidos",
            "Las Vegas(LAS) ,Estados Unidos",
            "Miami(MIA) ,Estados Unidos",
            "Boston(BOS) ,Estados Unidos",
            "Philadelphia (PHL) ,Estados Unidos",
            "Fort Lauderdale (FLL) ,Estados Unidos",
            "Washington DC (WAS) R REAGAN NAT (DCA) ,Estados Unidos",
            "Washington DC (WAS) BALTIMORE (BWI) ,Estados Unidos",
            "Salt Lake City (SLC) ,Estados Unidos",
            "Hunulu Huawaii (HNL) ,Estados Unidos",
            "PortLand (PDX) ,Estados Unidos",
            "La Habana (HAV) ,Cuba",
            "Piarco(POS) ,Trinidad yTobago",
            "Castries (SLU) ,Santa Lucia",
            "San Cristobal (SKB) ,San Cristóbal y Nieves",
            "Santo Domingo (SDQ) ,República Dominicana",
            "Punta Cana (PUJ) República Dominicana",
            "Puerto Plata (POP) República Dominicana",
            "La Romana (LRM) República Dominicana",
            "Ciudad de Panamá (PTY) ,Panamá",
            "Managua (MGA) ,Nicaragua",
            "Kingston (KIN) ,Jamaica",
            "Montego Bay (MBJ) ,Jamaica",
            "Tegucigalpa (TGU) ,Honduras",
            "San Pedro Sula (SAP) ,Honduras",
            "Roatan (RTB) ,Honduras",
            "Puerto Principe (PAP) ,Haití",
            "Ciudad de Guatemala (GUA) ,Guatemala",
            "Granada (GRX) ,Granada",
            "San Salvador (SAL) ,El Salvador",
            "San José (SJO) Costa Rica",
            "Ciudad de Belice (TZA) ,Belice",
            "Freeport (FPO) ,Bahamas",
            "Nassau (NAS) ,Nicaragua"});
            this.cbDestino.Location = new System.Drawing.Point(10, 43);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(280, 30);
            this.cbDestino.TabIndex = 2;
            this.cbDestino.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reserva tu vuelo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbOrigen);
            this.panel3.Location = new System.Drawing.Point(11, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 80);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Origen";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Teal;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(180, 166);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(338, 50);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Busca tu vuelo";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 100);
            this.panel2.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Latam.Properties.Resources.flecha;
            this.pictureBox2.Location = new System.Drawing.Point(320, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 33);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Latam.Properties.Resources.latanlogo;
            this.pictureBox3.Location = new System.Drawing.Point(23, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 61);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Fondo
            // 
            this.Fondo.Image = global::Latam.Properties.Resources.fondolatam1;
            this.Fondo.Location = new System.Drawing.Point(0, 95);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(700, 280);
            this.Fondo.TabIndex = 5;
            this.Fondo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Fondo);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.PictureBox Fondo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
    }
}

