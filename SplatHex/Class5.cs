using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class5 : Form {
    public static object CDU5;
    private readonly Dictionary<uint, uint[]> NDUs = new Dictionary<uint, uint[]>();
    private readonly Dictionary<uint, uint[]> dDUZ = new Dictionary<uint, uint[]>();
    private readonly Dictionary<uint, uint[]> EDUa = new Dictionary<uint, uint[]>();
    public bool xDUj;
    private Container DDUz;
    private Label fDTE;
    private Label QDTD;
    private GroupBox YDTX;
    private RadioButton CDTp;
    private TextBox bDTS;
    private RadioButton CDTh;
    private RadioButton rDTl;
    private RadioButton IDTG;
    private Label pDTb;
    private Button GDTv;
    private Button NDTo;
    private Button KDTt;
    private Button YDTV;
    private GroupBox RDTO;
    private Label hDTe;
    private TextBox wDT8;
    private Label IDTn;
    private Button EDTQ;
    private Label lDTF;
    private Button cDTL;
    private Label HDTJ;
    private TextBox uDT7;
    private TextBox fDTP;
    private GroupBox yDTi;
    private Button VDTm;
    private Button MDT0;
    private ListBox nDTI;
    private TextBox wDTR;
    private Button sDTC;
    private Button QDTK;
    private MenuStrip cDTU;
    private Button LDTT;
    private TextBox QDT1;
    private Button KDTW;
    private GroupBox qDTw;
    private StatusStrip YDTN;
    private ToolStripStatusLabel SDTY;
    private TabPage jDTB;
    private TableLayoutPanel MDTA;
    private Button iDTf;
    private Button KDT6;
    private Button rDTx;
    private TabControl wDT9;
    private TabPage QDTc;
    private CheckedListBox rDTy;
    private TabPage NDTr;
    private CheckedListBox EDTq;
    private TabPage BDTk;
    private GroupBox YDTM;
    private Button yDTu;
    private Button vDTg;
    private Button FDT2;
    private Button XDT3;
    private GroupBox xDTd;
    private Button ADTH;
    private Button dDT4;
    private Button cDT5;
    private Button jDTs;
    private Button JDTZ;
    private Button DDTa;
    private Button BDTj;
    private Button sDTz;
    private GroupBox lD1E;
    private Button fD1D;
    private Button DD1X;
    private Button YD1p;
    private Button uD1S;
    private Button oD1h;
    private Button XD1l;
    private Button HD1G;
    private Button nD1b;
    private Button lD1v;
    private Button ND1o;
    private Button MD1t;
    private Button TD1V;
    private Button YD1O;
    private Button dD1e;
    private TabPage oD18;
    private TabControl iD1n;
    public TabPage kD1Q;
    private Label MD1F;
    private NumericUpDown oD1L;
    private NumericUpDown vD1J;
    private GroupBox hD17;
    private Button pD1P;
    private CheckBox SD1i;
    private CheckBox SD1m;
    private Label yD10;
    private ComboBox uD1I;
    private Button tD1R;
    private Label OD1C;
    private ComboBox iD1K;
    private Button FD1U;
    private Label nD1T;
    private TabPage hD11;
    private TabControl oD1W;
    private TabPage hD1w;
    private ListView LD1N;
    private TabPage kD1Y;
    private ListView ND1B;
    private TabPage JD1A;
    private ListView bD1f;
    private TabPage aD16;
    private ListView XD1x;
    private TabPage tD19;
    private ListView kD1c;
    private TabPage TD1y;
    private ListView cD1r;
    private TabPage HD1q;
    private ListView BD1k;
    private TabPage eD1M;
    private ListView lD1u;
    private TabPage xD1g;
    private ListView MD12;
    private TabPage ED13;
    private ListView zD1d;
    private TabPage LD1H;
    private ListView gD14;
    private TabPage aD15;
    private ListView ID1s;
    private TabPage YD1Z;
    private ListView OD1a;
    private TabPage BD1j;
    private ListView hD1z;
    private TabPage tDWE;
    private ListView qDWD;
    private TabPage aDWX;
    private ListView iDWp;
    private TabPage mDWS;
    private TabControl aDWh;
    private TabPage iDWl;
    private TabPage FDWG;
    private TabPage EDWb;
    private GroupBox iDWv;
    private CheckBox ODWo;
    private ComboBox bDWt;
    private Label hDWV;
    private GroupBox DDWO;
    private Button vDWe;
    private Button CDW8;
    private ListBox kDWn;
    private Button VDWQ;
    private Button HDWF;
    private Button FDWL;
    private GroupBox aDWJ;
    private CheckBox JDW7;
    private Label TDWP;
    private ListView zDWi;
    private ColumnHeader PDWm;
    private ColumnHeader CDW0;
    private ColumnHeader yDWI;
    private Button oDWR;
    private GroupBox DDWC;
    private CheckBox VDWK;
    private NumericUpDown NDWU;
    private ComboBox JDWT;
    private Label dDW1;
    private Label MDWW;
    private ComboBox uDWw;
    private Label UDWN;
    private ComboBox lDWY;
    private Label QDWB;
    private ComboBox tDWA;
    private Label eDWf;
    private Label oDW6;
    private ComboBox sDWx;
    private GroupBox GDW9;
    private Button nDWc;
    private Button UDWy;
    private Button sDWr;
    private GroupBox KDWq;
    private Button LDWk;
    private Button vDWM;
    private Button BDWu;
    private Button zDWg;
    private GroupBox JDW2;
    private Button KDW3;
    private Button QDWd;
    private GroupBox rDWH;
    private CheckBox vDW4;
    private ComboBox WDW5;
    private ComboBox rDWs;
    private ComboBox yDWZ;
    private Label tDWa;
    private Label jDWj;
    private Label wDWz;
    private GroupBox nDwE;
    private NumericUpDown UDwD;
    private CheckBox GDwX;
    private ComboBox UDwp;
    private Label XDwS;
    private Label VDwh;
    private NumericUpDown sDwl;
    private Label tDwG;
    private NumericUpDown EDwb;
    private Label VDwv;
    private NumericUpDown mDwo;
    private TabControl GDwt;
    private GroupBox lDwV;
    private Button ADwO;
    private Button bDwe;
    private Button VDw8;
    private Button UDwn;
    private Button KDwQ;
    private Button ADwF;
    private Button RDwL;
    private Button zDwJ;
    private Button YDw7;
    private GroupBox kDwP;
    private Button nDwi;
    private Button bDwm;
    private Button MDw0;
    private Button rDwI;
    private Button rDwR;
    private Button RDwC;
    private Button FDwK;
    private Button XDwU;
    private Button XDwT;
    private TabPage mDw1;
    private Button wDwW;
    private TableLayoutPanel LDww;
    private Label dDwN;
    private Label iDwY;
    private Label bDwB;
    private Label RDwA;
    private Label hDwf;
    private Label gDw6;
    private CheckBox pDwx;
    private NumericUpDown UDw9;
    private Button mDwc;
    private FlowLayoutPanel UDwy;
    private CheckBox JDwr;
    private Button bDwq;
    private TabControl rDwk;
    private TabPage TDwM;
    private TabPage oDwu;
    private ColumnHeader nDwg;
    private ColumnHeader pDw2;
    private ColumnHeader nDw3;
    private ColumnHeader NDwd;
    private ColumnHeader QDwH;
    private GroupBox vDw4;
    private Button fDw5;
    private Button WDws;
    private Button CDwZ;
    private Button LDwa;
    private TabPage eDwj;
    private TabPage qDwz;
    private Button LDNE;
    private Button qDND;
    private Button xDNX;
    private TabPage NDNp;
    private TableLayoutPanel kDNS;
    private Label rDNh;
    private Label yDNl;
    private Label LDNG;
    private Label KDNb;
    private Label tDNv;
    private Label rDNo;
    private Label MDNt;
    private Label aDNV;
    private Label IDNO;
    private Label iDNe;
    private Label SDN8;
    private Button oDNn;
    private Button UDNQ;
    private Button DDNF;
    private Button LDNL;
    private Button eDNJ;
    private Button rDN7;
    private Button xDNP;
    private TabControl QDNi;
    private TabPage PDNm;
    private TabPage jDN0;
    private TabPage yDNI;
    private FlowLayoutPanel ODNR;
    private FlowLayoutPanel iDNC;
    private FlowLayoutPanel IDNK;
    private CheckBox EDNU;
    private NumericUpDown PDNT;
    private NumericUpDown dDN1;
    private NumericUpDown gDNW;
    private GroupBox ADNw;
    private Button cDNN;
    private Button iDNY;
    private Button nDNB;
    private Button zDNA;
    private Button kDNf;
    private GroupBox FDN6;
    private Button ADNx;
    private Button BDN9;
    private Button ADNc;
    private Button uDNy;
    private Button hDNr;
    private GroupBox aDNq;
    private Button rDNk;
    private Button uDNM;
    private Button IDNu;
    private Button WDNg;
    private Button SDN2;
    private Button iDN3;
    private GroupBox hDNd;
    private Button CDNH;
    private GroupBox CDN4;
    private PictureBox IDN5;
    private Button ADNs;
    private Button aDNZ;
    private Button TDNa;
    private Button TDNj;
    private Button ADNz;
    private Button cDYE;
    private GroupBox FDYD;
    private Button hDYX;
    private Button iDYp;
    private Button jDYS;
    private Button UDYh;
    private PictureBox qDYl;
    private Button JDYG;
    private Button WDYb;
    private Button IDYv;
    private Button lDYo;
    private Button qDYt;
    private GroupBox EDYV;
    private Button lDYO;
    private PictureBox SDYe;
    private Button LDY8;
    private Button ADYn;
    private Button NDYQ;
    private Button nDYF;
    private Button gDYL;
    private Button ADYJ;
    private GroupBox QDY7;
    private Button WDYP;
    private PictureBox HDYi;
    private Button uDYm;
    private GroupBox gDY0;
    private Button MDYI;
    private Button WDYR;
    private Button fDYC;
    private PictureBox kDYK;
    private Button cDYU;
    private GroupBox qDYT;
    private PictureBox GDY1;
    private Button CDYW;
    private Button DDYw;
    private Button IDYN;
    private Button UDYY;
    private Button PDYB;
    private Button bDYA;
    private Button hDYf;
    private Button rDY6;
    private Button vDYx;
    private Button RDY9;
    private Button uDYc;
    private Button oDYy;
    private Button BDYr;
    private Button LDYq;
    private Button hDYk;
    private Button bDYM;
    private Button bDYu;
    private Button SDYg;
    private Button LDY2;
    private GroupBox dDY3;
    private Button kDYd;
    private Button ADYH;
    private PictureBox xDY4;
    private GroupBox qDY5;
    private Button qDYs;
    private PictureBox LDYZ;
    private GroupBox TDYa;
    private Button cDYj;
    private Button NDYz;
    private Button RDBE;
    private GroupBox IDBD;
    private Button oDBX;
    private Button gDBp;
    private Button yDBS;
    private GroupBox LDBh;
    private Button mDBl;
    private Button JDBG;
    private Button bDBb;
    private Button uDBv;
    private Button PDBo;
    private GroupBox LDBt;
    private Button HDBV;
    private GroupBox wDBO;
    private Button WDBe;
    private Button TDB8;
    private Button iDBn;
    private Button rDBQ;
    private Button RDBF;
    private Button xDBL;
    private Button hDBJ;
    private Button CDB7;
    private Button WDBP;
    private Button yDBi;
    private Button gDBm;
    private Button gDB0;
    private Button EDBI;
    private GroupBox oDBR;
    private GroupBox IDBC;
    private Button cDBK;
    private Button jDBU;
    private Button IDBT;
    private Button KDB1;
    private Button EDBW;
    private Button TDBw;
    private Button zDBN;
    private GroupBox tDBY;
    private Button NDBB;
    private Button PDBA;
    private Button iDBf;
    private Button CDB6;
    private Button VDBx;
    private Button lDB9;
    private Button JDBc;
    private Button PDBy;
    private Button TDBr;
    private Button iDBq;
    private GroupBox vDBk;
    private GroupBox xDBM;
    private Button uDBu;
    private TabPage TDBg;
    private TabControl sDB2;
    private TabPage bDB3;
    private ListView kDBd;
    private TabPage aDBH;
    private ListView dDB4;
    private TabPage hDB5;
    private ListView VDBs;
    private TabPage tDBZ;
    private ListView UDBa;
    private TabPage BDBj;
    private ListView xDBz;
    private TabPage vDAE;
    private ListView yDAD;
    private TabPage gDAX;
    private ListView GDAp;
    private TabPage mDAS;
    private ListView mDAh;
    private TabPage JDAl;
    private ListView pDAG;
    private TabPage pDAb;
    private ListView MDAv;
    private TabPage HDAo;
    private ListView MDAt;
    private TabPage MDAV;
    private ListView tDAO;
    private TabPage gDAe;
    private ListView XDA8;
    private TabPage IDAn;
    private ListView JDAQ;
    private TabPage UDAF;
    private ListView qDAL;
    private TabPage QDAJ;
    private ListView NDA7;
    private Button HDAP;
    private GroupBox CDAi;
    private Button eDAm;
    private GroupBox xDA0;
    private Button mDAI;
    private GroupBox MDAR;
    private Button jDAC;
    private NumericUpDown bDAK;
    private Label XDAU;
    private Label oDAT;
    private Label ODA1;
    private ComboBox bDAW;
    private ComboBox zDAw;
    private ComboBox TDAN;
    private ComboBox VDAY;
    private NumericUpDown BDAB;
    private Label ADAA;
    private Label hDAf;
    private Label UDA6;
    private ComboBox qDAx;
    private ComboBox vDA9;
    private ComboBox RDAc;
    private ComboBox YDAy;
    private TreeView mDAr;
    private Button LDAq;
    private TableLayoutPanel IDAk;
    private Button DDAM;
    private Button zDAu;
    private Button TDAg;
    private TabPage LDA2;
    private GroupBox pDA3;
    private GroupBox DDAd;
    private Button ADAH;
    private Button WDA4;
    private Button lDA5;
    private Button GDAs;
    private GroupBox TDAZ;
    private Button oDAa;
    private Button jDAj;
    private Button LDAz;
    private Button oDfE;
    private Button FDfD;
    private Button IDfX;
    private Button pDfp;
    private Button fDfS;
    private Button QDfh;
    private Button iDfl;
    private Button hDfG;
    private Button HDfb;
    private GroupBox JDfv;
    private Button KDfo;
    private Button gDft;
    private Button UDfV;
    private GroupBox cDfO;
    private Button rDfe;
    private Button LDf8;
    private Button uDfn;
    private Button SDfQ;
    private Button bDfF;
    private Button kDfL;
    private Button bDfJ;
    private Button gDf7;
    private Button vDfP;
    private Button ODfi;
    private Button uDfm;
    private Button XDf0;
    private Button rDfI;
    private Button fDfR;
    private Button sDfC;
    private Button vDfK;
    private Button PDfU;
    private Button pDfT;
    private Button JDf1;
    private Button cDfW;
    private Button JDfw;
    private Button jDfN;
    private GroupBox fDfY;
    private Button TDfB;
    private Button JDfA;
    private Button rDff;
    private Button dDf6;
    private Button oDfx;
    private Button aDf9;
    private Button UDfc;
    private Button PDfy;
    private GroupBox qDfr;
    private Button HDfq;
    private Button MDfk;
    private Button nDfM;
    private Button iDfu;
    private Button UDfg;
    private ToolStripProgressBar NDf2;
    private ToolStripStatusLabel ADf3;
    private Label eDfd;
    private Label iDfH;
    private Label ODf4;
    private Label sDf5;
    private Label QDfs;
    private Label IDfZ;
    private Label DDfa;
    private Label kDfj;
    private Button dDfz;
    private Button bD6E;
    private Button tD6D;
    private Button sD6X;
    private Button AD6p;
    private Button mD6S;
    private Button hD6h;
    private Button OD6l;
    private Button cD6G;
    private Button WD6b;
    private Button CD6v;
    private Button KD6o;
    private Button PD6t;
    private GroupBox zD6V;
    private GroupBox GD6O;
    private GroupBox PD6e;
    private GroupBox GD68;
    private GroupBox kD6n;
    private GroupBox uD6Q;
    private Button SD6F;
    private GroupBox CD6L;
    private GroupBox AD6J;
    private Button TD67;
    private Button WD6P;
    private Button PD6i;
    private Button cD6m;
    private Button nD60;
    private Button TD6I;
    private Button TD6R;
    private Button WD6C;
    private TabPage OD6K;
    private GroupBox WD6U;
    private Label DD6T;
    private Label bD61;
    private Label ND6W;
    private Button pD6w;
    private Button qD6N;
    private Button UD6Y;
    private TextBox KD6B;
    private TextBox hD6A;
    private TextBox HD6f;
    private Button nD66;
    private ColorDialog BD6x;
    private Button ID69;
    private BackgroundWorker TD6c;
    private Button CD6y;
    private GroupBox PD6r;
    private Button eD6q;
    private ComboBox YD6k;
    private ToolStripMenuItem LD6M;
    private Button GD6u;
    private Button zD6g;
    private Button hD62;
    private Button mD63;
    private Button fD6d;
    private ToolTip MD6H;
    private Button eD64;
    private Button SD65;
    private Button rD6s;
    private TabPage iD6Z;
    private Button yD6a;
    private Button iD6j;
    private Button JD6z;
    private ListBox sDxE;
    private CheckedListBox VDxD;
    private ListBox FDxX;
    private TabPage uDxp;
    private Label fDxS;
    private Label oDxh;
    private GroupBox nDxl;
    private GroupBox pDxG;
    private GroupBox bDxb;
    private GroupBox yDxv;
    private GroupBox qDxo;
    private GroupBox ADxt;
    private GroupBox DDxV;
    private GroupBox GDxO;
    private Label yDxe;
    private GroupBox vDx8;
    private Label nDxn;
    private TableLayoutPanel RDxQ;
    private TableLayoutPanel MDxF;
    private Label JDxL;
    private PictureBox VDxJ;
    private PictureBox sDx7;
    private PictureBox WDxP;
    private PictureBox yDxi;
    private PictureBox jDxm;
    private PictureBox aDx0;
    private Label pDxI;
    private Label DDxR;
    private Label kDxC;
    private Label lDxK;
    private Label ADxU;
    private Label CDxT;
    private Label HDx1;
    private Label KDxW;
    private Label rDxw;
    private PictureBox TDxN;
    private PictureBox PDxY;
    private PictureBox zDxB;
    private PictureBox pDxA;
    private PictureBox JDxf;
    private PictureBox KDx6;
    private PictureBox LDxx;
    private PictureBox UDx9;
    private PictureBox DDxc;
    private PictureBox IDxy;
    private Label DDxr;
    private Label PDxq;
    private PictureBox GDxk;
    private PictureBox MDxM;
    private PictureBox jDxu;
    private PictureBox DDxg;
    private Label ADx2;
    private Label uDx3;
    private Label dDxd;
    private Label gDxH;
    private Label JDx4;
    private Label jDx5;
    private Label DDxs;
    private PictureBox CDxZ;
    private PictureBox BDxa;
    private PictureBox iDxj;
    private PictureBox YDxz;
    private PictureBox wD9E;
    private PictureBox fD9D;
    private PictureBox uD9X;
    private PictureBox DD9p;
    private PictureBox RD9S;
    private PictureBox LD9h;
    private PictureBox LD9l;
    private PictureBox cD9G;
    private GroupBox xD9b;
    private Label SD9v;
    private Label JD9o;
    private Label wD9t;
    private Button GD9V;
    private Button gD9O;
    private GroupBox kD9e;
    private Label qD98;
    private Label ND9n;
    private Label CD9Q;
    private Label KD9F;
    private GroupBox vD9L;
    private Label lD9J;
    private Label TD97;
    private Label KD9P;
    private Label QD9i;
    private Label AD9m;
    private Label HD90;
    private Label hD9I;
    private Label zD9R;
    private Label jD9C;
    private Label gD9K;
    private GroupBox SD9U;
    private Label OD9T;
    private Label lD91;
    private Label OD9W;
    private Label XD9w;
    private Label gD9N;
    private Label JD9Y;
    private TableLayoutPanel eD9B;
    private CheckBox wD9A;
    private CheckBox rD9f;
    private CheckBox dD96;
    private CheckBox ED9x;
    private CheckBox rD99;
    private CheckBox MD9c;
    private CheckBox wD9y;
    private Label yD9r;
    private Label xD9q;
    private CheckBox YD9k;
    private Label cD9M;
    private CheckBox KD9u;
    private Label hD9g;
    private Label RD92;
    private Label SD93;
    private Label fD9d;
    private CheckBox PD9H;
    private Label tD94;
    private Label CD95;
    private Label vD9s;
    private CheckBox tD9Z;
    private Label PD9a;
    private Label DD9j;
    private CheckBox BD9z;
    private Label NDcE;
    private Label TDcD;
    private Label xDcX;
    private Label VDcp;
    private Label MDcS;
    private Label iDch;
    private TableLayoutPanel XDcl;
    private CheckBox dDcG;
    private CheckBox yDcb;
    private CheckBox cDcv;
    private CheckBox jDco;
    private CheckBox sDct;
    private CheckBox vDcV;
    private CheckBox IDcO;
    private Label JDce;
    private Label UDc8;
    private CheckBox aDcn;
    private Label bDcQ;
    private CheckBox ADcF;
    private Label mDcL;
    private Label nDcJ;
    private Label GDc7;
    private Label QDcP;
    private CheckBox WDci;
    private Label qDcm;
    private Label BDc0;
    private Label sDcI;
    private CheckBox lDcR;
    private Label gDcC;
    private Label WDcK;
    private CheckBox RDcU;
    private Label vDcT;
    private Label WDc1;
    private Label ODcW;
    private Label PDcw;
    private Label yDcN;
    private Label cDcY;
    private TableLayoutPanel BDcB;
    private CheckBox SDcA;
    private CheckBox iDcf;
    private CheckBox HDc6;
    private CheckBox gDcx;
    private CheckBox TDc9;
    private CheckBox RDcc;
    private CheckBox YDcy;
    private Label zDcr;
    private Label zDcq;
    private CheckBox zDck;
    private Label EDcM;
    private CheckBox cDcu;
    private Label sDcg;
    private Label XDc2;
    private Label KDc3;
    private Label fDcd;
    private CheckBox CDcH;
    private Label WDc4;
    private Label mDc5;
    private Label sDcs;
    private CheckBox bDcZ;
    private Label qDca;
    private Label WDcj;
    private CheckBox jDcz;
    private Label WDyE;
    private Label YDyD;
    private Label QDyX;
    private Label PDyp;
    private Label LDyS;
    private Label WDyh;
    private TableLayoutPanel PDyl;
    private CheckBox bDyG;
    private CheckBox sDyb;
    private CheckBox XDyv;
    private CheckBox ODyo;
    private CheckBox EDyt;
    private CheckBox eDyV;
    private CheckBox JDyO;
    private Label DDye;
    private Label WDy8;
    private CheckBox BDyn;
    private Label LDyQ;
    private CheckBox UDyF;
    private Label qDyL;
    private Label fDyJ;
    private Label MDy7;
    private Label NDyP;
    private CheckBox KDyi;
    private Label iDym;
    private Label jDy0;
    private Label MDyI;
    private CheckBox NDyR;
    private Label QDyC;
    private Label vDyK;
    private CheckBox ODyU;
    private Label xDyT;
    private Label aDy1;
    private Label BDyW;
    private Label IDyw;
    private Label NDyN;
    private Label uDyY;
    private TableLayoutPanel PDyB;
    private CheckBox NDyA;
    private CheckBox dDyf;
    private CheckBox ADy6;
    private CheckBox YDyx;
    private CheckBox IDy9;
    private CheckBox GDyc;
    private CheckBox hDyy;
    private Label KDyr;
    private Label FDyq;
    private CheckBox RDyk;
    private Label VDyM;
    private CheckBox oDyu;
    private Label JDyg;
    private Label VDy2;
    private Label IDy3;
    private Label eDyd;
    private CheckBox EDyH;
    private Label VDy4;
    private Label RDy5;
    private Label xDys;
    private CheckBox cDyZ;
    private Label zDya;
    private Label NDyj;
    private CheckBox gDyz;
    private Label VDrE;
    private Label hDrD;
    private Label UDrX;
    private Label xDrp;
    private Label SDrS;
    private Label MDrh;
    private TableLayoutPanel uDrl;
    private CheckBox DDrG;
    private CheckBox GDrb;
    private CheckBox CDrv;
    private CheckBox hDro;
    private CheckBox pDrt;
    private CheckBox QDrV;
    private CheckBox cDrO;
    private Label NDre;
    private Label hDr8;
    private CheckBox cDrn;
    private Label iDrQ;
    private CheckBox oDrF;
    private Label zDrL;
    private Label SDrJ;
    private Label IDr7;
    private Label yDrP;
    private CheckBox bDri;
    private Label lDrm;
    private Label XDr0;
    private Label YDrI;
    private CheckBox qDrR;
    private Label dDrC;
    private Label EDrK;
    private CheckBox mDrU;
    private Label eDrT;
    private Label NDr1;
    private Label KDrW;
    private Label zDrw;
    private Label iDrN;
    private Label mDrY;
    private TableLayoutPanel bDrB;
    private CheckBox vDrA;
    private CheckBox BDrf;
    private CheckBox PDr6;
    private CheckBox GDrx;
    private CheckBox vDr9;
    private CheckBox RDrc;
    private CheckBox nDry;
    private Label SDrr;
    private Label jDrq;
    private CheckBox DDrk;
    private Label WDrM;
    private CheckBox kDru;
    private Label GDrg;
    private Label kDr2;
    private Label LDr3;
    private Label vDrd;
    private CheckBox uDrH;
    private Label mDr4;
    private Label mDr5;
    private Label XDrs;
    private CheckBox ODrZ;
    private Label UDra;
    private Label uDrj;
    private CheckBox VDrz;
    private Label BDqE;
    private Label RDqD;
    private Label NDqX;
    private Label NDqp;
    private Label iDqS;
    private Label pDqh;
    private TableLayoutPanel dDql;
    private CheckBox aDqG;
    private CheckBox PDqb;
    private CheckBox WDqv;
    private CheckBox CDqo;
    private CheckBox UDqt;
    private CheckBox VDqV;
    private CheckBox YDqO;
    private Label NDqe;
    private Label CDq8;
    private CheckBox bDqn;
    private Label aDqQ;
    private CheckBox XDqF;
    private Label eDqL;
    private Label oDqJ;
    private Label eDq7;
    private Label ADqP;
    private CheckBox pDqi;
    private Label wDqm;
    private Label aDq0;
    private Label tDqI;
    private CheckBox YDqR;
    private Label fDqC;
    private Label jDqK;
    private CheckBox kDqU;
    private Label pDqT;
    private Label ODq1;
    private Label tDqW;
    private Label QDqw;
    private void dDm7() {
        MessageBox.Show(Class13.sXQS);
    }

    private void zDmP() {
    }

    private void UDmi() {
    }

    private void xDmm() {
    }

    private void ADm0() {
        MessageBox.Show(Class13.gXQh);
    }

    private void gDmI() {
    }

    private void NDmR() {
    }

    private void nDmC() {
    }

    private bool jDmK() {
        return false;
    }

    private bool fDmU() {
        return false;
    }

    private bool uDmT() {
        return false;
    }

    private bool fDm1() {
        return false;
    }

    private bool CDmW() {
        return false;
    }

    private bool hDmw() {
        return false;
    }

    private bool BDmN() {
        return false;
    }

    private bool UDmY() {
        return false;
    }

    private bool GDmB() {
        return false;
    }

    private bool QDmA() {
        return false;
    }

    private bool rDmf() {
        return false;
    }

    private bool kDm6() {
        return false;
    }

    private bool bDmx() {
        return false;
    }

    private bool fDm9() {
        return false;
    }

    private bool HDmc() {
        return false;
    }

    private bool YDmy() {
        return false;
    }

    private bool tDmr() {
        return false;
    }

    private bool GDmq() {
        return false;
    }

    private void UDmk() {
    }

    private void RDmM(string string_0, ListView listView_0) {
    }

    private void HDmu(string string_0, CheckedListBox checkedListBox_0) {
    }

    private void xDmg() {
    }

    private void EDm2(string string_0, ListView listView_0) {
    }

    private void MDm3(object sender, MouseEventArgs e) {
        MessageBox.Show(Class13.LXQl);
    }

    private void qDmd() {
        MessageBox.Show(Class13.tXQG);
    }

    private void YDmH(string string_0, ListView listView_0) {
    }

    private void aDm4(object sender, MouseEventArgs e) {
    }

    private void JDm5(bool bool_0) {
    }

    private void zDms() {
    }

    private void ODmZ(string string_0) {
    }

    private uint JDma(string string_0) {
        return 1u;
    }

    private void EDmj(string string_0, uint uint_0) {
    }

    private void aDmz(object sender, EventArgs e) {
    }

    private void CD0E(object sender, EventArgs e) {
    }

    private void nD0D(object sender, EventArgs e) {
        MessageBox.Show(Class13.SXQb);
    }

    private void wD0X(object sender, EventArgs e) {
        MessageBox.Show(Class13.jXQv);
    }

    private void RD0p(object sender, EventArgs e) {
        MessageBox.Show(Class13.IXQo);
    }

    private void PD0S(object sender, EventArgs e) {
        MessageBox.Show(Class13.FXQt);
    }

    private void TD0h(object sender, EventArgs e) {
    }

    private float gD0l() {
        return Class13.cXQV;
    }

    private void yD0G(object sender, EventArgs e) {
    }

    private void TD0b(object sender, EventArgs e) {
    }

    private void ND0v(object sender, EventArgs e) {
    }

    private void lD0o(object sender, EventArgs e) {
    }

    private void pD0t(object sender, EventArgs e) {
    }

    private void eD0V(object sender, EventArgs e) {
    }

    private void ID0O(uint uint_0, Dictionary<uint, uint[]> dictionary_0) {
    }

    private void ID0e(object sender, EventArgs e) {
    }

    private void pD08(object sender, EventArgs e) {
    }

    private void hD0n(object sender, EventArgs e) {
    }

    private void ND0Q(object sender, EventArgs e) {
    }

    private void dD0F(object sender, EventArgs e) {
    }

    private void tD0L(object sender, EventArgs e) {
    }

    private void lD0J(object sender, EventArgs e) {
    }

    private void nD07(object sender, EventArgs e) {
    }

    private void WD0P(object sender, EventArgs e) {
    }

    private void RD0i(object sender, EventArgs e) {
    }

    public void OD0m(ref uint uint_0, uint uint_1, bool bool_0) {
    }

    private void iD00(object sender, EventArgs e) {
    }

    private void JD0I(object sender, EventArgs e) {
    }

    private void aD0R() {
        MessageBox.Show(Class13.hXQO);
    }

    private void YD0C() {
    }

    private void zD0K() {
    }

    private void ND0U() {
    }

    private void SD0T(object sender, EventArgs e) {
    }

    private void xD01() {
    }

    private void bD0W(object sender, EventArgs e) {
    }

    private void YD0w(object sender, EventArgs e) {
    }

    private void bD0N(bool bool_0) {
    }

    private void UD0Y(object sender, EventArgs e) {
    }

    private void AD0B(object sender, EventArgs e) {
    }

    private void JD0A(object sender, EventArgs e) {
    }

    private void lD0f(string string_0) {
        SDTY.Text = string_0;
    }

    private void UD06(object sender, EventArgs e) {
    }

    private void WD0x(object sender, EventArgs e) {
    }

    private void nD09(object sender, EventArgs e) {
    }

    private void BD0c(object sender, EventArgs e) {
    }

    private void UD0y(object sender, EventArgs e) {
    }

    private void MD0r(object sender, EventArgs e) {
    }

    private void xD0q(object sender, EventArgs e) {
    }

    private void xD0k(object sender, EventArgs e) {
    }

    private void iD0M(object sender, EventArgs e) {
    }

    private void WD0u(object sender, EventArgs e) {
    }

    private void MD0g(object sender, EventArgs e) {
    }

    private void tD02(object sender, EventArgs e) {
    }

    private void gD03(object sender, EventArgs e) {
    }

    private void oD0d(object sender, EventArgs e) {
    }

    private void vD0H(object sender, EventArgs e) {
    }

    private void dD04(object sender, EventArgs e) {
    }

    private void PD05(object sender, EventArgs e) {
    }

    private void kD0s(object sender, EventArgs e) {
        MessageBox.Show(Class13.wXQe);
    }

    private void lD0Z(object sender, EventArgs e) {
    }

    private void YD0a(object sender, EventArgs e) {
    }

    private void oD0j(object sender, EventArgs e) {
    }

    private void QD0z(object sender, EventArgs e) {
    }

    private void iDIE(object sender, EventArgs e) {
    }

    private void rDID(object sender, EventArgs e) {
        MessageBox.Show(Class13.KXQ8);
    }

    private void qDIX(object sender, EventArgs e) {
    }

    private void sDIp(object sender, EventArgs e) {
        MessageBox.Show(Class13.CXQn);
    }

    private void uDIS(object sender, EventArgs e) {
    }

    private void cDIh(object sender, EventArgs e) {
    }

    private void XDIl(object sender, EventArgs e) {
    }

    private void kDIG(object sender, EventArgs e) {
    }

    private void NDIb(object sender, EventArgs e) {
    }

    private void rDIv(object sender, EventArgs e) {
    }

    private void xDIo(object sender, EventArgs e) {
    }

    private void NDIt(object sender, EventArgs e) {
    }

    private void UDIV(object sender, EventArgs e) {
    }

    private void gDIO(object sender, EventArgs e) {
    }

    private void zDIe(object sender, EventArgs e) {
    }

    private void YDI8(object sender, EventArgs e) {
        MessageBox.Show(Class13.zXQQ);
    }

    private void qDIn(object sender, EventArgs e) {
    }

    private void XDIQ(object sender, EventArgs e) {
    }

    private void DDIF(object sender, EventArgs e) {
    }

    private void yDIL(object sender, EventArgs e) {
    }

    private void QDIJ(object sender, EventArgs e) {
    }

    private void qDI7(object sender, EventArgs e) {
    }

    private void GDIP(object sender, EventArgs e) {
    }

    private void yDIi(object sender, EventArgs e) {
    }

    private void RDIm(Class40 rOe_0, Dictionary<int, Class80> dictionary_0) {
    }

    private void DDI0(object sender, EventArgs e) {
    }

    private void TDII(object sender, EventArgs e) {
    }

    private void SDIR(object sender, EventArgs e) {
    }

    private void gDIC(object sender, EventArgs e) {
    }

    private void GDIK(object sender, EventArgs e) {
    }

    private void xDIU(object sender, EventArgs e) {
    }

    private void vDIT(object sender, EventArgs e) {
    }

    private void GDI1(object sender, EventArgs e) {
    }

    private void xDIW(object sender, EventArgs e) {
    }

    private void LDIw(object sender, EventArgs e) {
        MessageBox.Show(Class13.LXQF);
    }

    private void YDIN(object sender, EventArgs e) {
    }

    private void qDIY(object sender, EventArgs e) {
    }

    private void pDIB(object sender, EventArgs e) {
    }

    private void NDIA(object sender, EventArgs e) {
    }

    private void BDIf(object sender, EventArgs e) {
    }

    private void JDI6(object sender, EventArgs e) {
    }

    private void JDIx(object sender, EventArgs e) {
    }

    private void xDI9(object sender, EventArgs e) {
    }

    private void ODIc(object sender, EventArgs e) {
    }

    private void FDIy(object sender, EventArgs e) {
    }

    private void yDIr(object sender, EventArgs e) {
    }

    private void kDIq(object sender, EventArgs e) {
    }

    private void qDIk(object sender, EventArgs e) {
    }

    private void vDIM(object sender, EventArgs e) {
    }

    private void tDIu(object sender, EventArgs e) {
        MessageBox.Show(Class13.BXQL);
    }

    private void jDIg(object sender, EventArgs e) {
    }

    private void ODI2(object sender, EventArgs e) {
    }

    private void RDI3(object sender, EventArgs e) {
    }

    private void XDId(object sender, EventArgs e) {
    }

    private void SDIH(object sender, EventArgs e) {
    }

    private void ADI4(object sender, EventArgs e) {
        MessageBox.Show(Class13.XXQJ);
    }

    private void iDI5(object sender, EventArgs e) {
    }

    private void FDIs(object sender, EventArgs e) {
    }

    private void SDIZ(object sender, EventArgs e) {
        MessageBox.Show(Class13.vXQ7);
    }

    private void PDIa(object sender, EventArgs e) {
    }

    private void EDIj(object sender, EventArgs e) {
    }

    private void LDIz(object sender, EventArgs e) {
    }

    private void IDRE(object sender, EventArgs e) {
    }

    private void lDRD(object sender, EventArgs e) {
    }

    private void xDRX(object sender, EventArgs e) {
    }

    private void mDRp(object sender, EventArgs e) {
    }

    private void WDRS(object sender, EventArgs e) {
    }

    private void gDRh(object sender, EventArgs e) {
    }

    private void lDRl(object sender, EventArgs e) {
    }

    private void KDRG(object sender, EventArgs e) {
    }

    private void vDRb(object sender, EventArgs e) {
    }

    private void QDRv(object sender, EventArgs e) {
    }

    private void eDRo(object sender, EventArgs e) {
    }

    private void sDRt(object sender, EventArgs e) {
    }

    private void sDRV(object sender, EventArgs e) {
    }

    private void IDRO(object sender, EventArgs e) {
    }

    private void kDRe(object sender, EventArgs e) {
    }

    private void bDR8(object sender, EventArgs e) {
    }

    private void YDRn(object sender, EventArgs e) {
    }

    private void TDRQ(object sender, EventArgs e) {
    }

    private void vDRF(object sender, EventArgs e) {
    }

    private void wDRL(object sender, EventArgs e) {
    }

    private void YDRJ(object sender, EventArgs e) {
    }

    private void aDR7(object sender, EventArgs e) {
    }

    private void mDRP(object sender, EventArgs e) {
    }

    private void pDRi(object sender, EventArgs e) {
    }

    private void hDRm(object sender, EventArgs e) {
    }

    private void VDR0(object sender, EventArgs e) {
    }

    private void hDRI(object sender, EventArgs e) {
    }

    private void qDRR(object sender, EventArgs e) {
    }

    private void HDRC(object sender, EventArgs e) {
    }

    private void gDRK(object sender, EventArgs e) {
    }

    private void aDRU(object sender, EventArgs e) {
    }

    private void TDRT(object sender, EventArgs e) {
        MessageBox.Show(Class13.hXQP);
    }

    private void NDR1(object sender, EventArgs e) {
    }

    private void jDRW(object sender, EventArgs e) {
    }

    private void BDRw(object sender, EventArgs e) {
    }

    private void aDRN(object sender, EventArgs e) {
    }

    private void RDRY(object sender, EventArgs e) {
    }

    private void UDRB(object sender, EventArgs e) {
    }

    private void ADRA(object sender, EventArgs e) {
    }

    private void WDRf(object sender, EventArgs e) {
    }

    private void fDR6(object sender, EventArgs e) {
    }

    private void vDRx(object sender, EventArgs e) {
    }

    private void MDR9(object sender, EventArgs e) {
    }

    private void kDRc(object sender, EventArgs e) {
    }

    private void KDRy(object sender, EventArgs e) {
    }

    private void aDRr(object sender, EventArgs e) {
    }

    private void iDRq(object sender, EventArgs e) {
    }

    private void bDRk(object sender, EventArgs e) {
    }

    private void RDRM(object sender, EventArgs e) {
    }

    private void KDRu(object sender, EventArgs e) {
    }

    private void vDRg(object sender, EventArgs e) {
    }

    private void IDR2(object sender, EventArgs e) {
    }

    private void HDR3(object sender, EventArgs e) {
    }

    private void TDRd(object sender, EventArgs e) {
    }

    private void ADRH(object sender, EventArgs e) {
    }

    private void BDR4(object sender, EventArgs e) {
    }

    private void yDR5(object sender, EventArgs e) {
    }

    private void YDRs(object sender, EventArgs e) {
    }

    private void IDRZ(object sender, EventArgs e) {
        MessageBox.Show(Class13.PXQi);
    }

    private void YDRa(object sender, EventArgs e) {
    }

    private void HDRj(object sender, EventArgs e) {
    }

    private void YDRz(object sender, EventArgs e) {
    }

    private void sDCE(object sender, EventArgs e) {
        MessageBox.Show(Class13.yXQm);
    }

    private void oDCD(object sender, EventArgs e) {
    }

    private void CDCX(object sender, EventArgs e) {
    }

    private void PDCp(object sender, EventArgs e) {
    }

    private void VDCS(object sender, EventArgs e) {
    }

    private void lDCh(object sender, EventArgs e) {
    }

    private void RDCl(object sender, EventArgs e) {
    }

    private void ADCG(object sender, EventArgs e) {
    }

    private void SDCb(object sender, EventArgs e) {
    }

    private void SDCv(object sender, EventArgs e) {
    }

    private void tDCo(object sender, EventArgs e) {
    }

    private void nDCt(object sender, EventArgs e) {
    }

    private void oDCV(object sender, EventArgs e) {
    }

    private void wDCO(object sender, EventArgs e) {
    }

    private void EDCe(object sender, EventArgs e) {
    }

    private void tDC8(object sender, EventArgs e) {
    }

    private void qDCn(object sender, EventArgs e) {
    }

    private void cDCQ(object sender, EventArgs e) {
    }

    private void SDCF(object sender, EventArgs e) {
    }

    private void SDCL(object sender, EventArgs e) {
        MessageBox.Show(Class13.XXQ0);
    }

    private void uDCJ(object sender, EventArgs e) {
    }

    private void vDC7(object sender, EventArgs e) {
    }

    private void RDCP(object sender, EventArgs e) {
    }

    private void eDCi(object sender, EventArgs e) {
    }

    private void SDCm(object sender, EventArgs e) {
    }

    private void HDC0(object sender, EventArgs e) {
    }

    private void KDCI(object sender, EventArgs e) {
    }

    private void PDCR(object sender, EventArgs e) {
    }

    private void dDCC(object sender, EventArgs e) {
    }

    private void ODCK(object sender, EventArgs e) {
    }

    private void nDCU(object sender, EventArgs e) {
    }

    private void pDCT(object sender, EventArgs e) {
    }

    private void QDC1(object sender, EventArgs e) {
    }

    private void aDCW(object sender, EventArgs e) {
    }

    private void FDCw(object sender, EventArgs e) {
    }

    private void vDCN(object sender, EventArgs e) {
    }

    private void pDCY(object sender, EventArgs e) {
    }

    private void oDCB(object sender, EventArgs e) {
    }

    private void lDCA(object sender, EventArgs e) {
    }

    private void hDCf(object sender, EventArgs e) {
    }

    private void WDC6(object sender, EventArgs e) {
    }

    private void XDCx(object sender, EventArgs e) {
    }

    private void sDC9(object sender, EventArgs e) {
    }

    private void VDCc(object sender, EventArgs e) {
    }

    private void xDCy(object sender, EventArgs e) {
    }

    private void xDCr(object sender, EventArgs e) {
    }

    private void XDCq(object sender, EventArgs e) {
    }

    private void MDCk(object sender, EventArgs e) {
    }

    private void eDCM(object sender, EventArgs e) {
    }

    private void EDCu(object sender, EventArgs e) {
        MessageBox.Show(Class13.gXQI);
    }

    private bool oDCg(uint uint_0, bool bool_0 = true) {
        return true;
    }

    private bool lDC2(uint uint_0) {
        return true;
    }

    private bool zDC3(uint uint_0) {
        return true;
    }

    private bool GDCd(uint uint_0) {
        return true;
    }

    private bool gDCH(uint uint_0) {
        return true;
    }

    private bool uDC4(uint uint_0) {
        return true;
    }

    private bool XDC5(uint uint_0) {
        return true;
    }

    private bool oDCs(uint uint_0, bool bool_0 = true) {
        return true;
    }

    private bool NDCZ(uint uint_0, bool bool_0 = true) {
        return true;
    }

    private bool sDCa(uint uint_0, bool bool_0 = true) {
        return true;
    }

    private bool cDCj(uint uint_0, bool bool_0 = true) {
        return true;
    }

    private bool bDCz(uint uint_0, bool bool_0 = true) {
        return true;
    }

    private bool nDKE(uint uint_0, bool bool_0 = true) {
        return true;
    }

    private void SDKD(object sender, EventArgs e) {
    }

    private void WDKX(object sender, EventArgs e) {
    }

    private void YDKp(object sender, EventArgs e) {
    }

    private void hDKS(object sender, EventArgs e) {
    }

    private void BDKh(object sender, EventArgs e) {
    }

    private void FDKl(object sender, EventArgs e) {
    }

    private void EDKG(object sender, TreeNodeMouseClickEventArgs e) {
    }

    private void mDKb(object sender, EventArgs e) {
    }

    private void NDKv(object sender, EventArgs e) {
    }

    private void VDKo(object sender, EventArgs e) {
    }

    private void GDKt(object sender, EventArgs e) {
    }

    private void ADKV(object sender, EventArgs e) {
    }

    private void ODKO(object sender, EventArgs e) {
    }

    private void pDKe(object sender, EventArgs e) {
    }

    private void DDK8(object sender, EventArgs e) {
    }

    private void MDKn(object sender, EventArgs e) {
    }

    private void qDKQ(object sender, EventArgs e) {
    }

    private void uDKF(object sender, EventArgs e) {
    }

    private void FDKL(object sender, EventArgs e) {
    }

    private void mDKJ(object sender, EventArgs e) {
    }

    private void qDK7(object sender, EventArgs e) {
    }

    private void nDKP(object sender, EventArgs e) {
    }

    private void ODKi(object sender, EventArgs e) {
    }

    private void dDKm(object sender, EventArgs e) {
    }

    private uint LDK0(byte[] byte_0, int int_0) {
        return 1u;
    }

    private void JDKI() {
    }

    private void JDKR(Control control_0, byte[] byte_0) {
    }

    public void wDKC(object sender, EventArgs e) {
    }

    private void DDKK(object sender, EventArgs e) {
    }

    private void mDKU(object sender, EventArgs e) {
    }

    private void mDKT(object sender, EventArgs e) {
    }

    private void UDK1(object sender, EventArgs e) {
    }

    private void JDKW(object sender, EventArgs e) {
    }

    private void SDKw(object sender, EventArgs e) {
    }

    private void MDKN(object sender, EventArgs e) {
    }

    private void GDKY(object sender, EventArgs e) {
    }

    private void qDKB(object sender, EventArgs e) {
    }

    private void QDKA(object sender, EventArgs e) {
    }

    private void ODKf(object sender, EventArgs e) {
    }

    private void HDK6(object sender, EventArgs e) {
    }

    private void DDKx(object sender, EventArgs e) {
    }

    private void gDK9(object sender, EventArgs e) {
    }

    private void IDKc(object sender, EventArgs e) {
    }

    private void bDKy(object sender, EventArgs e) {
    }

    private void WDKr(object sender, EventArgs e) {
    }

    private void QDKq(object sender, EventArgs e) {
    }

    private void sDKk(object sender, EventArgs e) {
    }

    private void XDKM(object sender, EventArgs e) {
    }

    private void ADKu(object sender, EventArgs e) {
    }

    private void tDKg(object sender, EventArgs e) {
    }

    private void EDK2(object sender, EventArgs e) {
    }

    private void WDK3(object sender, EventArgs e) {
    }

    private void rDKd(object sender, EventArgs e) {
    }

    private void RDKH(object sender, EventArgs e) {
    }

    private void pDK4(object sender, EventArgs e) {
    }

    private void CDK5(object sender, EventArgs e) {
    }

    private void yDKs(object sender, EventArgs e) {
    }

    private void UDKZ(object sender, EventArgs e) {
    }

    private void YDKa(object sender, EventArgs e) {
    }

    private void aDKj(object sender, EventArgs e) {
    }

    private void TDKz(object sender, EventArgs e) {
    }

    private void BDUE(object sender, EventArgs e) {
    }

    private void CDUD(object sender, EventArgs e) {
    }

    private void oDUX(object sender, EventArgs e) {
    }

    private void zDUp(object sender, EventArgs e) {
    }

    private void yDUS(object sender, EventArgs e) {
    }

    private void VDUh(object sender, EventArgs e) {
    }

    private void CDUl(object sender, EventArgs e) {
    }

    private void VDUG(object sender, EventArgs e) {
    }

    private void NDUb(object sender, EventArgs e) {
    }

    private void UDUv(object sender, EventArgs e) {
    }

    private void fDUo(object sender, EventArgs e) {
    }

    private void KDUt(object sender, EventArgs e) {
    }

    private void nDUV(object sender, EventArgs e) {
    }

    private void nDUO(object sender, EventArgs e) {
    }

    private void cDUe(object sender, EventArgs e) {
    }

    private void yDU8(object sender, EventArgs e) {
    }

    private void BDUn(object sender, EventArgs e) {
    }

    private void KDUQ(object sender, EventArgs e) {
    }

    private void rDUF(object sender, EventArgs e) {
    }

    private void CDUL(object sender, EventArgs e) {
    }

    private void yDUJ(object sender, EventArgs e) {
    }

    private void QDU7(object sender, DoWorkEventArgs e) {
    }

    private void qDUP(object sender, EventArgs e) {
    }

    private void sDUi(object sender, EventArgs e) {
    }

    private void hDUm(object sender, EventArgs e) {
    }

    private void TDU0(object sender, EventArgs e) {
    }

    private void qDUI(object sender, EventArgs e) {
    }

    private void jDUR(object sender, EventArgs e) {
    }

    private void iDUC(object sender, EventArgs e) {
    }

    private void HDUK(object sender, EventArgs e) {
    }

    private void fDUU(object sender, EventArgs e) {
    }

    private void uDUT(object sender, EventArgs e) {
    }

    private void ADU1(object sender, EventArgs e) {
    }

    private void cDUW(object sender, EventArgs e) {
    }

    private void HDUw(object sender, EventArgs e) {
    }

    private void DDUN(object sender, EventArgs e) {
    }

    private void ODUY(object sender, EventArgs e) {
    }

    private void wDUB(object sender, EventArgs e) {
    }

    private void BDUA(object sender, EventArgs e) {
    }

    private void vDUf(object sender, EventArgs e) {
    }

    private void JDU6(object sender, EventArgs e) {
    }

    private void uDUx(object sender, EventArgs e) {
    }

    private void PDU9(object sender, EventArgs e) {
    }

    private void uDUc(object sender, EventArgs e) {
    }

    private void LDUy(object sender, EventArgs e) {
    }

    private void tDUr(object sender, EventArgs e) {
    }

    private void YDUq(object sender, EventArgs e) {
    }

    private void SDUk(object sender, EventArgs e) {
    }

    private void rDUM(object sender, EventArgs e) {
    }

    private void FDUu(object sender, EventArgs e) {
    }

    private void EDUg(object sender, EventArgs e) {
    }

    private void LDU2(object sender, EventArgs e) {
    }

    private void zDU3(object sender, EventArgs e) {
    }

    public static uint tDUd(float float_0) {
        return 1u;
    }

    public static float PDUH(uint uint_0) {
        return BitConverter.ToSingle(BitConverter.GetBytes(uint_0), 0);
    }

    protected override void Dispose(bool disposing) {
        if (disposing && DDUz != null) {
            ((IDisposable)DDUz).Dispose();
        }

        base.Dispose(disposing);
    }

    private void LDU4() {
        DDUz = new Container();
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Class5));
        fDTE = new Label();
        QDTD = new Label();
        YDTX = new GroupBox();
        CDTp = new RadioButton();
        bDTS = new TextBox();
        CDTh = new RadioButton();
        rDTl = new RadioButton();
        IDTG = new RadioButton();
        pDTb = new Label();
        GDTv = new Button();
        NDTo = new Button();
        KDTt = new Button();
        YDTV = new Button();
        RDTO = new GroupBox();
        CD6y = new Button();
        hDTe = new Label();
        wDT8 = new TextBox();
        IDTn = new Label();
        EDTQ = new Button();
        lDTF = new Label();
        cDTL = new Button();
        HDTJ = new Label();
        uDT7 = new TextBox();
        fDTP = new TextBox();
        yDTi = new GroupBox();
        LDTT = new Button();
        VDTm = new Button();
        MDT0 = new Button();
        nDTI = new ListBox();
        wDTR = new TextBox();
        sDTC = new Button();
        QDTK = new Button();
        cDTU = new MenuStrip();
        LD6M = new ToolStripMenuItem();
        QDT1 = new TextBox();
        KDTW = new Button();
        qDTw = new GroupBox();
        YDTN = new StatusStrip();
        SDTY = new ToolStripStatusLabel();
        NDf2 = new ToolStripProgressBar();
        ADf3 = new ToolStripStatusLabel();
        jDTB = new TabPage();
        MDTA = new TableLayoutPanel();
        iDTf = new Button();
        KDT6 = new Button();
        rDTx = new Button();
        PD6t = new Button();
        wDT9 = new TabControl();
        QDTc = new TabPage();
        rDTy = new CheckedListBox();
        NDTr = new TabPage();
        EDTq = new CheckedListBox();
        BDTk = new TabPage();
        oDBR = new GroupBox();
        uDBu = new Button();
        IDBC = new GroupBox();
        cDBK = new Button();
        jDBU = new Button();
        IDBT = new Button();
        KDB1 = new Button();
        EDBW = new Button();
        TDBw = new Button();
        zDBN = new Button();
        tDBY = new GroupBox();
        NDBB = new Button();
        PDBA = new Button();
        iDBf = new Button();
        CDB6 = new Button();
        VDBx = new Button();
        lDB9 = new Button();
        JDBc = new Button();
        PDBy = new Button();
        TDBr = new Button();
        iDBq = new Button();
        kDwP = new GroupBox();
        xDNX = new Button();
        XDwT = new Button();
        XDwU = new Button();
        rDwR = new Button();
        RDwC = new Button();
        FDwK = new Button();
        nDwi = new Button();
        bDwm = new Button();
        lDwV = new GroupBox();
        ADwO = new Button();
        bDwe = new Button();
        VDw8 = new Button();
        UDwn = new Button();
        KDwQ = new Button();
        ADwF = new Button();
        RDwL = new Button();
        zDwJ = new Button();
        YDw7 = new Button();
        YDTM = new GroupBox();
        yDTu = new Button();
        vDTg = new Button();
        FDT2 = new Button();
        XDT3 = new Button();
        xDTd = new GroupBox();
        eDfd = new Label();
        iDfH = new Label();
        ODf4 = new Label();
        sDf5 = new Label();
        QDfs = new Label();
        IDfZ = new Label();
        DDfa = new Label();
        kDfj = new Label();
        dDfz = new Button();
        ADTH = new Button();
        dDT4 = new Button();
        cDT5 = new Button();
        jDTs = new Button();
        JDTZ = new Button();
        DDTa = new Button();
        BDTj = new Button();
        sDTz = new Button();
        lD1E = new GroupBox();
        fD1D = new Button();
        DD1X = new Button();
        YD1p = new Button();
        uD1S = new Button();
        oD1h = new Button();
        XD1l = new Button();
        HD1G = new Button();
        nD1b = new Button();
        lD1v = new Button();
        ND1o = new Button();
        MD1t = new Button();
        TD1V = new Button();
        YD1O = new Button();
        dD1e = new Button();
        LDA2 = new TabPage();
        pDA3 = new GroupBox();
        WD6b = new Button();
        CD6v = new Button();
        sD6X = new Button();
        AD6p = new Button();
        mD6S = new Button();
        hD6h = new Button();
        OD6l = new Button();
        cD6G = new Button();
        DDAd = new GroupBox();
        JDfv = new GroupBox();
        JDfw = new Button();
        pDfT = new Button();
        vDfK = new Button();
        sDfC = new Button();
        rDfe = new Button();
        LDf8 = new Button();
        uDfn = new Button();
        SDfQ = new Button();
        bDfF = new Button();
        kDfL = new Button();
        bDfJ = new Button();
        KDfo = new Button();
        gDft = new Button();
        UDfV = new Button();
        cDfO = new GroupBox();
        cDfW = new Button();
        JDf1 = new Button();
        PDfU = new Button();
        fDfR = new Button();
        gDf7 = new Button();
        vDfP = new Button();
        ODfi = new Button();
        uDfm = new Button();
        XDf0 = new Button();
        rDfI = new Button();
        GDAs = new Button();
        ADAH = new Button();
        WDA4 = new Button();
        lDA5 = new Button();
        TDAZ = new GroupBox();
        SD6F = new Button();
        CD6L = new GroupBox();
        QDfh = new Button();
        AD6J = new GroupBox();
        TD67 = new Button();
        WD6P = new Button();
        PD6i = new Button();
        cD6m = new Button();
        nD60 = new Button();
        TD6I = new Button();
        TD6R = new Button();
        WD6C = new Button();
        KD6o = new Button();
        uD6Q = new GroupBox();
        fDfS = new Button();
        IDfX = new Button();
        kD6n = new GroupBox();
        iDfl = new Button();
        FDfD = new Button();
        GD68 = new GroupBox();
        pDfp = new Button();
        PD6e = new GroupBox();
        oDfE = new Button();
        HDfb = new Button();
        GD6O = new GroupBox();
        jDAj = new Button();
        oDAa = new Button();
        zD6V = new GroupBox();
        hDfG = new Button();
        LDAz = new Button();
        mDw1 = new TabPage();
        rDwk = new TabControl();
        TDwM = new TabPage();
        rD6s = new Button();
        SD65 = new Button();
        UDfg = new Button();
        fDfY = new GroupBox();
        TDfB = new Button();
        JDfA = new Button();
        rDff = new Button();
        dDf6 = new Button();
        oDfx = new Button();
        aDf9 = new Button();
        UDfc = new Button();
        PDfy = new Button();
        qDfr = new GroupBox();
        HDfq = new Button();
        MDfk = new Button();
        nDfM = new Button();
        iDfu = new Button();
        EDBI = new Button();
        gDB0 = new Button();
        gDBm = new Button();
        qDND = new Button();
        LDNE = new Button();
        vDw4 = new GroupBox();
        jDfN = new Button();
        fDw5 = new Button();
        WDws = new Button();
        CDwZ = new Button();
        LDwa = new Button();
        oDwu = new TabPage();
        LDBt = new GroupBox();
        yDBi = new Button();
        WDBP = new Button();
        CDB7 = new Button();
        hDBJ = new Button();
        RDBF = new Button();
        xDBL = new Button();
        rDBQ = new Button();
        iDBn = new Button();
        HDBV = new Button();
        LDBh = new GroupBox();
        PDBo = new Button();
        uDBv = new Button();
        bDBb = new Button();
        JDBG = new Button();
        mDBl = new Button();
        IDBD = new GroupBox();
        yDBS = new Button();
        gDBp = new Button();
        oDBX = new Button();
        TDYa = new GroupBox();
        RDBE = new Button();
        NDYz = new Button();
        cDYj = new Button();
        hDNd = new GroupBox();
        CDNH = new Button();
        eDwj = new TabPage();
        qDY5 = new GroupBox();
        qDYs = new Button();
        LDYZ = new PictureBox();
        dDY3 = new GroupBox();
        kDYd = new Button();
        ADYH = new Button();
        xDY4 = new PictureBox();
        qDYT = new GroupBox();
        LDY2 = new Button();
        SDYg = new Button();
        bDYu = new Button();
        bDYM = new Button();
        hDYk = new Button();
        LDYq = new Button();
        BDYr = new Button();
        oDYy = new Button();
        RDY9 = new Button();
        uDYc = new Button();
        vDYx = new Button();
        rDY6 = new Button();
        hDYf = new Button();
        bDYA = new Button();
        PDYB = new Button();
        UDYY = new Button();
        IDYN = new Button();
        DDYw = new Button();
        CDYW = new Button();
        GDY1 = new PictureBox();
        gDY0 = new GroupBox();
        MDYI = new Button();
        WDYR = new Button();
        fDYC = new Button();
        kDYK = new PictureBox();
        QDY7 = new GroupBox();
        cDYU = new Button();
        uDYm = new Button();
        WDYP = new Button();
        HDYi = new PictureBox();
        EDYV = new GroupBox();
        ADYJ = new Button();
        gDYL = new Button();
        nDYF = new Button();
        NDYQ = new Button();
        ADYn = new Button();
        LDY8 = new Button();
        lDYO = new Button();
        SDYe = new PictureBox();
        FDYD = new GroupBox();
        IDYv = new Button();
        JDYG = new Button();
        hDYX = new Button();
        iDYp = new Button();
        lDYo = new Button();
        qDYt = new Button();
        jDYS = new Button();
        UDYh = new Button();
        qDYl = new PictureBox();
        CDN4 = new GroupBox();
        WDYb = new Button();
        cDYE = new Button();
        ADNz = new Button();
        TDNj = new Button();
        TDNa = new Button();
        aDNZ = new Button();
        ADNs = new Button();
        IDN5 = new PictureBox();
        iDN3 = new Button();
        qDwz = new TabPage();
        wDBO = new GroupBox();
        eD64 = new Button();
        WDBe = new Button();
        TDB8 = new Button();
        aDNq = new GroupBox();
        rDNk = new Button();
        uDNM = new Button();
        IDNu = new Button();
        WDNg = new Button();
        SDN2 = new Button();
        FDN6 = new GroupBox();
        uDNy = new Button();
        hDNr = new Button();
        ADNx = new Button();
        BDN9 = new Button();
        ADNc = new Button();
        ADNw = new GroupBox();
        zDNA = new Button();
        kDNf = new Button();
        cDNN = new Button();
        iDNY = new Button();
        nDNB = new Button();
        wDwW = new Button();
        NDNp = new TabPage();
        mDAr = new TreeView();
        IDAk = new TableLayoutPanel();
        DDAM = new Button();
        zDAu = new Button();
        TDAg = new Button();
        kDWn = new ListBox();
        OD6K = new TabPage();
        PD6r = new GroupBox();
        fD6d = new Button();
        mD63 = new Button();
        hD62 = new Button();
        zD6g = new Button();
        GD6u = new Button();
        YD6k = new ComboBox();
        eD6q = new Button();
        ID69 = new Button();
        WD6U = new GroupBox();
        DD6T = new Label();
        bD61 = new Label();
        ND6W = new Label();
        pD6w = new Button();
        qD6N = new Button();
        UD6Y = new Button();
        KD6B = new TextBox();
        hD6A = new TextBox();
        HD6f = new TextBox();
        nD66 = new Button();
        oD18 = new TabPage();
        iD1n = new TabControl();
        kD1Q = new TabPage();
        xDA0 = new GroupBox();
        bD6E = new Button();
        XDAU = new Label();
        oDAT = new Label();
        ODA1 = new Label();
        bDAW = new ComboBox();
        zDAw = new ComboBox();
        TDAN = new ComboBox();
        VDAY = new ComboBox();
        BDAB = new NumericUpDown();
        mDAI = new Button();
        MDAR = new GroupBox();
        tD6D = new Button();
        ADAA = new Label();
        hDAf = new Label();
        UDA6 = new Label();
        qDAx = new ComboBox();
        vDA9 = new ComboBox();
        RDAc = new ComboBox();
        YDAy = new ComboBox();
        bDAK = new NumericUpDown();
        jDAC = new Button();
        CDAi = new GroupBox();
        eDAm = new Button();
        HDAP = new Button();
        vDBk = new GroupBox();
        bDwq = new Button();
        xDBM = new GroupBox();
        xDNP = new Button();
        MD1F = new Label();
        oD1L = new NumericUpDown();
        vD1J = new NumericUpDown();
        hD17 = new GroupBox();
        JDwr = new CheckBox();
        pD1P = new Button();
        SD1i = new CheckBox();
        SD1m = new CheckBox();
        yD10 = new Label();
        uD1I = new ComboBox();
        tD1R = new Button();
        OD1C = new Label();
        iD1K = new ComboBox();
        FD1U = new Button();
        nD1T = new Label();
        hD11 = new TabPage();
        oD1W = new TabControl();
        hD1w = new TabPage();
        LD1N = new ListView();
        kD1Y = new TabPage();
        ND1B = new ListView();
        JD1A = new TabPage();
        bD1f = new ListView();
        aD16 = new TabPage();
        XD1x = new ListView();
        tD19 = new TabPage();
        kD1c = new ListView();
        TD1y = new TabPage();
        cD1r = new ListView();
        HD1q = new TabPage();
        BD1k = new ListView();
        eD1M = new TabPage();
        lD1u = new ListView();
        xD1g = new TabPage();
        MD12 = new ListView();
        ED13 = new TabPage();
        zD1d = new ListView();
        LD1H = new TabPage();
        gD14 = new ListView();
        aD15 = new TabPage();
        ID1s = new ListView();
        YD1Z = new TabPage();
        OD1a = new ListView();
        BD1j = new TabPage();
        hD1z = new ListView();
        tDWE = new TabPage();
        qDWD = new ListView();
        aDWX = new TabPage();
        iDWp = new ListView();
        TDBg = new TabPage();
        sDB2 = new TabControl();
        bDB3 = new TabPage();
        kDBd = new ListView();
        aDBH = new TabPage();
        dDB4 = new ListView();
        hDB5 = new TabPage();
        VDBs = new ListView();
        tDBZ = new TabPage();
        UDBa = new ListView();
        BDBj = new TabPage();
        xDBz = new ListView();
        vDAE = new TabPage();
        yDAD = new ListView();
        gDAX = new TabPage();
        GDAp = new ListView();
        mDAS = new TabPage();
        mDAh = new ListView();
        JDAl = new TabPage();
        pDAG = new ListView();
        pDAb = new TabPage();
        MDAv = new ListView();
        HDAo = new TabPage();
        MDAt = new ListView();
        MDAV = new TabPage();
        tDAO = new ListView();
        gDAe = new TabPage();
        XDA8 = new ListView();
        IDAn = new TabPage();
        JDAQ = new ListView();
        UDAF = new TabPage();
        qDAL = new ListView();
        QDAJ = new TabPage();
        NDA7 = new ListView();
        mDWS = new TabPage();
        aDWh = new TabControl();
        iDWl = new TabPage();
        QDNi = new TabControl();
        PDNm = new TabPage();
        ODNR = new FlowLayoutPanel();
        jDN0 = new TabPage();
        iDNC = new FlowLayoutPanel();
        yDNI = new TabPage();
        IDNK = new FlowLayoutPanel();
        kDNS = new TableLayoutPanel();
        rDNh = new Label();
        yDNl = new Label();
        LDNG = new Label();
        KDNb = new Label();
        tDNv = new Label();
        rDNo = new Label();
        MDNt = new Label();
        aDNV = new Label();
        IDNO = new Label();
        iDNe = new Label();
        SDN8 = new Label();
        oDNn = new Button();
        UDNQ = new Button();
        DDNF = new Button();
        LDNL = new Button();
        eDNJ = new Button();
        rDN7 = new Button();
        EDNU = new CheckBox();
        PDNT = new NumericUpDown();
        dDN1 = new NumericUpDown();
        gDNW = new NumericUpDown();
        FDWG = new TabPage();
        UDwy = new FlowLayoutPanel();
        LDww = new TableLayoutPanel();
        dDwN = new Label();
        iDwY = new Label();
        bDwB = new Label();
        RDwA = new Label();
        hDwf = new Label();
        gDw6 = new Label();
        pDwx = new CheckBox();
        UDw9 = new NumericUpDown();
        mDwc = new Button();
        LDAq = new Button();
        EDWb = new TabPage();
        MDw0 = new Button();
        rDwI = new Button();
        iDWv = new GroupBox();
        ODWo = new CheckBox();
        bDWt = new ComboBox();
        hDWV = new Label();
        DDWO = new GroupBox();
        vDWe = new Button();
        CDW8 = new Button();
        VDWQ = new Button();
        HDWF = new Button();
        FDWL = new Button();
        aDWJ = new GroupBox();
        JDW7 = new CheckBox();
        TDWP = new Label();
        zDWi = new ListView();
        PDWm = new ColumnHeader();
        CDW0 = new ColumnHeader();
        yDWI = new ColumnHeader();
        oDWR = new Button();
        DDWC = new GroupBox();
        VDWK = new CheckBox();
        NDWU = new NumericUpDown();
        JDWT = new ComboBox();
        dDW1 = new Label();
        MDWW = new Label();
        uDWw = new ComboBox();
        UDWN = new Label();
        lDWY = new ComboBox();
        QDWB = new Label();
        tDWA = new ComboBox();
        eDWf = new Label();
        oDW6 = new Label();
        sDWx = new ComboBox();
        GDW9 = new GroupBox();
        nDWc = new Button();
        UDWy = new Button();
        sDWr = new Button();
        KDWq = new GroupBox();
        LDWk = new Button();
        vDWM = new Button();
        BDWu = new Button();
        zDWg = new Button();
        JDW2 = new GroupBox();
        KDW3 = new Button();
        QDWd = new Button();
        rDWH = new GroupBox();
        vDW4 = new CheckBox();
        WDW5 = new ComboBox();
        rDWs = new ComboBox();
        yDWZ = new ComboBox();
        tDWa = new Label();
        jDWj = new Label();
        wDWz = new Label();
        nDwE = new GroupBox();
        UDwD = new NumericUpDown();
        GDwX = new CheckBox();
        UDwp = new ComboBox();
        XDwS = new Label();
        VDwh = new Label();
        sDwl = new NumericUpDown();
        tDwG = new Label();
        EDwb = new NumericUpDown();
        VDwv = new Label();
        mDwo = new NumericUpDown();
        GDwt = new TabControl();
        uDxp = new TabPage();
        fDxS = new Label();
        oDxh = new Label();
        nDxl = new GroupBox();
        pDxG = new GroupBox();
        bDxb = new GroupBox();
        yDxv = new GroupBox();
        qDxo = new GroupBox();
        ADxt = new GroupBox();
        DDxV = new GroupBox();
        GDxO = new GroupBox();
        yDxe = new Label();
        vDx8 = new GroupBox();
        nDxn = new Label();
        RDxQ = new TableLayoutPanel();
        MDxF = new TableLayoutPanel();
        JDxL = new Label();
        iD6Z = new TabPage();
        FDxX = new ListBox();
        yD6a = new Button();
        iD6j = new Button();
        JD6z = new Button();
        sDxE = new ListBox();
        VDxD = new CheckedListBox();
        nDwg = new ColumnHeader();
        pDw2 = new ColumnHeader();
        nDw3 = new ColumnHeader();
        NDwd = new ColumnHeader();
        QDwH = new ColumnHeader();
        BD6x = new ColorDialog();
        TD6c = new BackgroundWorker();
        MD6H = new ToolTip(DDUz);
        VDxJ = new PictureBox();
        sDx7 = new PictureBox();
        WDxP = new PictureBox();
        yDxi = new PictureBox();
        jDxm = new PictureBox();
        aDx0 = new PictureBox();
        pDxI = new Label();
        DDxR = new Label();
        kDxC = new Label();
        lDxK = new Label();
        ADxU = new Label();
        CDxT = new Label();
        HDx1 = new Label();
        KDxW = new Label();
        rDxw = new Label();
        TDxN = new PictureBox();
        PDxY = new PictureBox();
        zDxB = new PictureBox();
        pDxA = new PictureBox();
        JDxf = new PictureBox();
        KDx6 = new PictureBox();
        LDxx = new PictureBox();
        UDx9 = new PictureBox();
        DDxc = new PictureBox();
        IDxy = new PictureBox();
        DDxr = new Label();
        PDxq = new Label();
        GDxk = new PictureBox();
        MDxM = new PictureBox();
        jDxu = new PictureBox();
        DDxg = new PictureBox();
        ADx2 = new Label();
        uDx3 = new Label();
        dDxd = new Label();
        gDxH = new Label();
        JDx4 = new Label();
        jDx5 = new Label();
        DDxs = new Label();
        CDxZ = new PictureBox();
        BDxa = new PictureBox();
        iDxj = new PictureBox();
        YDxz = new PictureBox();
        wD9E = new PictureBox();
        fD9D = new PictureBox();
        uD9X = new PictureBox();
        DD9p = new PictureBox();
        RD9S = new PictureBox();
        LD9h = new PictureBox();
        LD9l = new PictureBox();
        cD9G = new PictureBox();
        xD9b = new GroupBox();
        SD9v = new Label();
        JD9o = new Label();
        wD9t = new Label();
        GD9V = new Button();
        gD9O = new Button();
        kD9e = new GroupBox();
        qD98 = new Label();
        ND9n = new Label();
        CD9Q = new Label();
        KD9F = new Label();
        vD9L = new GroupBox();
        lD9J = new Label();
        TD97 = new Label();
        KD9P = new Label();
        QD9i = new Label();
        AD9m = new Label();
        HD90 = new Label();
        hD9I = new Label();
        zD9R = new Label();
        jD9C = new Label();
        gD9K = new Label();
        SD9U = new GroupBox();
        OD9T = new Label();
        lD91 = new Label();
        OD9W = new Label();
        XD9w = new Label();
        gD9N = new Label();
        JD9Y = new Label();
        eD9B = new TableLayoutPanel();
        wD9A = new CheckBox();
        rD9f = new CheckBox();
        dD96 = new CheckBox();
        ED9x = new CheckBox();
        rD99 = new CheckBox();
        MD9c = new CheckBox();
        wD9y = new CheckBox();
        yD9r = new Label();
        xD9q = new Label();
        YD9k = new CheckBox();
        cD9M = new Label();
        KD9u = new CheckBox();
        hD9g = new Label();
        RD92 = new Label();
        SD93 = new Label();
        fD9d = new Label();
        PD9H = new CheckBox();
        tD94 = new Label();
        CD95 = new Label();
        vD9s = new Label();
        tD9Z = new CheckBox();
        PD9a = new Label();
        DD9j = new Label();
        BD9z = new CheckBox();
        NDcE = new Label();
        TDcD = new Label();
        xDcX = new Label();
        VDcp = new Label();
        MDcS = new Label();
        iDch = new Label();
        XDcl = new TableLayoutPanel();
        dDcG = new CheckBox();
        yDcb = new CheckBox();
        cDcv = new CheckBox();
        jDco = new CheckBox();
        sDct = new CheckBox();
        vDcV = new CheckBox();
        IDcO = new CheckBox();
        JDce = new Label();
        UDc8 = new Label();
        aDcn = new CheckBox();
        bDcQ = new Label();
        ADcF = new CheckBox();
        mDcL = new Label();
        nDcJ = new Label();
        GDc7 = new Label();
        QDcP = new Label();
        WDci = new CheckBox();
        qDcm = new Label();
        BDc0 = new Label();
        sDcI = new Label();
        lDcR = new CheckBox();
        gDcC = new Label();
        WDcK = new Label();
        RDcU = new CheckBox();
        vDcT = new Label();
        WDc1 = new Label();
        ODcW = new Label();
        PDcw = new Label();
        yDcN = new Label();
        cDcY = new Label();
        BDcB = new TableLayoutPanel();
        SDcA = new CheckBox();
        iDcf = new CheckBox();
        HDc6 = new CheckBox();
        gDcx = new CheckBox();
        TDc9 = new CheckBox();
        RDcc = new CheckBox();
        YDcy = new CheckBox();
        zDcr = new Label();
        zDcq = new Label();
        zDck = new CheckBox();
        EDcM = new Label();
        cDcu = new CheckBox();
        sDcg = new Label();
        XDc2 = new Label();
        KDc3 = new Label();
        fDcd = new Label();
        CDcH = new CheckBox();
        WDc4 = new Label();
        mDc5 = new Label();
        sDcs = new Label();
        bDcZ = new CheckBox();
        qDca = new Label();
        WDcj = new Label();
        jDcz = new CheckBox();
        WDyE = new Label();
        YDyD = new Label();
        QDyX = new Label();
        PDyp = new Label();
        LDyS = new Label();
        WDyh = new Label();
        PDyl = new TableLayoutPanel();
        bDyG = new CheckBox();
        sDyb = new CheckBox();
        XDyv = new CheckBox();
        ODyo = new CheckBox();
        EDyt = new CheckBox();
        eDyV = new CheckBox();
        JDyO = new CheckBox();
        DDye = new Label();
        WDy8 = new Label();
        BDyn = new CheckBox();
        LDyQ = new Label();
        UDyF = new CheckBox();
        qDyL = new Label();
        fDyJ = new Label();
        MDy7 = new Label();
        NDyP = new Label();
        KDyi = new CheckBox();
        iDym = new Label();
        jDy0 = new Label();
        MDyI = new Label();
        NDyR = new CheckBox();
        QDyC = new Label();
        vDyK = new Label();
        ODyU = new CheckBox();
        xDyT = new Label();
        aDy1 = new Label();
        BDyW = new Label();
        IDyw = new Label();
        NDyN = new Label();
        uDyY = new Label();
        PDyB = new TableLayoutPanel();
        NDyA = new CheckBox();
        dDyf = new CheckBox();
        ADy6 = new CheckBox();
        YDyx = new CheckBox();
        IDy9 = new CheckBox();
        GDyc = new CheckBox();
        hDyy = new CheckBox();
        KDyr = new Label();
        FDyq = new Label();
        RDyk = new CheckBox();
        VDyM = new Label();
        oDyu = new CheckBox();
        JDyg = new Label();
        VDy2 = new Label();
        IDy3 = new Label();
        eDyd = new Label();
        EDyH = new CheckBox();
        VDy4 = new Label();
        RDy5 = new Label();
        xDys = new Label();
        cDyZ = new CheckBox();
        zDya = new Label();
        NDyj = new Label();
        gDyz = new CheckBox();
        VDrE = new Label();
        hDrD = new Label();
        UDrX = new Label();
        xDrp = new Label();
        SDrS = new Label();
        MDrh = new Label();
        uDrl = new TableLayoutPanel();
        DDrG = new CheckBox();
        GDrb = new CheckBox();
        CDrv = new CheckBox();
        hDro = new CheckBox();
        pDrt = new CheckBox();
        QDrV = new CheckBox();
        cDrO = new CheckBox();
        NDre = new Label();
        hDr8 = new Label();
        cDrn = new CheckBox();
        iDrQ = new Label();
        oDrF = new CheckBox();
        zDrL = new Label();
        SDrJ = new Label();
        IDr7 = new Label();
        yDrP = new Label();
        bDri = new CheckBox();
        lDrm = new Label();
        XDr0 = new Label();
        YDrI = new Label();
        qDrR = new CheckBox();
        dDrC = new Label();
        EDrK = new Label();
        mDrU = new CheckBox();
        eDrT = new Label();
        NDr1 = new Label();
        KDrW = new Label();
        zDrw = new Label();
        iDrN = new Label();
        mDrY = new Label();
        bDrB = new TableLayoutPanel();
        vDrA = new CheckBox();
        BDrf = new CheckBox();
        PDr6 = new CheckBox();
        GDrx = new CheckBox();
        vDr9 = new CheckBox();
        RDrc = new CheckBox();
        nDry = new CheckBox();
        SDrr = new Label();
        jDrq = new Label();
        DDrk = new CheckBox();
        WDrM = new Label();
        kDru = new CheckBox();
        GDrg = new Label();
        kDr2 = new Label();
        LDr3 = new Label();
        vDrd = new Label();
        uDrH = new CheckBox();
        mDr4 = new Label();
        mDr5 = new Label();
        XDrs = new Label();
        ODrZ = new CheckBox();
        UDra = new Label();
        uDrj = new Label();
        VDrz = new CheckBox();
        BDqE = new Label();
        RDqD = new Label();
        NDqX = new Label();
        NDqp = new Label();
        iDqS = new Label();
        pDqh = new Label();
        dDql = new TableLayoutPanel();
        aDqG = new CheckBox();
        PDqb = new CheckBox();
        WDqv = new CheckBox();
        CDqo = new CheckBox();
        UDqt = new CheckBox();
        VDqV = new CheckBox();
        YDqO = new CheckBox();
        NDqe = new Label();
        CDq8 = new Label();
        bDqn = new CheckBox();
        aDqQ = new Label();
        XDqF = new CheckBox();
        eDqL = new Label();
        oDqJ = new Label();
        eDq7 = new Label();
        ADqP = new Label();
        pDqi = new CheckBox();
        wDqm = new Label();
        aDq0 = new Label();
        tDqI = new Label();
        YDqR = new CheckBox();
        fDqC = new Label();
        jDqK = new Label();
        kDqU = new CheckBox();
        pDqT = new Label();
        ODq1 = new Label();
        tDqW = new Label();
        QDqw = new Label();
        YDTX.SuspendLayout();
        RDTO.SuspendLayout();
        yDTi.SuspendLayout();
        cDTU.SuspendLayout();
        qDTw.SuspendLayout();
        YDTN.SuspendLayout();
        jDTB.SuspendLayout();
        MDTA.SuspendLayout();
        wDT9.SuspendLayout();
        QDTc.SuspendLayout();
        NDTr.SuspendLayout();
        BDTk.SuspendLayout();
        oDBR.SuspendLayout();
        IDBC.SuspendLayout();
        tDBY.SuspendLayout();
        kDwP.SuspendLayout();
        lDwV.SuspendLayout();
        YDTM.SuspendLayout();
        xDTd.SuspendLayout();
        lD1E.SuspendLayout();
        LDA2.SuspendLayout();
        pDA3.SuspendLayout();
        DDAd.SuspendLayout();
        JDfv.SuspendLayout();
        cDfO.SuspendLayout();
        TDAZ.SuspendLayout();
        CD6L.SuspendLayout();
        AD6J.SuspendLayout();
        uD6Q.SuspendLayout();
        kD6n.SuspendLayout();
        GD68.SuspendLayout();
        PD6e.SuspendLayout();
        GD6O.SuspendLayout();
        zD6V.SuspendLayout();
        mDw1.SuspendLayout();
        rDwk.SuspendLayout();
        TDwM.SuspendLayout();
        fDfY.SuspendLayout();
        qDfr.SuspendLayout();
        vDw4.SuspendLayout();
        oDwu.SuspendLayout();
        LDBt.SuspendLayout();
        LDBh.SuspendLayout();
        IDBD.SuspendLayout();
        TDYa.SuspendLayout();
        hDNd.SuspendLayout();
        eDwj.SuspendLayout();
        qDY5.SuspendLayout();
        ((ISupportInitialize)LDYZ).BeginInit();
        dDY3.SuspendLayout();
        ((ISupportInitialize)xDY4).BeginInit();
        qDYT.SuspendLayout();
        ((ISupportInitialize)GDY1).BeginInit();
        gDY0.SuspendLayout();
        ((ISupportInitialize)kDYK).BeginInit();
        QDY7.SuspendLayout();
        ((ISupportInitialize)HDYi).BeginInit();
        EDYV.SuspendLayout();
        ((ISupportInitialize)SDYe).BeginInit();
        FDYD.SuspendLayout();
        ((ISupportInitialize)qDYl).BeginInit();
        CDN4.SuspendLayout();
        ((ISupportInitialize)IDN5).BeginInit();
        qDwz.SuspendLayout();
        wDBO.SuspendLayout();
        aDNq.SuspendLayout();
        FDN6.SuspendLayout();
        ADNw.SuspendLayout();
        NDNp.SuspendLayout();
        IDAk.SuspendLayout();
        OD6K.SuspendLayout();
        PD6r.SuspendLayout();
        WD6U.SuspendLayout();
        oD18.SuspendLayout();
        iD1n.SuspendLayout();
        kD1Q.SuspendLayout();
        xDA0.SuspendLayout();
        ((ISupportInitialize)BDAB).BeginInit();
        MDAR.SuspendLayout();
        ((ISupportInitialize)bDAK).BeginInit();
        CDAi.SuspendLayout();
        vDBk.SuspendLayout();
        xDBM.SuspendLayout();
        ((ISupportInitialize)oD1L).BeginInit();
        ((ISupportInitialize)vD1J).BeginInit();
        hD17.SuspendLayout();
        hD11.SuspendLayout();
        oD1W.SuspendLayout();
        hD1w.SuspendLayout();
        kD1Y.SuspendLayout();
        JD1A.SuspendLayout();
        aD16.SuspendLayout();
        tD19.SuspendLayout();
        TD1y.SuspendLayout();
        HD1q.SuspendLayout();
        eD1M.SuspendLayout();
        xD1g.SuspendLayout();
        ED13.SuspendLayout();
        LD1H.SuspendLayout();
        aD15.SuspendLayout();
        YD1Z.SuspendLayout();
        BD1j.SuspendLayout();
        tDWE.SuspendLayout();
        aDWX.SuspendLayout();
        TDBg.SuspendLayout();
        sDB2.SuspendLayout();
        bDB3.SuspendLayout();
        aDBH.SuspendLayout();
        hDB5.SuspendLayout();
        tDBZ.SuspendLayout();
        BDBj.SuspendLayout();
        vDAE.SuspendLayout();
        gDAX.SuspendLayout();
        mDAS.SuspendLayout();
        JDAl.SuspendLayout();
        pDAb.SuspendLayout();
        HDAo.SuspendLayout();
        MDAV.SuspendLayout();
        gDAe.SuspendLayout();
        IDAn.SuspendLayout();
        UDAF.SuspendLayout();
        QDAJ.SuspendLayout();
        mDWS.SuspendLayout();
        aDWh.SuspendLayout();
        iDWl.SuspendLayout();
        QDNi.SuspendLayout();
        PDNm.SuspendLayout();
        jDN0.SuspendLayout();
        yDNI.SuspendLayout();
        kDNS.SuspendLayout();
        ((ISupportInitialize)PDNT).BeginInit();
        ((ISupportInitialize)dDN1).BeginInit();
        ((ISupportInitialize)gDNW).BeginInit();
        FDWG.SuspendLayout();
        LDww.SuspendLayout();
        ((ISupportInitialize)UDw9).BeginInit();
        EDWb.SuspendLayout();
        iDWv.SuspendLayout();
        DDWO.SuspendLayout();
        aDWJ.SuspendLayout();
        DDWC.SuspendLayout();
        ((ISupportInitialize)NDWU).BeginInit();
        GDW9.SuspendLayout();
        KDWq.SuspendLayout();
        JDW2.SuspendLayout();
        rDWH.SuspendLayout();
        nDwE.SuspendLayout();
        ((ISupportInitialize)UDwD).BeginInit();
        ((ISupportInitialize)sDwl).BeginInit();
        ((ISupportInitialize)EDwb).BeginInit();
        ((ISupportInitialize)mDwo).BeginInit();
        GDwt.SuspendLayout();
        uDxp.SuspendLayout();
        iD6Z.SuspendLayout();
        ((ISupportInitialize)VDxJ).BeginInit();
        ((ISupportInitialize)sDx7).BeginInit();
        ((ISupportInitialize)WDxP).BeginInit();
        ((ISupportInitialize)yDxi).BeginInit();
        ((ISupportInitialize)jDxm).BeginInit();
        ((ISupportInitialize)aDx0).BeginInit();
        ((ISupportInitialize)TDxN).BeginInit();
        ((ISupportInitialize)PDxY).BeginInit();
        ((ISupportInitialize)zDxB).BeginInit();
        ((ISupportInitialize)pDxA).BeginInit();
        ((ISupportInitialize)JDxf).BeginInit();
        ((ISupportInitialize)KDx6).BeginInit();
        ((ISupportInitialize)LDxx).BeginInit();
        ((ISupportInitialize)UDx9).BeginInit();
        ((ISupportInitialize)DDxc).BeginInit();
        ((ISupportInitialize)IDxy).BeginInit();
        ((ISupportInitialize)GDxk).BeginInit();
        ((ISupportInitialize)MDxM).BeginInit();
        ((ISupportInitialize)jDxu).BeginInit();
        ((ISupportInitialize)DDxg).BeginInit();
        ((ISupportInitialize)CDxZ).BeginInit();
        ((ISupportInitialize)BDxa).BeginInit();
        ((ISupportInitialize)iDxj).BeginInit();
        ((ISupportInitialize)YDxz).BeginInit();
        ((ISupportInitialize)wD9E).BeginInit();
        ((ISupportInitialize)fD9D).BeginInit();
        ((ISupportInitialize)uD9X).BeginInit();
        ((ISupportInitialize)DD9p).BeginInit();
        ((ISupportInitialize)RD9S).BeginInit();
        ((ISupportInitialize)LD9h).BeginInit();
        ((ISupportInitialize)LD9l).BeginInit();
        ((ISupportInitialize)cD9G).BeginInit();
        SuspendLayout();
        fDTE.AutoSize = true;
        fDTE.Location = new Point(Class13.yXQR, Class13.yXQC);
        fDTE.Name = Class13.SXQK;
        fDTE.Size = new Size(Class13.YXQU, Class13.YXQT);
        fDTE.TabIndex = Class13.aXQ1;
        fDTE.Text = Class13.yXQW;
        QDTD.AutoSize = true;
        QDTD.Location = new Point(Class13.DXQw, Class13.sXQN);
        QDTD.Name = Class13.PXQY;
        QDTD.Size = new Size(Class13.sXQB, Class13.fXQA);
        QDTD.TabIndex = Class13.dXQf;
        QDTD.Text = Class13.KXQ6;
        YDTX.Controls.Add(CDTp);
        YDTX.Controls.Add(bDTS);
        YDTX.Controls.Add(CDTh);
        YDTX.Controls.Add(rDTl);
        YDTX.Controls.Add(IDTG);
        YDTX.Controls.Add(pDTb);
        YDTX.Controls.Add(GDTv);
        YDTX.Controls.Add(NDTo);
        YDTX.Controls.Add(KDTt);
        YDTX.Controls.Add(YDTV);
        YDTX.Enabled = false;
        YDTX.Location = new Point(Class13.cXQx, Class13.aXQ9);
        YDTX.Name = Class13.iXQc;
        YDTX.Size = new Size(Class13.CXQy, Class13.mXQr);
        YDTX.TabIndex = Class13.fXQq;
        YDTX.TabStop = false;
        YDTX.Text = Class13.YXQk;
        CDTp.AutoSize = true;
        CDTp.Location = new Point(Class13.SXQM, Class13.KXQu);
        CDTp.Name = Class13.oXQg;
        CDTp.Size = new Size(Class13.rXQ2, Class13.gXQ3);
        CDTp.TabIndex = Class13.dXQd;
        CDTp.TabStop = true;
        CDTp.Text = Class13.dXQH;
        CDTp.UseVisualStyleBackColor = true;
        bDTS.Location = new Point(Class13.WXQ4, Class13.pXQ5);
        bDTS.Name = Class13.wXQs;
        bDTS.Size = new Size(Class13.pXQZ, Class13.CXQa);
        bDTS.TabIndex = 8;
        CDTh.AutoSize = true;
        CDTh.Location = new Point(Class13.VXQj, Class13.oXQz);
        CDTh.Name = Class13.fXFE;
        CDTh.Size = new Size(Class13.GXFD, Class13.OXFX);
        CDTh.TabIndex = 7;
        CDTh.TabStop = true;
        CDTh.Text = Class13.iXFp;
        CDTh.UseVisualStyleBackColor = true;
        rDTl.AutoSize = true;
        rDTl.Location = new Point(Class13.NXFS, Class13.hXFh);
        rDTl.Name = Class13.AXFl;
        rDTl.Size = new Size(Class13.nXFG, Class13.kXFb);
        rDTl.TabIndex = 6;
        rDTl.TabStop = true;
        rDTl.Text = Class13.JXFv;
        rDTl.UseVisualStyleBackColor = true;
        IDTG.AutoSize = true;
        IDTG.Checked = true;
        IDTG.Location = new Point(Class13.eXFo, Class13.rXFt);
        IDTG.Name = Class13.JXFV;
        IDTG.Size = new Size(Class13.AXFO, Class13.YXFe);
        IDTG.TabIndex = 5;
        IDTG.TabStop = true;
        IDTG.Text = Class13.YXF8;
        IDTG.UseVisualStyleBackColor = true;
        pDTb.AutoSize = true;
        pDTb.Location = new Point(Class13.xXFn, Class13.aXFQ);
        pDTb.Name = Class13.nXFF;
        pDTb.Size = new Size(Class13.dXFL, Class13.wXFJ);
        pDTb.TabIndex = 4;
        pDTb.Text = Class13.tXF7;
        GDTv.Location = new Point(Class13.UXFP, Class13.UXFi);
        GDTv.Name = Class13.uXFm;
        GDTv.Size = new Size(Class13.DXF0, Class13.sXFI);
        GDTv.TabIndex = 3;
        GDTv.Text = Class13.pXFR;
        GDTv.UseVisualStyleBackColor = true;
        GDTv.Click += ND0v;
        NDTo.Location = new Point(Class13.fXFC, Class13.DXFK);
        NDTo.Name = Class13.tXFU;
        NDTo.Size = new Size(Class13.BXFT, Class13.sXF1);
        NDTo.TabIndex = 2;
        NDTo.Text = Class13.kXFW;
        NDTo.UseVisualStyleBackColor = true;
        NDTo.Click += yD0G;
        KDTt.Location = new Point(Class13.sXFw, Class13.cXFN);
        KDTt.Name = Class13.KXFY;
        KDTt.Size = new Size(Class13.zXFB, Class13.TXFA);
        KDTt.TabIndex = 1;
        KDTt.Text = Class13.uXFf;
        KDTt.UseVisualStyleBackColor = true;
        KDTt.Click += TD0b;
        YDTV.Location = new Point(Class13.kXF6, Class13.zXFx);
        YDTV.Name = Class13.JXF9;
        YDTV.Size = new Size(Class13.wXFc, Class13.iXFy);
        YDTV.TabIndex = 0;
        YDTV.Text = Class13.bXFr;
        YDTV.UseVisualStyleBackColor = true;
        YDTV.Click += TD0h;
        RDTO.Controls.Add(CD6y);
        RDTO.Controls.Add(hDTe);
        RDTO.Controls.Add(wDT8);
        RDTO.Controls.Add(IDTn);
        RDTO.Controls.Add(EDTQ);
        RDTO.Controls.Add(lDTF);
        RDTO.Controls.Add(cDTL);
        RDTO.Controls.Add(HDTJ);
        RDTO.Controls.Add(uDT7);
        RDTO.Controls.Add(fDTP);
        RDTO.Enabled = false;
        RDTO.Location = new Point(8, Class13.sXFq);
        RDTO.Name = Class13.eXFk;
        RDTO.Size = new Size(Class13.VXFM, Class13.tXFu);
        RDTO.TabIndex = Class13.zXFg;
        RDTO.TabStop = false;
        CD6y.Location = new Point(Class13.vXF2, Class13.lXF3);
        CD6y.Name = Class13.DXFd;
        CD6y.Size = new Size(Class13.nXFH, Class13.QXF4);
        CD6y.TabIndex = Class13.xXF5;
        CD6y.Text = Class13.kXFs;
        CD6y.UseVisualStyleBackColor = true;
        CD6y.Click += qDUP;
        hDTe.AutoSize = true;
        hDTe.Location = new Point(Class13.XXFZ, Class13.wXFa);
        hDTe.Name = Class13.iXFj;
        hDTe.Size = new Size(Class13.xXFz, Class13.BXLE);
        hDTe.TabIndex = Class13.QXLD;
        hDTe.Text = Class13.TXLX;
        wDT8.Location = new Point(Class13.rXLp, Class13.QXLS);
        wDT8.Name = Class13.aXLh;
        wDT8.Size = new Size(Class13.mXLl, Class13.uXLG);
        wDT8.TabIndex = Class13.mXLb;
        IDTn.AutoSize = true;
        IDTn.Location = new Point(Class13.oXLv, Class13.jXLo);
        IDTn.Name = Class13.qXLt;
        IDTn.Size = new Size(Class13.aXLV, Class13.IXLO);
        IDTn.TabIndex = Class13.DXLe;
        IDTn.Text = Class13.NXL8;
        EDTQ.Location = new Point(Class13.EXLn, Class13.SXLQ);
        EDTQ.Name = Class13.qXLF;
        EDTQ.Size = new Size(Class13.uXLL, Class13.EXLJ);
        EDTQ.TabIndex = Class13.qXL7;
        EDTQ.Text = Class13.xXLP;
        EDTQ.UseVisualStyleBackColor = true;
        EDTQ.Click += nD0D;
        lDTF.AutoSize = true;
        lDTF.Location = new Point(Class13.FXLi, 8);
        lDTF.Name = Class13.TXLm;
        lDTF.Size = new Size(Class13.XXL0, Class13.fXLI);
        lDTF.TabIndex = Class13.VXLR;
        lDTF.Text = Class13.BXLC;
        cDTL.Location = new Point(Class13.XXLK, Class13.tXLU);
        cDTL.Name = Class13.jXLT;
        cDTL.Size = new Size(Class13.dXL1, Class13.fXLW);
        cDTL.TabIndex = Class13.rXLw;
        cDTL.Text = Class13.yXLN;
        cDTL.UseVisualStyleBackColor = true;
        cDTL.Click += CD0E;
        HDTJ.AutoSize = true;
        HDTJ.Location = new Point(Class13.VXLY, Class13.jXLB);
        HDTJ.Name = Class13.vXLA;
        HDTJ.Size = new Size(Class13.YXLf, Class13.GXL6);
        HDTJ.TabIndex = Class13.yXLx;
        HDTJ.Text = Class13.bXL9;
        uDT7.Location = new Point(6, Class13.aXLc);
        uDT7.Name = Class13.yXLy;
        uDT7.Size = new Size(Class13.qXLr, Class13.kXLq);
        uDT7.TabIndex = Class13.XXLk;
        fDTP.Location = new Point(6, Class13.RXLM);
        fDTP.Name = Class13.DXLu;
        fDTP.Size = new Size(Class13.OXLg, Class13.MXL2);
        fDTP.TabIndex = Class13.SXL3;
        yDTi.Controls.Add(LDTT);
        yDTi.Controls.Add(VDTm);
        yDTi.Controls.Add(MDT0);
        yDTi.Controls.Add(nDTI);
        yDTi.Enabled = false;
        yDTi.Location = new Point(Class13.iXLd, Class13.nXLH);
        yDTi.Name = Class13.HXL4;
        yDTi.Size = new Size(Class13.aXL5, Class13.VXLs);
        yDTi.TabIndex = Class13.KXLZ;
        yDTi.TabStop = false;
        yDTi.Text = Class13.FXLa;
        LDTT.Location = new Point(Class13.IXLj, Class13.kXLz);
        LDTT.Name = Class13.JXJE;
        LDTT.Size = new Size(Class13.tXJD, Class13.NXJX);
        LDTT.TabIndex = 3;
        LDTT.Text = Class13.AXJp;
        LDTT.UseVisualStyleBackColor = true;
        LDTT.Click += RD0p;
        VDTm.Location = new Point(Class13.vXJS, Class13.kXJh);
        VDTm.Name = Class13.bXJl;
        VDTm.Size = new Size(Class13.QXJG, Class13.vXJb);
        VDTm.TabIndex = 2;
        VDTm.Text = Class13.cXJv;
        VDTm.UseVisualStyleBackColor = true;
        VDTm.Click += PD0S;
        MDT0.Location = new Point(Class13.SXJo, Class13.dXJt);
        MDT0.Name = Class13.rXJV;
        MDT0.Size = new Size(Class13.pXJO, Class13.VXJe);
        MDT0.TabIndex = 1;
        MDT0.Text = Class13.SXJ8;
        MDT0.UseVisualStyleBackColor = true;
        MDT0.Click += wD0X;
        nDTI.FormattingEnabled = true;
        nDTI.Location = new Point(Class13.LXJn, Class13.WXJQ);
        nDTI.Name = Class13.bXJF;
        nDTI.Size = new Size(Class13.mXJL, Class13.lXJJ);
        nDTI.TabIndex = 0;
        wDTR.Location = new Point(8, Class13.DXJ7);
        wDTR.Name = Class13.eXJP;
        wDTR.Size = new Size(Class13.sXJi, Class13.YXJm);
        wDTR.TabIndex = Class13.QXJ0;
        sDTC.Enabled = false;
        sDTC.Location = new Point(Class13.NXJI, Class13.mXJR);
        sDTC.Name = Class13.wXJC;
        sDTC.Size = new Size(Class13.OXJK, Class13.jXJU);
        sDTC.TabIndex = Class13.FXJT;
        sDTC.Text = Class13.mXJ1;
        sDTC.UseVisualStyleBackColor = true;
        sDTC.Click += aDmz;
        QDTK.BackgroundImageLayout = ImageLayout.Center;
        QDTK.FlatStyle = FlatStyle.System;
        QDTK.Location = new Point(Class13.eXJW, Class13.OXJw);
        QDTK.Name = Class13.IXJN;
        QDTK.Size = new Size(Class13.lXJY, Class13.cXJB);
        QDTK.TabIndex = Class13.gXJA;
        QDTK.Text = Class13.dXJf;
        QDTK.UseVisualStyleBackColor = true;
        cDTU.Items.AddRange(new ToolStripItem[1] { LD6M });
        cDTU.Location = new Point(0, 0);
        cDTU.Name = Class13.hXJ6;
        cDTU.Size = new Size(Class13.QXJx, Class13.wXJ9);
        cDTU.TabIndex = Class13.RXJc;
        cDTU.Text = Class13.AXJy;
        LD6M.Name = Class13.eXJr;
        LD6M.Size = new Size(Class13.sXJq, Class13.kXJk);
        LD6M.Text = Class13.EXJM;
        LD6M.Click += TDU0;
        QDT1.Location = new Point(Class13.wXJu, Class13.NXJg);
        QDT1.MaxLength = Class13.aXJ2;
        QDT1.Name = Class13.yXJ3;
        QDT1.Size = new Size(Class13.GXJd, Class13.vXJH);
        QDT1.TabIndex = Class13.nXJ4;
        KDTW.Location = new Point(Class13.aXJ5, Class13.rXJs);
        KDTW.Name = Class13.wXJZ;
        KDTW.Size = new Size(Class13.gXJa, Class13.CXJj);
        KDTW.TabIndex = Class13.TXJz;
        KDTW.Text = Class13.PX7E;
        KDTW.UseVisualStyleBackColor = true;
        KDTW.Click += pD0t;
        qDTw.Controls.Add(QDT1);
        qDTw.Controls.Add(KDTW);
        qDTw.Location = new Point(Class13.kX7D, Class13.MX7X);
        qDTw.Name = Class13.YX7p;
        qDTw.Size = new Size(Class13.XX7S, Class13.uX7h);
        qDTw.TabIndex = Class13.RX7l;
        qDTw.TabStop = false;
        qDTw.Text = Class13.bX7G;
        YDTN.Items.AddRange(new ToolStripItem[3] { SDTY, NDf2, ADf3 });
        YDTN.Location = new Point(0, Class13.TX7b);
        YDTN.Name = Class13.vX7v;
        YDTN.Size = new Size(Class13.fX7o, Class13.HX7t);
        YDTN.TabIndex = Class13.DX7V;
        YDTN.Text = Class13.EX7O;
        SDTY.Name = Class13.pX7e;
        SDTY.Size = new Size(Class13.KX78, Class13.AX7n);
        SDTY.Text = Class13.WX7Q;
        NDf2.Alignment = ToolStripItemAlignment.Right;
        NDf2.Name = Class13.dX7F;
        NDf2.Size = new Size(Class13.gX7L, Class13.GX7J);
        ADf3.Name = Class13.OX77;
        ADf3.Size = new Size(Class13.hX7P, Class13.LX7i);
        ADf3.Text = Class13.eX7m;
        ADf3.TextAlign = (ContentAlignment)Class13.fX70;
        jDTB.Controls.Add(MDTA);
        jDTB.Controls.Add(wDT9);
        jDTB.Location = new Point(4, Class13.nX7I);
        jDTB.Name = Class13.OX7R;
        jDTB.Padding = new Padding(3);
        jDTB.Size = new Size(Class13.iX7C, Class13.TX7K);
        jDTB.TabIndex = 2;
        jDTB.Text = Class13.nX7U;
        jDTB.UseVisualStyleBackColor = true;
        MDTA.ColumnCount = 4;
        MDTA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Class13.IX7T));
        MDTA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Class13.VX71));
        MDTA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Class13.YX7W));
        MDTA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Class13.yX7w));
        MDTA.Controls.Add(iDTf, 0, 0);
        MDTA.Controls.Add(KDT6, 1, 0);
        MDTA.Controls.Add(rDTx, 2, 0);
        MDTA.Controls.Add(PD6t, 3, 0);
        MDTA.Dock = DockStyle.Bottom;
        MDTA.Location = new Point(3, Class13.mX7N);
        MDTA.Name = Class13.dX7Y;
        MDTA.RowCount = 1;
        MDTA.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.JX7B));
        MDTA.Size = new Size(Class13.OX7A, Class13.MX7f);
        MDTA.TabIndex = 2;
        iDTf.Dock = DockStyle.Fill;
        iDTf.Location = new Point(3, 3);
        iDTf.Name = Class13.mX76;
        iDTf.Size = new Size(Class13.mX7x, Class13.CX79);
        iDTf.TabIndex = 1;
        iDTf.Text = Class13.iX7c;
        iDTf.UseVisualStyleBackColor = true;
        iDTf.Click += bD0W;
        KDT6.Dock = DockStyle.Fill;
        KDT6.Location = new Point(Class13.eX7y, 3);
        KDT6.Name = Class13.eX7r;
        KDT6.Size = new Size(Class13.RX7q, Class13.HX7k);
        KDT6.TabIndex = 2;
        KDT6.Text = Class13.jX7M;
        KDT6.UseVisualStyleBackColor = true;
        KDT6.Click += SD0T;
        rDTx.Dock = DockStyle.Fill;
        rDTx.Location = new Point(Class13.kX7u, 3);
        rDTx.Name = Class13.iX7g;
        rDTx.Size = new Size(Class13.OX72, Class13.LX73);
        rDTx.TabIndex = 3;
        rDTx.Text = Class13.mX7d;
        rDTx.UseVisualStyleBackColor = true;
        rDTx.Click += YD0w;
        PD6t.Location = new Point(Class13.iX7H, 3);
        PD6t.Name = Class13.fX74;
        PD6t.Size = new Size(Class13.LX75, Class13.zX7s);
        PD6t.TabIndex = 4;
        PD6t.Text = Class13.GX7Z;
        PD6t.UseVisualStyleBackColor = true;
        wDT9.Controls.Add(QDTc);
        wDT9.Controls.Add(NDTr);
        wDT9.Controls.Add(BDTk);
        wDT9.Controls.Add(LDA2);
        wDT9.Controls.Add(mDw1);
        wDT9.Controls.Add(NDNp);
        wDT9.Controls.Add(OD6K);
        wDT9.Location = new Point(Class13.CX7a, 0);
        wDT9.Name = Class13.DX7j;
        wDT9.SelectedIndex = 0;
        wDT9.Size = new Size(Class13.gX7z, Class13.jXPE);
        wDT9.TabIndex = 0;
        QDTc.Controls.Add(rDTy);
        QDTc.Location = new Point(4, Class13.LXPD);
        QDTc.Name = Class13.KXPX;
        QDTc.Padding = new Padding(3);
        QDTc.Size = new Size(Class13.wXPp, Class13.TXPS);
        QDTc.TabIndex = 0;
        QDTc.Text = Class13.wXPh;
        QDTc.UseVisualStyleBackColor = true;
        rDTy.Dock = DockStyle.Fill;
        rDTy.FormattingEnabled = true;
        rDTy.Location = new Point(3, 3);
        rDTy.Name = Class13.oXPl;
        rDTy.Size = new Size(Class13.zXPG, Class13.DXPb);
        rDTy.TabIndex = 0;
        NDTr.Controls.Add(EDTq);
        NDTr.Location = new Point(4, Class13.eXPv);
        NDTr.Name = Class13.vXPo;
        NDTr.Padding = new Padding(3);
        NDTr.Size = new Size(Class13.HXPt, Class13.sXPV);
        NDTr.TabIndex = 1;
        NDTr.Text = Class13.DXPO;
        NDTr.UseVisualStyleBackColor = true;
        EDTq.Dock = DockStyle.Fill;
        EDTq.FormattingEnabled = true;
        EDTq.Location = new Point(3, 3);
        EDTq.Name = Class13.WXPe;
        EDTq.Size = new Size(Class13.jXP8, Class13.JXPn);
        EDTq.TabIndex = 0;
        BDTk.Controls.Add(oDBR);
        BDTk.Controls.Add(IDBC);
        BDTk.Controls.Add(tDBY);
        BDTk.Controls.Add(kDwP);
        BDTk.Controls.Add(lDwV);
        BDTk.Controls.Add(YDTM);
        BDTk.Controls.Add(xDTd);
        BDTk.Controls.Add(lD1E);
        BDTk.Location = new Point(4, Class13.DXPQ);
        BDTk.Name = Class13.VXPF;
        BDTk.Padding = new Padding(3);
        BDTk.Size = new Size(Class13.XXPL, Class13.vXPJ);
        BDTk.TabIndex = 3;
        BDTk.Text = Class13.WXP7;
        BDTk.UseVisualStyleBackColor = true;
        oDBR.Controls.Add(uDBu);
        oDBR.Location = new Point(Class13.hXPP, Class13.OXPi);
        oDBR.Name = Class13.nXPm;
        oDBR.Size = new Size(Class13.SXP0, Class13.rXPI);
        oDBR.TabIndex = Class13.HXPR;
        oDBR.TabStop = false;
        oDBR.Text = Class13.fXPC;
        uDBu.Location = new Point(Class13.QXPK, Class13.EXPU);
        uDBu.Name = Class13.zXPT;
        uDBu.Size = new Size(Class13.DXP1, Class13.cXPW);
        uDBu.TabIndex = 0;
        uDBu.Text = Class13.YXPw;
        uDBu.UseVisualStyleBackColor = true;
        uDBu.Click += pDCY;
        IDBC.Controls.Add(cDBK);
        IDBC.Controls.Add(jDBU);
        IDBC.Controls.Add(IDBT);
        IDBC.Controls.Add(KDB1);
        IDBC.Controls.Add(EDBW);
        IDBC.Controls.Add(TDBw);
        IDBC.Controls.Add(zDBN);
        IDBC.Location = new Point(Class13.PXPN, Class13.sXPY);
        IDBC.Name = Class13.OXPB;
        IDBC.Size = new Size(Class13.NXPA, Class13.eXPf);
        IDBC.TabIndex = Class13.eXP6;
        IDBC.TabStop = false;
        IDBC.Text = Class13.WXPx;
        cDBK.Location = new Point(Class13.FXP9, Class13.RXPc);
        cDBK.Name = Class13.aXPy;
        cDBK.Size = new Size(Class13.pXPr, Class13.UXPq);
        cDBK.TabIndex = 6;
        cDBK.Text = Class13.JXPk;
        cDBK.UseVisualStyleBackColor = true;
        cDBK.Click += FDCw;
        jDBU.Location = new Point(Class13.QXPM, Class13.UXPu);
        jDBU.Name = Class13.lXPg;
        jDBU.Size = new Size(Class13.vXP2, Class13.xXP3);
        jDBU.TabIndex = 5;
        jDBU.Text = Class13.AXPd;
        jDBU.UseVisualStyleBackColor = true;
        jDBU.Click += nDCU;
        IDBT.Location = new Point(Class13.eXPH, Class13.jXP4);
        IDBT.Name = Class13.KXP5;
        IDBT.Size = new Size(Class13.bXPs, Class13.FXPZ);
        IDBT.TabIndex = 4;
        IDBT.Text = Class13.TXPa;
        IDBT.UseVisualStyleBackColor = true;
        IDBT.Click += ODCK;
        KDB1.Location = new Point(Class13.PXPj, Class13.KXPz);
        KDB1.Name = Class13.eXiE;
        KDB1.Size = new Size(Class13.JXiD, Class13.TXiX);
        KDB1.TabIndex = 3;
        KDB1.Text = Class13.RXip;
        KDB1.UseVisualStyleBackColor = true;
        KDB1.Click += pDCT;
        EDBW.Location = new Point(Class13.AXiS, Class13.tXih);
        EDBW.Name = Class13.RXil;
        EDBW.Size = new Size(Class13.lXiG, Class13.EXib);
        EDBW.TabIndex = 2;
        EDBW.Text = Class13.NXiv;
        EDBW.UseVisualStyleBackColor = true;
        EDBW.Click += aDCW;
        TDBw.Location = new Point(Class13.uXio, Class13.jXit);
        TDBw.Name = Class13.LXiV;
        TDBw.Size = new Size(Class13.JXiO, Class13.AXie);
        TDBw.TabIndex = 1;
        TDBw.Text = Class13.DXi8;
        TDBw.UseVisualStyleBackColor = true;
        TDBw.Click += QDC1;
        zDBN.Location = new Point(Class13.QXin, Class13.GXiQ);
        zDBN.Name = Class13.XXiF;
        zDBN.Size = new Size(Class13.HXiL, Class13.BXiJ);
        zDBN.TabIndex = 0;
        zDBN.Text = Class13.tXi7;
        zDBN.UseVisualStyleBackColor = true;
        zDBN.Click += dDCC;
        tDBY.Controls.Add(NDBB);
        tDBY.Controls.Add(PDBA);
        tDBY.Controls.Add(iDBf);
        tDBY.Controls.Add(CDB6);
        tDBY.Controls.Add(VDBx);
        tDBY.Controls.Add(lDB9);
        tDBY.Controls.Add(JDBc);
        tDBY.Controls.Add(PDBy);
        tDBY.Controls.Add(TDBr);
        tDBY.Controls.Add(iDBq);
        tDBY.Location = new Point(6, 6);
        tDBY.Name = Class13.WXiP;
        tDBY.Size = new Size(Class13.OXii, Class13.RXim);
        tDBY.TabIndex = Class13.vXi0;
        tDBY.TabStop = false;
        tDBY.Text = Class13.nXiI;
        NDBB.Location = new Point(3, Class13.EXiR);
        NDBB.Name = Class13.kXiC;
        NDBB.Size = new Size(Class13.YXiK, Class13.yXiU);
        NDBB.TabIndex = Class13.cXiT;
        NDBB.Text = Class13.nXi1;
        NDBB.UseVisualStyleBackColor = true;
        NDBB.Click += EDCu;
        PDBA.Location = new Point(3, Class13.wXiW);
        PDBA.Name = Class13.VXiw;
        PDBA.Size = new Size(Class13.CXiN, Class13.CXiY);
        PDBA.TabIndex = 8;
        PDBA.Text = Class13.JXiB;
        PDBA.UseVisualStyleBackColor = true;
        PDBA.Click += eDCM;
        iDBf.Location = new Point(3, Class13.fXiA);
        iDBf.Name = Class13.eXif;
        iDBf.Size = new Size(Class13.qXi6, Class13.QXix);
        iDBf.TabIndex = 7;
        iDBf.Text = Class13.FXi9;
        iDBf.UseVisualStyleBackColor = true;
        iDBf.Click += MDCk;
        CDB6.Location = new Point(3, Class13.nXic);
        CDB6.Name = Class13.zXiy;
        CDB6.Size = new Size(Class13.JXir, Class13.pXiq);
        CDB6.TabIndex = 6;
        CDB6.Text = Class13.XXik;
        CDB6.UseVisualStyleBackColor = true;
        CDB6.Click += XDCq;
        VDBx.Location = new Point(3, Class13.IXiM);
        VDBx.Name = Class13.sXiu;
        VDBx.Size = new Size(Class13.OXig, Class13.vXi2);
        VDBx.TabIndex = 5;
        VDBx.Text = Class13.FXi3;
        VDBx.UseVisualStyleBackColor = true;
        VDBx.Click += xDCr;
        lDB9.Location = new Point(3, Class13.lXid);
        lDB9.Name = Class13.qXiH;
        lDB9.Size = new Size(Class13.XXi4, Class13.bXi5);
        lDB9.TabIndex = 4;
        lDB9.Text = Class13.XXis;
        lDB9.UseVisualStyleBackColor = true;
        lDB9.Click += xDCy;
        JDBc.Location = new Point(3, Class13.hXiZ);
        JDBc.Name = Class13.aXia;
        JDBc.Size = new Size(Class13.vXij, Class13.UXiz);
        JDBc.TabIndex = 3;
        JDBc.Text = Class13.SXmE;
        JDBc.UseVisualStyleBackColor = true;
        JDBc.Click += VDCc;
        PDBy.Location = new Point(3, Class13.qXmD);
        PDBy.Name = Class13.YXmX;
        PDBy.Size = new Size(Class13.tXmp, Class13.TXmS);
        PDBy.TabIndex = 2;
        PDBy.Text = Class13.uXmh;
        PDBy.UseVisualStyleBackColor = true;
        PDBy.Click += sDC9;
        TDBr.Location = new Point(3, Class13.bXml);
        TDBr.Name = Class13.VXmG;
        TDBr.Size = new Size(Class13.FXmb, Class13.QXmv);
        TDBr.TabIndex = 1;
        TDBr.Text = Class13.xXmo;
        TDBr.UseVisualStyleBackColor = true;
        TDBr.Click += XDCx;
        iDBq.Location = new Point(3, Class13.YXmt);
        iDBq.Name = Class13.tXmV;
        iDBq.Size = new Size(Class13.YXmO, Class13.EXme);
        iDBq.TabIndex = 0;
        iDBq.Text = Class13.OXm8;
        iDBq.UseVisualStyleBackColor = true;
        iDBq.Click += WDC6;
        kDwP.Controls.Add(xDNX);
        kDwP.Controls.Add(XDwT);
        kDwP.Controls.Add(XDwU);
        kDwP.Controls.Add(rDwR);
        kDwP.Controls.Add(RDwC);
        kDwP.Controls.Add(FDwK);
        kDwP.Controls.Add(nDwi);
        kDwP.Controls.Add(bDwm);
        kDwP.Location = new Point(Class13.tXmn, Class13.OXmQ);
        kDwP.Name = Class13.jXmF;
        kDwP.Size = new Size(Class13.jXmL, Class13.bXmJ);
        kDwP.TabIndex = Class13.YXm7;
        kDwP.TabStop = false;
        kDwP.Text = Class13.jXmP;
        xDNX.Location = new Point(Class13.MXmi, Class13.mXmm);
        xDNX.Name = Class13.wXm0;
        xDNX.Size = new Size(Class13.vXmI, Class13.iXmR);
        xDNX.TabIndex = Class13.WXmC;
        xDNX.Text = Class13.nXmK;
        xDNX.UseVisualStyleBackColor = true;
        xDNX.Click += GDI1;
        XDwT.Location = new Point(6, Class13.yXmU);
        XDwT.Name = Class13.NXmT;
        XDwT.Size = new Size(Class13.QXm1, Class13.qXmW);
        XDwT.TabIndex = Class13.wXmw;
        XDwT.Text = Class13.TXmN;
        XDwT.UseVisualStyleBackColor = true;
        XDwT.Click += YDI8;
        XDwU.Location = new Point(Class13.gXmY, Class13.lXmB);
        XDwU.Name = Class13.hXmA;
        XDwU.Size = new Size(Class13.LXmf, Class13.TXm6);
        XDwU.TabIndex = Class13.OXmx;
        XDwU.Text = Class13.zXm9;
        XDwU.UseVisualStyleBackColor = true;
        XDwU.Click += gDIO;
        rDwR.Location = new Point(6, Class13.gXmc);
        rDwR.Name = Class13.rXmy;
        rDwR.Size = new Size(Class13.SXmr, Class13.sXmq);
        rDwR.TabIndex = Class13.yXmk;
        rDwR.Text = Class13.WXmM;
        rDwR.UseVisualStyleBackColor = true;
        rDwR.Click += zDIe;
        RDwC.Location = new Point(Class13.LXmu, Class13.NXmg);
        RDwC.Name = Class13.RXm2;
        RDwC.Size = new Size(Class13.CXm3, Class13.TXmd);
        RDwC.TabIndex = Class13.pXmH;
        RDwC.Text = Class13.VXm4;
        RDwC.UseVisualStyleBackColor = true;
        RDwC.Click += UDIV;
        FDwK.Location = new Point(6, Class13.HXm5);
        FDwK.Name = Class13.VXms;
        FDwK.Size = new Size(Class13.xXmZ, Class13.zXma);
        FDwK.TabIndex = Class13.RXmj;
        FDwK.Text = Class13.VXmz;
        FDwK.UseVisualStyleBackColor = true;
        FDwK.Click += NDIt;
        nDwi.Location = new Point(Class13.qX0E, Class13.MX0D);
        nDwi.Name = Class13.WX0X;
        nDwi.Size = new Size(Class13.MX0p, Class13.aX0S);
        nDwi.TabIndex = Class13.KX0h;
        nDwi.Text = Class13.EX0l;
        nDwi.UseVisualStyleBackColor = true;
        nDwi.Click += xDIo;
        bDwm.Location = new Point(6, Class13.TX0G);
        bDwm.Name = Class13.AX0b;
        bDwm.Size = new Size(Class13.AX0v, Class13.AX0o);
        bDwm.TabIndex = Class13.GX0t;
        bDwm.Text = Class13.HX0V;
        bDwm.UseVisualStyleBackColor = true;
        bDwm.Click += rDIv;
        lDwV.Controls.Add(ADwO);
        lDwV.Controls.Add(bDwe);
        lDwV.Controls.Add(VDw8);
        lDwV.Controls.Add(UDwn);
        lDwV.Controls.Add(KDwQ);
        lDwV.Controls.Add(ADwF);
        lDwV.Controls.Add(RDwL);
        lDwV.Controls.Add(zDwJ);
        lDwV.Controls.Add(YDw7);
        lDwV.Location = new Point(Class13.rX0O, Class13.yX0e);
        lDwV.Name = Class13.rX08;
        lDwV.Size = new Size(Class13.LX0n, Class13.HX0Q);
        lDwV.TabIndex = Class13.CX0F;
        lDwV.TabStop = false;
        lDwV.Text = Class13.iX0L;
        ADwO.Location = new Point(Class13.CX0J, Class13.TX07);
        ADwO.Name = Class13.IX0P;
        ADwO.Size = new Size(Class13.GX0i, Class13.kX0m);
        ADwO.TabIndex = Class13.GX00;
        ADwO.Text = Class13.UX0I;
        ADwO.UseVisualStyleBackColor = true;
        ADwO.Click += oD0j;
        bDwe.Location = new Point(Class13.pX0R, Class13.NX0C);
        bDwe.Name = Class13.oX0K;
        bDwe.Size = new Size(Class13.SX0U, Class13.yX0T);
        bDwe.TabIndex = 8;
        bDwe.Text = Class13.nX01;
        bDwe.UseVisualStyleBackColor = true;
        bDwe.Click += uDIS;
        VDw8.Location = new Point(Class13.FX0W, Class13.EX0w);
        VDw8.Name = Class13.SX0N;
        VDw8.Size = new Size(Class13.mX0Y, Class13.GX0B);
        VDw8.TabIndex = 7;
        VDw8.Text = Class13.yX0A;
        VDw8.UseVisualStyleBackColor = true;
        VDw8.Click += rDID;
        UDwn.Location = new Point(Class13.mX0f, Class13.UX06);
        UDwn.Name = Class13.zX0x;
        UDwn.Size = new Size(Class13.RX09, Class13.uX0c);
        UDwn.TabIndex = 6;
        UDwn.Text = Class13.OX0y;
        UDwn.UseVisualStyleBackColor = true;
        UDwn.Click += cDIh;
        KDwQ.Location = new Point(Class13.UX0r, Class13.TX0q);
        KDwQ.Name = Class13.WX0k;
        KDwQ.Size = new Size(Class13.AX0M, Class13.kX0u);
        KDwQ.TabIndex = 5;
        KDwQ.Text = Class13.eX0g;
        KDwQ.UseVisualStyleBackColor = true;
        KDwQ.Click += iDIE;
        ADwF.Location = new Point(Class13.hX02, Class13.pX03);
        ADwF.Name = Class13.LX0d;
        ADwF.Size = new Size(Class13.TX0H, Class13.hX04);
        ADwF.TabIndex = 3;
        ADwF.Text = Class13.fX05;
        ADwF.UseVisualStyleBackColor = true;
        ADwF.Click += qDIX;
        RDwL.Location = new Point(Class13.rX0s, Class13.FX0Z);
        RDwL.Name = Class13.WX0a;
        RDwL.Size = new Size(Class13.DX0j, Class13.OX0z);
        RDwL.TabIndex = 2;
        RDwL.Text = Class13.LXIE;
        RDwL.UseVisualStyleBackColor = true;
        RDwL.Click += sDIp;
        zDwJ.Location = new Point(Class13.SXID, Class13.WXIX);
        zDwJ.Name = Class13.iXIp;
        zDwJ.Size = new Size(Class13.xXIS, Class13.JXIh);
        zDwJ.TabIndex = 1;
        zDwJ.Text = Class13.BXIl;
        zDwJ.UseVisualStyleBackColor = true;
        zDwJ.Click += QD0z;
        YDw7.Location = new Point(Class13.CXIG, Class13.rXIb);
        YDw7.Name = Class13.gXIv;
        YDw7.Size = new Size(Class13.FXIo, Class13.WXIt);
        YDw7.TabIndex = 0;
        YDw7.Text = Class13.MXIV;
        YDw7.UseVisualStyleBackColor = true;
        YDw7.Click += XDIl;
        YDTM.Controls.Add(yDTu);
        YDTM.Controls.Add(vDTg);
        YDTM.Controls.Add(FDT2);
        YDTM.Controls.Add(XDT3);
        YDTM.Location = new Point(Class13.oXIO, Class13.FXIe);
        YDTM.Name = Class13.hXI8;
        YDTM.Size = new Size(Class13.IXIn, Class13.BXIQ);
        YDTM.TabIndex = Class13.oXIF;
        YDTM.TabStop = false;
        YDTM.Text = Class13.hXIL;
        yDTu.Location = new Point(Class13.nXIJ, Class13.fXI7);
        yDTu.Name = Class13.WXIP;
        yDTu.Size = new Size(Class13.tXIi, Class13.yXIm);
        yDTu.TabIndex = 3;
        yDTu.Text = Class13.sXI0;
        yDTu.UseVisualStyleBackColor = true;
        yDTu.Click += lD0Z;
        vDTg.Location = new Point(Class13.WXII, Class13.VXIR);
        vDTg.Name = Class13.JXIC;
        vDTg.Size = new Size(Class13.SXIK, Class13.iXIU);
        vDTg.TabIndex = 2;
        vDTg.Text = Class13.VXIT;
        vDTg.UseVisualStyleBackColor = true;
        vDTg.Click += kD0s;
        FDT2.Location = new Point(Class13.eXI1, Class13.bXIW);
        FDT2.Name = Class13.LXIw;
        FDT2.Size = new Size(Class13.aXIN, Class13.qXIY);
        FDT2.TabIndex = 1;
        FDT2.Text = Class13.fXIB;
        FDT2.UseVisualStyleBackColor = true;
        FDT2.Click += PD05;
        XDT3.Location = new Point(6, Class13.bXIA);
        XDT3.Name = Class13.PXIf;
        XDT3.Size = new Size(Class13.OXI6, Class13.UXIx);
        XDT3.TabIndex = 0;
        XDT3.Text = Class13.uXI9;
        XDT3.UseVisualStyleBackColor = true;
        XDT3.Click += dD04;
        xDTd.Controls.Add(eDfd);
        xDTd.Controls.Add(iDfH);
        xDTd.Controls.Add(ODf4);
        xDTd.Controls.Add(sDf5);
        xDTd.Controls.Add(QDfs);
        xDTd.Controls.Add(IDfZ);
        xDTd.Controls.Add(DDfa);
        xDTd.Controls.Add(kDfj);
        xDTd.Controls.Add(dDfz);
        xDTd.Controls.Add(ADTH);
        xDTd.Controls.Add(dDT4);
        xDTd.Controls.Add(cDT5);
        xDTd.Controls.Add(jDTs);
        xDTd.Controls.Add(JDTZ);
        xDTd.Controls.Add(DDTa);
        xDTd.Controls.Add(BDTj);
        xDTd.Controls.Add(sDTz);
        xDTd.Location = new Point(Class13.cXIc, Class13.MXIy);
        xDTd.Name = Class13.SXIr;
        xDTd.Size = new Size(Class13.jXIq, Class13.FXIk);
        xDTd.TabIndex = Class13.uXIM;
        xDTd.TabStop = false;
        xDTd.Text = Class13.AXIu;
        eDfd.AutoSize = true;
        eDfd.Location = new Point(Class13.LXIg, Class13.hXI2);
        eDfd.Name = Class13.WXI3;
        eDfd.Size = new Size(0, Class13.jXId);
        eDfd.TabIndex = Class13.EXIH;
        iDfH.AutoSize = true;
        iDfH.Location = new Point(Class13.HXI4, Class13.jXI5);
        iDfH.Name = Class13.sXIs;
        iDfH.Size = new Size(0, Class13.VXIZ);
        iDfH.TabIndex = Class13.PXIa;
        ODf4.AutoSize = true;
        ODf4.Location = new Point(Class13.IXIj, Class13.yXIz);
        ODf4.Name = Class13.AXRE;
        ODf4.Size = new Size(0, Class13.BXRD);
        ODf4.TabIndex = Class13.eXRX;
        sDf5.AutoSize = true;
        sDf5.Location = new Point(Class13.GXRp, Class13.bXRS);
        sDf5.Name = Class13.GXRh;
        sDf5.Size = new Size(0, Class13.EXRl);
        sDf5.TabIndex = Class13.CXRG;
        QDfs.AutoSize = true;
        QDfs.Location = new Point(Class13.hXRb, Class13.AXRv);
        QDfs.Name = Class13.PXRo;
        QDfs.Size = new Size(0, Class13.MXRt);
        QDfs.TabIndex = Class13.AXRV;
        IDfZ.AutoSize = true;
        IDfZ.Location = new Point(Class13.rXRO, Class13.bXRe);
        IDfZ.Name = Class13.NXR8;
        IDfZ.Size = new Size(0, Class13.lXRn);
        IDfZ.TabIndex = Class13.qXRQ;
        DDfa.AutoSize = true;
        DDfa.Location = new Point(Class13.OXRF, Class13.uXRL);
        DDfa.Name = Class13.TXRJ;
        DDfa.Size = new Size(0, Class13.yXR7);
        DDfa.TabIndex = Class13.uXRP;
        kDfj.AutoSize = true;
        kDfj.Location = new Point(Class13.OXRi, Class13.pXRm);
        kDfj.Name = Class13.HXR0;
        kDfj.Size = new Size(0, Class13.uXRI);
        kDfj.TabIndex = Class13.EXRR;
        dDfz.Location = new Point(Class13.eXRC, Class13.iXRK);
        dDfz.Name = Class13.hXRU;
        dDfz.Size = new Size(Class13.aXRT, Class13.oXR1);
        dDfz.TabIndex = 8;
        dDfz.Text = Class13.qXRW;
        dDfz.UseVisualStyleBackColor = true;
        dDfz.Click += nDUV;
        ADTH.Location = new Point(Class13.nXRw, Class13.WXRN);
        ADTH.Name = Class13.IXRY;
        ADTH.Size = new Size(Class13.gXRB, Class13.KXRA);
        ADTH.TabIndex = 7;
        ADTH.Text = Class13.QXRf;
        ADTH.UseVisualStyleBackColor = true;
        ADTH.Click += PDCR;
        dDT4.Location = new Point(Class13.SXR6, Class13.XXRx);
        dDT4.Name = Class13.pXR9;
        dDT4.Size = new Size(Class13.vXRc, Class13.LXRy);
        dDT4.TabIndex = 6;
        dDT4.Text = Class13.OXRr;
        dDT4.UseVisualStyleBackColor = true;
        dDT4.Click += KDCI;
        cDT5.Location = new Point(Class13.qXRq, Class13.LXRk);
        cDT5.Name = Class13.pXRM;
        cDT5.Size = new Size(Class13.WXRu, Class13.AXRg);
        cDT5.TabIndex = 5;
        cDT5.Text = Class13.RXR2;
        cDT5.UseVisualStyleBackColor = true;
        cDT5.Click += HDC0;
        jDTs.Location = new Point(Class13.FXR3, Class13.NXRd);
        jDTs.Name = Class13.jXRH;
        jDTs.Size = new Size(Class13.RXR4, Class13.JXR5);
        jDTs.TabIndex = 4;
        jDTs.Text = Class13.kXRs;
        jDTs.UseVisualStyleBackColor = true;
        jDTs.Click += SDCm;
        JDTZ.Location = new Point(Class13.bXRZ, Class13.fXRa);
        JDTZ.Name = Class13.TXRj;
        JDTZ.Size = new Size(Class13.QXRz, Class13.hXCE);
        JDTZ.TabIndex = 3;
        JDTZ.Text = Class13.FXCD;
        JDTZ.UseVisualStyleBackColor = true;
        JDTZ.Click += eDCi;
        DDTa.Location = new Point(Class13.bXCX, Class13.QXCp);
        DDTa.Name = Class13.FXCS;
        DDTa.Size = new Size(Class13.RXCh, Class13.DXCl);
        DDTa.TabIndex = 2;
        DDTa.Text = Class13.EXCG;
        DDTa.UseVisualStyleBackColor = true;
        DDTa.Click += RDCP;
        BDTj.Location = new Point(Class13.WXCb, Class13.iXCv);
        BDTj.Name = Class13.pXCo;
        BDTj.Size = new Size(Class13.QXCt, Class13.FXCV);
        BDTj.TabIndex = 1;
        BDTj.Text = Class13.WXCO;
        BDTj.UseVisualStyleBackColor = true;
        BDTj.Click += vD0H;
        sDTz.Location = new Point(Class13.QXCe, Class13.hXC8);
        sDTz.Name = Class13.OXCn;
        sDTz.Size = new Size(Class13.mXCQ, Class13.JXCF);
        sDTz.TabIndex = 0;
        sDTz.Text = Class13.JXCL;
        sDTz.UseVisualStyleBackColor = true;
        sDTz.Click += vDC7;
        lD1E.Controls.Add(fD1D);
        lD1E.Controls.Add(DD1X);
        lD1E.Controls.Add(YD1p);
        lD1E.Controls.Add(uD1S);
        lD1E.Controls.Add(oD1h);
        lD1E.Controls.Add(XD1l);
        lD1E.Controls.Add(HD1G);
        lD1E.Controls.Add(nD1b);
        lD1E.Controls.Add(lD1v);
        lD1E.Controls.Add(ND1o);
        lD1E.Controls.Add(MD1t);
        lD1E.Controls.Add(TD1V);
        lD1E.Controls.Add(YD1O);
        lD1E.Controls.Add(dD1e);
        lD1E.Location = new Point(Class13.DXCJ, 6);
        lD1E.Name = Class13.TXC7;
        lD1E.Size = new Size(Class13.TXCP, Class13.uXCi);
        lD1E.TabIndex = 8;
        lD1E.TabStop = false;
        lD1E.Text = Class13.jXCm;
        fD1D.ForeColor = Color.SeaGreen;
        fD1D.Location = new Point(Class13.KXC0, Class13.oXCI);
        fD1D.Name = Class13.dXCR;
        fD1D.Size = new Size(Class13.rXCC, Class13.tXCK);
        fD1D.TabIndex = Class13.dXCU;
        fD1D.Text = Class13.NXCT;
        fD1D.UseVisualStyleBackColor = true;
        fD1D.Click += oD0d;
        DD1X.Location = new Point(Class13.xXC1, Class13.MXCW);
        DD1X.Name = Class13.rXCw;
        DD1X.Size = new Size(Class13.gXCN, Class13.gXCY);
        DD1X.TabIndex = Class13.UXCB;
        DD1X.Text = Class13.yXCA;
        DD1X.UseVisualStyleBackColor = true;
        DD1X.Click += gD03;
        YD1p.Location = new Point(6, Class13.RXCf);
        YD1p.Name = Class13.oXC6;
        YD1p.Size = new Size(Class13.pXCx, Class13.vXC9);
        YD1p.TabIndex = Class13.TXCc;
        YD1p.Text = Class13.vXCy;
        YD1p.UseVisualStyleBackColor = true;
        YD1p.Click += BD0c;
        uD1S.Location = new Point(6, Class13.qXCr);
        uD1S.Name = Class13.pXCq;
        uD1S.Size = new Size(Class13.PXCk, Class13.UXCM);
        uD1S.TabIndex = Class13.FXCu;
        uD1S.Text = Class13.wXCg;
        uD1S.UseVisualStyleBackColor = true;
        uD1S.Click += MD0r;
        oD1h.Location = new Point(6, Class13.SXC2);
        oD1h.Name = Class13.FXC3;
        oD1h.Size = new Size(Class13.NXCd, Class13.nXCH);
        oD1h.TabIndex = Class13.TXC4;
        oD1h.Text = Class13.OXC5;
        oD1h.UseVisualStyleBackColor = true;
        oD1h.Click += UD0y;
        XD1l.Location = new Point(8, Class13.GXCs);
        XD1l.Name = Class13.OXCZ;
        XD1l.Size = new Size(Class13.NXCa, Class13.JXCj);
        XD1l.TabIndex = 7;
        XD1l.Text = Class13.VXCz;
        XD1l.UseVisualStyleBackColor = true;
        XD1l.Click += MD0g;
        HD1G.Location = new Point(Class13.iXKE, Class13.bXKD);
        HD1G.Name = Class13.LXKX;
        HD1G.Size = new Size(Class13.lXKp, Class13.QXKS);
        HD1G.TabIndex = 8;
        HD1G.Text = Class13.kXKh;
        HD1G.UseVisualStyleBackColor = true;
        HD1G.Click += xD0k;
        nD1b.Location = new Point(Class13.fXKl, Class13.BXKG);
        nD1b.Name = Class13.RXKb;
        nD1b.Size = new Size(Class13.CXKv, Class13.cXKo);
        nD1b.TabIndex = 6;
        nD1b.Text = Class13.sXKt;
        nD1b.UseVisualStyleBackColor = true;
        nD1b.Click += iD0M;
        lD1v.Location = new Point(Class13.vXKV, Class13.dXKO);
        lD1v.Name = Class13.sXKe;
        lD1v.Size = new Size(Class13.LXK8, Class13.CXKn);
        lD1v.TabIndex = 5;
        lD1v.Text = Class13.TXKQ;
        lD1v.UseVisualStyleBackColor = true;
        lD1v.Click += tD02;
        ND1o.Location = new Point(Class13.eXKF, Class13.LXKL);
        ND1o.Name = Class13.FXKJ;
        ND1o.Size = new Size(Class13.SXK7, Class13.qXKP);
        ND1o.TabIndex = 4;
        ND1o.Text = Class13.zXKi;
        ND1o.UseVisualStyleBackColor = true;
        ND1o.Click += WD0u;
        MD1t.Location = new Point(Class13.jXKm, Class13.rXK0);
        MD1t.Name = Class13.sXKI;
        MD1t.Size = new Size(Class13.aXKR, Class13.UXKC);
        MD1t.TabIndex = 3;
        MD1t.Text = Class13.iXKK;
        MD1t.UseVisualStyleBackColor = true;
        MD1t.Click += xD0q;
        TD1V.Location = new Point(6, Class13.lXKU);
        TD1V.Name = Class13.hXKT;
        TD1V.Size = new Size(Class13.AXK1, Class13.bXKW);
        TD1V.TabIndex = 2;
        TD1V.Text = Class13.BXKw;
        TD1V.UseVisualStyleBackColor = true;
        TD1V.Click += nD09;
        YD1O.Location = new Point(6, Class13.hXKN);
        YD1O.Name = Class13.aXKY;
        YD1O.Size = new Size(Class13.cXKB, Class13.IXKA);
        YD1O.TabIndex = 1;
        YD1O.Text = Class13.GXKf;
        YD1O.UseVisualStyleBackColor = true;
        YD1O.Click += WD0x;
        dD1e.Location = new Point(6, Class13.JXK6);
        dD1e.Name = Class13.rXKx;
        dD1e.Size = new Size(Class13.jXK9, Class13.xXKc);
        dD1e.TabIndex = 0;
        dD1e.Text = Class13.bXKy;
        dD1e.UseVisualStyleBackColor = true;
        dD1e.Click += UD06;
        LDA2.Controls.Add(pDA3);
        LDA2.Controls.Add(DDAd);
        LDA2.Controls.Add(TDAZ);
        LDA2.Location = new Point(4, Class13.SXKr);
        LDA2.Name = Class13.oXKq;
        LDA2.Padding = new Padding(3);
        LDA2.Size = new Size(Class13.WXKk, Class13.FXKM);
        LDA2.TabIndex = 6;
        LDA2.Text = Class13.TXKu;
        LDA2.UseVisualStyleBackColor = true;
        pDA3.Controls.Add(WD6b);
        pDA3.Controls.Add(CD6v);
        pDA3.Controls.Add(sD6X);
        pDA3.Controls.Add(AD6p);
        pDA3.Controls.Add(mD6S);
        pDA3.Controls.Add(hD6h);
        pDA3.Controls.Add(OD6l);
        pDA3.Controls.Add(cD6G);
        pDA3.Location = new Point(Class13.xXKg, Class13.EXK2);
        pDA3.Name = Class13.uXK3;
        pDA3.Size = new Size(Class13.qXKd, Class13.UXKH);
        pDA3.TabIndex = 2;
        pDA3.TabStop = false;
        pDA3.Text = Class13.xXK4;
        WD6b.Location = new Point(Class13.XXK5, Class13.YXKs);
        WD6b.Name = Class13.oXKZ;
        WD6b.Size = new Size(Class13.oXKa, Class13.WXKj);
        WD6b.TabIndex = 7;
        WD6b.Text = Class13.EXKz;
        WD6b.UseVisualStyleBackColor = true;
        WD6b.Click += EDUg;
        CD6v.Location = new Point(Class13.VXUE, Class13.iXUD);
        CD6v.Name = Class13.rXUX;
        CD6v.Size = new Size(Class13.DXUp, Class13.GXUS);
        CD6v.TabIndex = 6;
        CD6v.Text = Class13.vXUh;
        CD6v.UseVisualStyleBackColor = true;
        CD6v.Click += FDUu;
        sD6X.Location = new Point(Class13.CXUl, Class13.sXUG);
        sD6X.Name = Class13.jXUb;
        sD6X.Size = new Size(Class13.BXUv, Class13.TXUo);
        sD6X.TabIndex = 5;
        sD6X.Text = Class13.vXUt;
        sD6X.UseVisualStyleBackColor = true;
        sD6X.Click += rDUM;
        AD6p.Location = new Point(6, Class13.sXUV);
        AD6p.Name = Class13.MXUO;
        AD6p.Size = new Size(Class13.AXUe, Class13.DXU8);
        AD6p.TabIndex = 4;
        AD6p.Text = Class13.dXUn;
        AD6p.UseVisualStyleBackColor = true;
        AD6p.Click += SDUk;
        mD6S.Location = new Point(Class13.dXUQ, Class13.UXUF);
        mD6S.Name = Class13.QXUL;
        mD6S.Size = new Size(Class13.jXUJ, Class13.DXU7);
        mD6S.TabIndex = 3;
        mD6S.Text = Class13.qXUP;
        mD6S.UseVisualStyleBackColor = true;
        mD6S.Click += YDUq;
        hD6h.Location = new Point(Class13.CXUi, Class13.iXUm);
        hD6h.Name = Class13.eXU0;
        hD6h.Size = new Size(Class13.GXUI, Class13.cXUR);
        hD6h.TabIndex = 2;
        hD6h.Text = Class13.SXUC;
        hD6h.UseVisualStyleBackColor = true;
        hD6h.Click += KDUQ;
        OD6l.Location = new Point(Class13.VXUK, Class13.KXUU);
        OD6l.Name = Class13.nXUT;
        OD6l.Size = new Size(Class13.sXU1, Class13.UXUW);
        OD6l.TabIndex = 1;
        OD6l.Text = Class13.EXUw;
        OD6l.UseVisualStyleBackColor = true;
        OD6l.Click += BDUn;
        cD6G.Location = new Point(6, Class13.YXUN);
        cD6G.Name = Class13.XXUY;
        cD6G.Size = new Size(Class13.fXUB, Class13.HXUA);
        cD6G.TabIndex = 0;
        cD6G.Text = Class13.uXUf;
        cD6G.UseVisualStyleBackColor = true;
        cD6G.Click += yDU8;
        DDAd.Controls.Add(JDfv);
        DDAd.Controls.Add(cDfO);
        DDAd.Location = new Point(Class13.IXU6, Class13.WXUx);
        DDAd.Name = Class13.nXU9;
        DDAd.Size = new Size(Class13.fXUc, Class13.oXUy);
        DDAd.TabIndex = 1;
        DDAd.TabStop = false;
        DDAd.Text = Class13.kXUr;
        JDfv.Controls.Add(JDfw);
        JDfv.Controls.Add(pDfT);
        JDfv.Controls.Add(vDfK);
        JDfv.Controls.Add(sDfC);
        JDfv.Controls.Add(rDfe);
        JDfv.Controls.Add(LDf8);
        JDfv.Controls.Add(uDfn);
        JDfv.Controls.Add(SDfQ);
        JDfv.Controls.Add(bDfF);
        JDfv.Controls.Add(kDfL);
        JDfv.Controls.Add(bDfJ);
        JDfv.Controls.Add(KDfo);
        JDfv.Controls.Add(gDft);
        JDfv.Controls.Add(UDfV);
        JDfv.Location = new Point(Class13.kXUq, Class13.IXUk);
        JDfv.Name = Class13.zXUM;
        JDfv.Size = new Size(Class13.pXUu, Class13.GXUg);
        JDfv.TabIndex = 7;
        JDfv.TabStop = false;
        JDfv.Text = Class13.UXU2;
        JDfw.Location = new Point(Class13.xXU3, Class13.GXUd);
        JDfw.Name = Class13.aXUH;
        JDfw.Size = new Size(Class13.OXU4, Class13.QXU5);
        JDfw.TabIndex = Class13.dXUs;
        JDfw.Text = Class13.xXUZ;
        JDfw.UseVisualStyleBackColor = true;
        JDfw.Click += rDKd;
        pDfT.Location = new Point(Class13.oXUa, Class13.YXUj);
        pDfT.Name = Class13.gXUz;
        pDfT.Size = new Size(Class13.aXTE, Class13.sXTD);
        pDfT.TabIndex = Class13.vXTX;
        pDfT.Text = Class13.QXTp;
        pDfT.UseVisualStyleBackColor = true;
        pDfT.Click += WDK3;
        vDfK.Location = new Point(Class13.BXTS, Class13.yXTh);
        vDfK.Name = Class13.jXTl;
        vDfK.Size = new Size(Class13.oXTG, Class13.vXTb);
        vDfK.TabIndex = Class13.qXTv;
        vDfK.Text = Class13.MXTo;
        vDfK.UseVisualStyleBackColor = true;
        vDfK.Click += EDK2;
        sDfC.Location = new Point(Class13.WXTt, Class13.iXTV);
        sDfC.Name = Class13.OXTO;
        sDfC.Size = new Size(Class13.GXTe, Class13.xXT8);
        sDfC.TabIndex = Class13.eXTn;
        sDfC.Text = Class13.zXTQ;
        sDfC.UseVisualStyleBackColor = true;
        sDfC.Click += QDKq;
        rDfe.Location = new Point(Class13.DXTF, Class13.UXTL);
        rDfe.Name = Class13.xXTJ;
        rDfe.Size = new Size(Class13.IXT7, Class13.CXTP);
        rDfe.TabIndex = Class13.WXTi;
        rDfe.Text = Class13.tXTm;
        rDfe.UseVisualStyleBackColor = true;
        rDfe.Click += XDKM;
        LDf8.Location = new Point(Class13.VXT0, Class13.iXTI);
        LDf8.Name = Class13.TXTR;
        LDf8.Size = new Size(Class13.gXTC, Class13.TXTK);
        LDf8.TabIndex = Class13.HXTU;
        LDf8.Text = Class13.UXTT;
        LDf8.UseVisualStyleBackColor = true;
        LDf8.Click += pDK4;
        uDfn.Location = new Point(Class13.dXT1, Class13.WXTW);
        uDfn.Name = Class13.dXTw;
        uDfn.Size = new Size(Class13.FXTN, Class13.vXTY);
        uDfn.TabIndex = Class13.bXTB;
        uDfn.Text = Class13.tXTA;
        uDfn.UseVisualStyleBackColor = true;
        uDfn.Click += CDK5;
        SDfQ.Location = new Point(6, Class13.uXTf);
        SDfQ.Name = Class13.uXT6;
        SDfQ.Size = new Size(Class13.uXTx, Class13.bXT9);
        SDfQ.TabIndex = Class13.EXTc;
        SDfQ.Text = Class13.XXTy;
        SDfQ.UseVisualStyleBackColor = true;
        SDfQ.Click += yDKs;
        bDfF.Location = new Point(6, Class13.AXTr);
        bDfF.Name = Class13.qXTq;
        bDfF.Size = new Size(Class13.SXTk, Class13.UXTM);
        bDfF.TabIndex = Class13.XXTu;
        bDfF.Text = Class13.vXTg;
        bDfF.UseVisualStyleBackColor = true;
        bDfF.Click += RDKH;
        kDfL.Location = new Point(6, Class13.YXT2);
        kDfL.Name = Class13.zXT3;
        kDfL.Size = new Size(Class13.uXTd, Class13.qXTH);
        kDfL.TabIndex = 7;
        kDfL.Text = Class13.mXT4;
        kDfL.UseVisualStyleBackColor = true;
        kDfL.Click += ADKu;
        bDfJ.Location = new Point(6, Class13.FXT5);
        bDfJ.Name = Class13.zXTs;
        bDfJ.Size = new Size(Class13.BXTZ, Class13.mXTa);
        bDfJ.TabIndex = 6;
        bDfJ.Text = Class13.SXTj;
        bDfJ.UseVisualStyleBackColor = true;
        bDfJ.Click += tDKg;
        KDfo.Location = new Point(6, Class13.RXTz);
        KDfo.Name = Class13.kX1E;
        KDfo.Size = new Size(Class13.KX1D, Class13.AX1X);
        KDfo.TabIndex = 0;
        KDfo.Text = Class13.uX1p;
        KDfo.UseVisualStyleBackColor = true;
        KDfo.Click += bDKy;
        gDft.Location = new Point(6, Class13.fX1S);
        gDft.Name = Class13.KX1h;
        gDft.Size = new Size(Class13.SX1l, Class13.pX1G);
        gDft.TabIndex = 5;
        gDft.Text = Class13.aX1b;
        gDft.UseVisualStyleBackColor = true;
        gDft.Click += sDKk;
        UDfV.Location = new Point(6, Class13.SX1v);
        UDfV.Name = Class13.hX1o;
        UDfV.Size = new Size(Class13.EX1t, Class13.zX1V);
        UDfV.TabIndex = 4;
        UDfV.Text = Class13.nX1O;
        UDfV.UseVisualStyleBackColor = true;
        UDfV.Click += WDKr;
        cDfO.Controls.Add(cDfW);
        cDfO.Controls.Add(JDf1);
        cDfO.Controls.Add(PDfU);
        cDfO.Controls.Add(fDfR);
        cDfO.Controls.Add(gDf7);
        cDfO.Controls.Add(vDfP);
        cDfO.Controls.Add(ODfi);
        cDfO.Controls.Add(uDfm);
        cDfO.Controls.Add(XDf0);
        cDfO.Controls.Add(rDfI);
        cDfO.Controls.Add(GDAs);
        cDfO.Controls.Add(ADAH);
        cDfO.Controls.Add(WDA4);
        cDfO.Controls.Add(lDA5);
        cDfO.Location = new Point(5, Class13.MX1e);
        cDfO.Name = Class13.QX18;
        cDfO.Size = new Size(Class13.rX1n, Class13.dX1Q);
        cDfO.TabIndex = 6;
        cDfO.TabStop = false;
        cDfO.Text = Class13.EX1F;
        cDfW.Location = new Point(Class13.dX1L, Class13.LX1J);
        cDfW.Name = Class13.uX17;
        cDfW.Size = new Size(Class13.QX1P, Class13.IX1i);
        cDfW.TabIndex = Class13.vX1m;
        cDfW.Text = Class13.aX10;
        cDfW.UseVisualStyleBackColor = true;
        cDfW.Click += IDKc;
        JDf1.Location = new Point(Class13.dX1I, Class13.IX1R);
        JDf1.Name = Class13.qX1C;
        JDf1.Size = new Size(Class13.aX1K, Class13.MX1U);
        JDf1.TabIndex = Class13.CX1T;
        JDf1.Text = Class13.CX11;
        JDf1.UseVisualStyleBackColor = true;
        JDf1.Click += ODKf;
        PDfU.Location = new Point(Class13.MX1W, Class13.bX1w);
        PDfU.Name = Class13.OX1N;
        PDfU.Size = new Size(Class13.pX1Y, Class13.mX1B);
        PDfU.TabIndex = Class13.aX1A;
        PDfU.Text = Class13.FX1f;
        PDfU.UseVisualStyleBackColor = true;
        PDfU.Click += QDKA;
        fDfR.Location = new Point(Class13.PX16, Class13.FX1x);
        fDfR.Name = Class13.FX19;
        fDfR.Size = new Size(Class13.wX1c, Class13.hX1y);
        fDfR.TabIndex = Class13.XX1r;
        fDfR.Text = Class13.nX1q;
        fDfR.UseVisualStyleBackColor = true;
        fDfR.Click += UDK1;
        gDf7.Location = new Point(Class13.SX1k, Class13.rX1M);
        gDf7.Name = Class13.NX1u;
        gDf7.Size = new Size(Class13.YX1g, Class13.cX12);
        gDf7.TabIndex = Class13.rX13;
        gDf7.Text = Class13.MX1d;
        gDf7.UseVisualStyleBackColor = true;
        gDf7.Click += gDK9;
        vDfP.Location = new Point(Class13.mX1H, Class13.rX14);
        vDfP.Name = Class13.tX15;
        vDfP.Size = new Size(Class13.sX1s, Class13.rX1Z);
        vDfP.TabIndex = Class13.KX1a;
        vDfP.Text = Class13.RX1j;
        vDfP.UseVisualStyleBackColor = true;
        vDfP.Click += DDKx;
        ODfi.Location = new Point(Class13.GX1z, Class13.tXWE);
        ODfi.Name = Class13.HXWD;
        ODfi.Size = new Size(Class13.bXWX, Class13.fXWp);
        ODfi.TabIndex = Class13.TXWS;
        ODfi.Text = Class13.BXWh;
        ODfi.UseVisualStyleBackColor = true;
        ODfi.Click += SDKw;
        uDfm.Location = new Point(6, Class13.FXWl);
        uDfm.Name = Class13.AXWG;
        uDfm.Size = new Size(Class13.gXWb, Class13.xXWv);
        uDfm.TabIndex = Class13.aXWo;
        uDfm.Text = Class13.xXWt;
        uDfm.UseVisualStyleBackColor = true;
        uDfm.Click += HDK6;
        XDf0.Location = new Point(6, Class13.uXWV);
        XDf0.Name = Class13.hXWO;
        XDf0.Size = new Size(Class13.NXWe, Class13.uXW8);
        XDf0.TabIndex = 8;
        XDf0.Text = Class13.jXWn;
        XDf0.UseVisualStyleBackColor = true;
        XDf0.Click += qDKB;
        rDfI.Location = new Point(6, Class13.bXWQ);
        rDfI.Name = Class13.bXWF;
        rDfI.Size = new Size(Class13.MXWL, Class13.YXWJ);
        rDfI.TabIndex = 7;
        rDfI.Text = Class13.UXW7;
        rDfI.UseVisualStyleBackColor = true;
        rDfI.Click += GDKY;
        GDAs.Location = new Point(6, Class13.IXWP);
        GDAs.Name = Class13.kXWi;
        GDAs.Size = new Size(Class13.lXWm, Class13.UXW0);
        GDAs.TabIndex = 0;
        GDAs.Text = Class13.hXWI;
        GDAs.UseVisualStyleBackColor = true;
        GDAs.Click += mDKU;
        ADAH.Location = new Point(6, Class13.zXWR);
        ADAH.Name = Class13.eXWC;
        ADAH.Size = new Size(Class13.nXWK, Class13.MXWU);
        ADAH.TabIndex = 5;
        ADAH.Text = Class13.qXWT;
        ADAH.UseVisualStyleBackColor = true;
        ADAH.Click += JDKW;
        WDA4.Location = new Point(6, Class13.CXW1);
        WDA4.Name = Class13.OXWW;
        WDA4.Size = new Size(Class13.bXWw, Class13.QXWN);
        WDA4.TabIndex = 4;
        WDA4.Text = Class13.kXWY;
        WDA4.UseVisualStyleBackColor = true;
        WDA4.Click += mDKT;
        lDA5.Location = new Point(6, Class13.KXWB);
        lDA5.Name = Class13.aXWA;
        lDA5.Size = new Size(Class13.WXWf, Class13.lXW6);
        lDA5.TabIndex = 2;
        lDA5.Text = Class13.JXWx;
        lDA5.UseVisualStyleBackColor = true;
        lDA5.Click += MDKN;
        TDAZ.Controls.Add(SD6F);
        TDAZ.Controls.Add(CD6L);
        TDAZ.Controls.Add(AD6J);
        TDAZ.Controls.Add(uD6Q);
        TDAZ.Controls.Add(kD6n);
        TDAZ.Controls.Add(GD68);
        TDAZ.Controls.Add(PD6e);
        TDAZ.Controls.Add(GD6O);
        TDAZ.Controls.Add(zD6V);
        TDAZ.Location = new Point(6, 6);
        TDAZ.Name = Class13.tXW9;
        TDAZ.Size = new Size(Class13.RXWc, Class13.nXWy);
        TDAZ.TabIndex = 0;
        TDAZ.TabStop = false;
        TDAZ.Text = Class13.fXWr;
        SD6F.Location = new Point(Class13.DXWq, Class13.NXWk);
        SD6F.Name = Class13.uXWM;
        SD6F.Size = new Size(Class13.QXWu, Class13.HXWg);
        SD6F.TabIndex = Class13.FXW2;
        SD6F.Text = Class13.vXW3;
        MD6H.SetToolTip(SD6F, Class13.TXWd);
        SD6F.UseVisualStyleBackColor = true;
        CD6L.Controls.Add(QDfh);
        CD6L.Location = new Point(6, Class13.aXWH);
        CD6L.Name = Class13.qXW4;
        CD6L.Size = new Size(Class13.qXW5, Class13.yXWs);
        CD6L.TabIndex = Class13.EXWZ;
        CD6L.TabStop = false;
        CD6L.Text = Class13.AXWa;
        QDfh.Location = new Point(4, Class13.XXWj);
        QDfh.Name = Class13.xXWz;
        QDfh.Size = new Size(Class13.FXwE, Class13.uXwD);
        QDfh.TabIndex = Class13.EXwX;
        QDfh.Text = Class13.iXwp;
        QDfh.UseVisualStyleBackColor = true;
        QDfh.Click += ODKi;
        AD6J.Controls.Add(TD67);
        AD6J.Controls.Add(WD6P);
        AD6J.Controls.Add(PD6i);
        AD6J.Controls.Add(cD6m);
        AD6J.Controls.Add(nD60);
        AD6J.Controls.Add(TD6I);
        AD6J.Controls.Add(TD6R);
        AD6J.Controls.Add(WD6C);
        AD6J.Controls.Add(KD6o);
        AD6J.Location = new Point(Class13.qXwS, Class13.jXwh);
        AD6J.Name = Class13.UXwl;
        AD6J.Size = new Size(Class13.XXwG, Class13.MXwb);
        AD6J.TabIndex = Class13.NXwv;
        AD6J.TabStop = false;
        AD6J.Text = Class13.IXwo;
        TD67.Location = new Point(Class13.XXwt, Class13.RXwV);
        TD67.Name = Class13.dXwO;
        TD67.Size = new Size(Class13.vXwe, Class13.sXw8);
        TD67.TabIndex = Class13.jXwn;
        TD67.Text = Class13.HXwQ;
        TD67.UseVisualStyleBackColor = true;
        TD67.Click += BDUA;
        WD6P.Location = new Point(Class13.TXwF, Class13.nXwL);
        WD6P.Name = Class13.iXwJ;
        WD6P.Size = new Size(Class13.tXw7, Class13.nXwP);
        WD6P.TabIndex = Class13.vXwi;
        WD6P.Text = Class13.NXwm;
        WD6P.UseVisualStyleBackColor = true;
        WD6P.Click += wDUB;
        PD6i.Location = new Point(Class13.RXw0, Class13.TXwI);
        PD6i.Name = Class13.VXwR;
        PD6i.Size = new Size(Class13.eXwC, Class13.TXwK);
        PD6i.TabIndex = Class13.cXwU;
        PD6i.Text = Class13.NXwT;
        PD6i.UseVisualStyleBackColor = true;
        PD6i.Click += ODUY;
        cD6m.Location = new Point(6, Class13.qXw1);
        cD6m.Name = Class13.pXwW;
        cD6m.Size = new Size(Class13.tXww, Class13.WXwN);
        cD6m.TabIndex = Class13.KXwY;
        cD6m.Text = Class13.aXwB;
        cD6m.UseVisualStyleBackColor = true;
        cD6m.Click += DDUN;
        nD60.Location = new Point(Class13.zXwA, Class13.IXwf);
        nD60.Name = Class13.iXw6;
        nD60.Size = new Size(Class13.cXwx, Class13.XXw9);
        nD60.TabIndex = Class13.AXwc;
        nD60.Text = Class13.pXwy;
        nD60.UseVisualStyleBackColor = true;
        nD60.Click += HDUw;
        TD6I.Location = new Point(Class13.GXwr, Class13.yXwq);
        TD6I.Name = Class13.RXwk;
        TD6I.Size = new Size(Class13.zXwM, Class13.jXwu);
        TD6I.TabIndex = Class13.MXwg;
        TD6I.Text = Class13.bXw2;
        TD6I.UseVisualStyleBackColor = true;
        TD6I.Click += cDUW;
        TD6R.Location = new Point(Class13.LXw3, Class13.bXwd);
        TD6R.Name = Class13.iXwH;
        TD6R.Size = new Size(Class13.aXw4, Class13.GXw5);
        TD6R.TabIndex = Class13.uXws;
        TD6R.Text = Class13.TXwZ;
        TD6R.UseVisualStyleBackColor = true;
        TD6R.Click += ADU1;
        WD6C.Location = new Point(6, Class13.WXwa);
        WD6C.Name = Class13.sXwj;
        WD6C.Size = new Size(Class13.fXwz, Class13.SXNE);
        WD6C.TabIndex = Class13.UXND;
        WD6C.Text = Class13.WXNX;
        WD6C.UseVisualStyleBackColor = true;
        WD6C.Click += uDUT;
        KD6o.Location = new Point(Class13.rXNp, Class13.cXNS);
        KD6o.Name = Class13.aXNh;
        KD6o.Size = new Size(Class13.XXNl, Class13.kXNG);
        KD6o.TabIndex = Class13.iXNb;
        KD6o.Text = Class13.HXNv;
        KD6o.UseVisualStyleBackColor = true;
        KD6o.Click += LDU2;
        uD6Q.Controls.Add(fDfS);
        uD6Q.Controls.Add(IDfX);
        uD6Q.Location = new Point(Class13.WXNo, Class13.uXNt);
        uD6Q.Name = Class13.rXNV;
        uD6Q.Size = new Size(Class13.PXNO, Class13.SXNe);
        uD6Q.TabIndex = Class13.kXN8;
        uD6Q.TabStop = false;
        uD6Q.Text = Class13.zXNn;
        fDfS.Location = new Point(4, Class13.KXNQ);
        fDfS.Name = Class13.DXNF;
        fDfS.Size = new Size(Class13.gXNL, Class13.EXNJ);
        fDfS.TabIndex = Class13.aXN7;
        fDfS.Text = Class13.tXNP;
        fDfS.UseVisualStyleBackColor = true;
        fDfS.Click += MDKn;
        IDfX.Location = new Point(4, Class13.wXNi);
        IDfX.Name = Class13.hXNm;
        IDfX.Size = new Size(Class13.LXN0, Class13.kXNI);
        IDfX.TabIndex = Class13.wXNR;
        IDfX.Text = Class13.QXNC;
        IDfX.UseVisualStyleBackColor = true;
        IDfX.Click += dDKm;
        kD6n.Controls.Add(iDfl);
        kD6n.Controls.Add(FDfD);
        kD6n.Location = new Point(6, Class13.aXNK);
        kD6n.Name = Class13.rXNU;
        kD6n.Size = new Size(Class13.BXNT, Class13.DXN1);
        kD6n.TabIndex = Class13.WXNW;
        kD6n.TabStop = false;
        kD6n.Text = Class13.hXNw;
        iDfl.Location = new Point(5, Class13.aXNN);
        iDfl.Name = Class13.LXNY;
        iDfl.Size = new Size(Class13.UXNB, Class13.DXNA);
        iDfl.TabIndex = Class13.aXNf;
        iDfl.Text = Class13.CXN6;
        iDfl.UseVisualStyleBackColor = true;
        iDfl.Click += mDKJ;
        FDfD.Location = new Point(5, Class13.sXNx);
        FDfD.Name = Class13.JXN9;
        FDfD.Size = new Size(Class13.mXNc, Class13.qXNy);
        FDfD.TabIndex = Class13.xXNr;
        FDfD.Text = Class13.zXNq;
        FDfD.UseVisualStyleBackColor = true;
        FDfD.Click += qDK7;
        GD68.Controls.Add(pDfp);
        GD68.Location = new Point(Class13.SXNk, Class13.XXNM);
        GD68.Name = Class13.WXNu;
        GD68.Size = new Size(Class13.LXNg, Class13.FXN2);
        GD68.TabIndex = Class13.VXN3;
        GD68.TabStop = false;
        GD68.Text = Class13.PXNd;
        pDfp.Location = new Point(4, Class13.KXNH);
        pDfp.Name = Class13.SXN4;
        pDfp.Size = new Size(Class13.RXN5, Class13.pXNs);
        pDfp.TabIndex = Class13.IXNZ;
        pDfp.Text = Class13.sXNa;
        MD6H.SetToolTip(pDfp, Class13.DXNj);
        pDfp.UseVisualStyleBackColor = true;
        pDfp.Click += qDKQ;
        PD6e.Controls.Add(oDfE);
        PD6e.Controls.Add(HDfb);
        PD6e.Location = new Point(Class13.vXNz, Class13.dXYE);
        PD6e.Name = Class13.tXYD;
        PD6e.Size = new Size(Class13.lXYX, Class13.XXYp);
        PD6e.TabIndex = Class13.oXYS;
        PD6e.TabStop = false;
        PD6e.Text = Class13.cXYh;
        oDfE.Location = new Point(6, Class13.oXYl);
        oDfE.Name = Class13.gXYG;
        oDfE.Size = new Size(Class13.YXYb, Class13.EXYv);
        oDfE.TabIndex = 3;
        oDfE.Text = Class13.dXYo;
        oDfE.UseVisualStyleBackColor = true;
        oDfE.Click += uDKF;
        HDfb.Location = new Point(6, Class13.DXYt);
        HDfb.Name = Class13.QXYV;
        HDfb.Size = new Size(Class13.kXYO, Class13.OXYe);
        HDfb.TabIndex = 5;
        HDfb.Text = Class13.lXY8;
        HDfb.UseVisualStyleBackColor = true;
        HDfb.Click += FDKL;
        GD6O.Controls.Add(jDAj);
        GD6O.Controls.Add(oDAa);
        GD6O.Location = new Point(Class13.zXYn, Class13.HXYQ);
        GD6O.Name = Class13.qXYF;
        GD6O.Size = new Size(Class13.GXYL, Class13.UXYJ);
        GD6O.TabIndex = Class13.XXY7;
        GD6O.TabStop = false;
        GD6O.Text = Class13.gXYP;
        jDAj.Location = new Point(5, Class13.WXYi);
        jDAj.Name = Class13.uXYm;
        jDAj.Size = new Size(Class13.eXY0, Class13.HXYI);
        jDAj.TabIndex = 1;
        jDAj.Text = Class13.WXYR;
        jDAj.UseVisualStyleBackColor = true;
        jDAj.Click += ODKO;
        oDAa.Location = new Point(5, Class13.AXYC);
        oDAa.Name = Class13.DXYK;
        oDAa.Size = new Size(Class13.PXYU, Class13.oXYT);
        oDAa.TabIndex = 2;
        oDAa.Text = Class13.hXY1;
        oDAa.UseVisualStyleBackColor = true;
        oDAa.Click += pDKe;
        zD6V.Controls.Add(hDfG);
        zD6V.Controls.Add(LDAz);
        zD6V.Location = new Point(6, Class13.uXYW);
        zD6V.Name = Class13.aXYw;
        zD6V.Size = new Size(Class13.iXYN, Class13.tXYY);
        zD6V.TabIndex = Class13.TXYB;
        zD6V.TabStop = false;
        zD6V.Text = Class13.yXYA;
        hDfG.Location = new Point(5, Class13.XXYf);
        hDfG.Name = Class13.gXY6;
        hDfG.Size = new Size(Class13.fXYx, Class13.RXY9);
        hDfG.TabIndex = Class13.KXYc;
        hDfG.Text = Class13.AXYy;
        MD6H.SetToolTip(hDfG, Class13.bXYr);
        hDfG.UseVisualStyleBackColor = true;
        hDfG.Click += DDK8;
        LDAz.Location = new Point(5, Class13.LXYq);
        LDAz.Name = Class13.sXYk;
        LDAz.Size = new Size(Class13.LXYM, Class13.aXYu);
        LDAz.TabIndex = 0;
        LDAz.Text = Class13.XXYg;
        MD6H.SetToolTip(LDAz, Class13.HXY2);
        LDAz.UseVisualStyleBackColor = true;
        LDAz.Click += ADKV;
        mDw1.Controls.Add(rDwk);
        mDw1.Controls.Add(wDwW);
        mDw1.Location = new Point(4, Class13.FXY3);
        mDw1.Name = Class13.MXYd;
        mDw1.Padding = new Padding(3);
        mDw1.Size = new Size(Class13.TXYH, Class13.VXY4);
        mDw1.TabIndex = 4;
        mDw1.Text = Class13.oXY5;
        mDw1.UseVisualStyleBackColor = true;
        rDwk.Controls.Add(TDwM);
        rDwk.Controls.Add(oDwu);
        rDwk.Controls.Add(eDwj);
        rDwk.Controls.Add(qDwz);
        rDwk.Location = new Point(3, 6);
        rDwk.Name = Class13.GXYs;
        rDwk.SelectedIndex = 0;
        rDwk.Size = new Size(Class13.qXYZ, Class13.YXYa);
        rDwk.TabIndex = 2;
        TDwM.Controls.Add(rD6s);
        TDwM.Controls.Add(SD65);
        TDwM.Controls.Add(UDfg);
        TDwM.Controls.Add(fDfY);
        TDwM.Controls.Add(qDfr);
        TDwM.Controls.Add(EDBI);
        TDwM.Controls.Add(gDB0);
        TDwM.Controls.Add(gDBm);
        TDwM.Controls.Add(qDND);
        TDwM.Controls.Add(LDNE);
        TDwM.Controls.Add(vDw4);
        TDwM.Controls.Add(LDwa);
        TDwM.Location = new Point(4, Class13.SXYj);
        TDwM.Name = Class13.zXYz;
        TDwM.Padding = new Padding(3);
        TDwM.Size = new Size(Class13.TXBE, Class13.EXBD);
        TDwM.TabIndex = 0;
        TDwM.Text = Class13.zXBX;
        TDwM.UseVisualStyleBackColor = true;
        rD6s.Location = new Point(Class13.lXBp, Class13.JXBS);
        rD6s.Name = Class13.GXBh;
        rD6s.Size = new Size(Class13.yXBl, Class13.aXBG);
        rD6s.TabIndex = Class13.kXBb;
        rD6s.Text = Class13.jXBv;
        rD6s.UseVisualStyleBackColor = true;
        rD6s.Click += uDUx;
        SD65.Location = new Point(Class13.VXBo, Class13.IXBt);
        SD65.Name = Class13.aXBV;
        SD65.Size = new Size(Class13.lXBO, Class13.bXBe);
        SD65.TabIndex = Class13.AXB8;
        SD65.Text = Class13.uXBn;
        SD65.UseVisualStyleBackColor = true;
        SD65.Click += JDU6;
        UDfg.Location = new Point(Class13.tXBQ, Class13.lXBF);
        UDfg.Name = Class13.FXBL;
        UDfg.Size = new Size(Class13.iXBJ, Class13.wXB7);
        UDfg.TabIndex = Class13.vXBP;
        UDfg.Text = Class13.YXBi;
        UDfg.UseVisualStyleBackColor = true;
        UDfg.Click += KDUt;
        fDfY.Controls.Add(TDfB);
        fDfY.Controls.Add(JDfA);
        fDfY.Controls.Add(rDff);
        fDfY.Controls.Add(dDf6);
        fDfY.Controls.Add(oDfx);
        fDfY.Controls.Add(aDf9);
        fDfY.Controls.Add(UDfc);
        fDfY.Controls.Add(PDfy);
        fDfY.Location = new Point(6, Class13.AXBm);
        fDfY.Name = Class13.YXB0;
        fDfY.Size = new Size(Class13.MXBI, Class13.zXBR);
        fDfY.TabIndex = Class13.XXBC;
        fDfY.TabStop = false;
        fDfY.Text = Class13.QXBK;
        TDfB.Location = new Point(Class13.FXBU, Class13.FXBT);
        TDfB.Name = Class13.kXB1;
        TDfB.Size = new Size(Class13.DXBW, Class13.wXBw);
        TDfB.TabIndex = Class13.vXBN;
        TDfB.Text = Class13.EXBY;
        TDfB.UseVisualStyleBackColor = true;
        TDfB.Click += fDUo;
        JDfA.Location = new Point(Class13.bXBB, Class13.XXBA);
        JDfA.Name = Class13.eXBf;
        JDfA.Size = new Size(Class13.MXB6, Class13.HXBx);
        JDfA.TabIndex = Class13.pXB9;
        JDfA.Text = Class13.FXBc;
        JDfA.UseVisualStyleBackColor = true;
        JDfA.Click += UDUv;
        rDff.Location = new Point(Class13.NXBy, Class13.lXBr);
        rDff.Name = Class13.DXBq;
        rDff.Size = new Size(Class13.rXBk, Class13.OXBM);
        rDff.TabIndex = Class13.iXBu;
        rDff.Text = Class13.LXBg;
        rDff.UseVisualStyleBackColor = true;
        rDff.Click += NDUb;
        dDf6.Location = new Point(Class13.xXB2, Class13.gXB3);
        dDf6.Name = Class13.uXBd;
        dDf6.Size = new Size(Class13.oXBH, Class13.TXB4);
        dDf6.TabIndex = Class13.NXB5;
        dDf6.Text = Class13.eXBs;
        dDf6.UseVisualStyleBackColor = true;
        dDf6.Click += VDUG;
        oDfx.Location = new Point(Class13.vXBZ, Class13.tXBa);
        oDfx.Name = Class13.RXBj;
        oDfx.Size = new Size(Class13.pXBz, Class13.QXAE);
        oDfx.TabIndex = 8;
        oDfx.Text = Class13.XXAD;
        oDfx.UseVisualStyleBackColor = true;
        oDfx.Click += CDUl;
        aDf9.Location = new Point(Class13.DXAX, Class13.XXAp);
        aDf9.Name = Class13.TXAS;
        aDf9.Size = new Size(Class13.fXAh, Class13.uXAl);
        aDf9.TabIndex = 7;
        aDf9.Text = Class13.wXAG;
        aDf9.UseVisualStyleBackColor = true;
        aDf9.Click += VDUh;
        UDfc.Location = new Point(6, Class13.yXAb);
        UDfc.Name = Class13.RXAv;
        UDfc.Size = new Size(Class13.fXAo, Class13.VXAt);
        UDfc.TabIndex = 6;
        UDfc.Text = Class13.tXAV;
        UDfc.UseVisualStyleBackColor = true;
        UDfc.Click += yDUS;
        PDfy.Location = new Point(6, Class13.pXAO);
        PDfy.Name = Class13.BXAe;
        PDfy.Size = new Size(Class13.QXA8, Class13.SXAn);
        PDfy.TabIndex = 4;
        PDfy.Text = Class13.gXAQ;
        PDfy.UseVisualStyleBackColor = true;
        PDfy.Click += zDUp;
        qDfr.Controls.Add(HDfq);
        qDfr.Controls.Add(MDfk);
        qDfr.Controls.Add(nDfM);
        qDfr.Controls.Add(iDfu);
        qDfr.Location = new Point(6, Class13.nXAF);
        qDfr.Name = Class13.wXAL;
        qDfr.Size = new Size(Class13.mXAJ, Class13.XXA7);
        qDfr.TabIndex = 8;
        qDfr.TabStop = false;
        qDfr.Text = Class13.iXAP;
        HDfq.Location = new Point(6, Class13.tXAi);
        HDfq.Name = Class13.WXAm;
        HDfq.Size = new Size(Class13.BXA0, Class13.SXAI);
        HDfq.TabIndex = 3;
        HDfq.Text = Class13.jXAR;
        HDfq.UseVisualStyleBackColor = true;
        HDfq.Click += CDUD;
        MDfk.Location = new Point(Class13.sXAC, Class13.NXAK);
        MDfk.Name = Class13.JXAU;
        MDfk.Size = new Size(Class13.SXAT, Class13.WXA1);
        MDfk.TabIndex = 2;
        MDfk.Text = Class13.VXAW;
        MDfk.UseVisualStyleBackColor = true;
        MDfk.Click += BDUE;
        nDfM.Location = new Point(6, Class13.SXAw);
        nDfM.Name = Class13.JXAN;
        nDfM.Size = new Size(Class13.cXAY, Class13.PXAB);
        nDfM.TabIndex = 1;
        nDfM.Text = Class13.EXAA;
        nDfM.UseVisualStyleBackColor = true;
        nDfM.Click += TDKz;
        iDfu.Location = new Point(Class13.XXAf, Class13.hXA6);
        iDfu.Name = Class13.pXAx;
        iDfu.Size = new Size(Class13.FXA9, Class13.oXAc);
        iDfu.TabIndex = 0;
        iDfu.Text = Class13.mXAy;
        iDfu.UseVisualStyleBackColor = true;
        iDfu.Click += oDUX;
        EDBI.Location = new Point(Class13.tXAr, Class13.YXAq);
        EDBI.Name = Class13.aXAk;
        EDBI.Size = new Size(Class13.TXAM, Class13.DXAu);
        EDBI.TabIndex = 7;
        EDBI.Text = Class13.jXAg;
        EDBI.UseVisualStyleBackColor = true;
        EDBI.Click += uDCJ;
        gDB0.Location = new Point(Class13.WXA2, Class13.rXA3);
        gDB0.Name = Class13.qXAd;
        gDB0.Size = new Size(Class13.aXAH, Class13.BXA4);
        gDB0.TabIndex = 6;
        gDB0.Text = Class13.mXA5;
        gDB0.UseVisualStyleBackColor = true;
        gDB0.Click += tDC8;
        gDBm.Location = new Point(Class13.SXAs, Class13.HXAZ);
        gDBm.Name = Class13.VXAa;
        gDBm.Size = new Size(Class13.CXAj, Class13.vXAz);
        gDBm.TabIndex = 5;
        gDBm.Text = Class13.wXfE;
        gDBm.UseVisualStyleBackColor = true;
        gDBm.Click += SDCv;
        qDND.Location = new Point(Class13.YXfD, Class13.FXfX);
        qDND.Name = Class13.bXfp;
        qDND.Size = new Size(Class13.UXfS, Class13.UXfh);
        qDND.TabIndex = 4;
        qDND.Text = Class13.dXfl;
        qDND.UseVisualStyleBackColor = true;
        qDND.Click += vDIT;
        LDNE.Location = new Point(Class13.RXfG, Class13.rXfb);
        LDNE.Name = Class13.eXfv;
        LDNE.Size = new Size(Class13.QXfo, Class13.vXft);
        LDNE.TabIndex = 3;
        LDNE.Text = Class13.RXfV;
        LDNE.UseVisualStyleBackColor = true;
        LDNE.Click += xDIU;
        vDw4.Controls.Add(jDfN);
        vDw4.Controls.Add(fDw5);
        vDw4.Controls.Add(WDws);
        vDw4.Controls.Add(CDwZ);
        vDw4.Location = new Point(6, 6);
        vDw4.Name = Class13.rXfO;
        vDw4.Size = new Size(Class13.pXfe, Class13.XXf8);
        vDw4.TabIndex = 1;
        vDw4.TabStop = false;
        vDw4.Text = Class13.dXfn;
        jDfN.Location = new Point(Class13.kXfQ, Class13.cXfF);
        jDfN.Name = Class13.PXfL;
        jDfN.Size = new Size(Class13.EXfJ, Class13.eXf7);
        jDfN.TabIndex = 8;
        jDfN.Text = Class13.hXfP;
        jDfN.UseVisualStyleBackColor = true;
        jDfN.Click += aDKj;
        fDw5.Location = new Point(6, Class13.PXfi);
        fDw5.Name = Class13.uXfm;
        fDw5.Size = new Size(Class13.YXf0, Class13.uXfI);
        fDw5.TabIndex = 2;
        fDw5.Text = Class13.wXfR;
        fDw5.UseVisualStyleBackColor = true;
        fDw5.Click += gDIC;
        WDws.Location = new Point(Class13.SXfC, Class13.FXfK);
        WDws.Name = Class13.zXfU;
        WDws.Size = new Size(Class13.OXfT, Class13.aXf1);
        WDws.TabIndex = 1;
        WDws.Text = Class13.OXfW;
        WDws.UseVisualStyleBackColor = true;
        WDws.Click += SDIR;
        CDwZ.Location = new Point(6, Class13.NXfw);
        CDwZ.Name = Class13.vXfN;
        CDwZ.Size = new Size(Class13.LXfY, Class13.rXfB);
        CDwZ.TabIndex = 0;
        CDwZ.Text = Class13.oXfA;
        CDwZ.UseVisualStyleBackColor = true;
        CDwZ.Click += TDII;
        LDwa.Location = new Point(Class13.FXff, Class13.uXf6);
        LDwa.Name = Class13.XXfx;
        LDwa.Size = new Size(Class13.uXf9, Class13.vXfc);
        LDwa.TabIndex = 0;
        LDwa.Text = Class13.WXfy;
        LDwa.UseVisualStyleBackColor = true;
        LDwa.Click += GDIK;
        oDwu.Controls.Add(LDBt);
        oDwu.Controls.Add(LDBh);
        oDwu.Controls.Add(IDBD);
        oDwu.Controls.Add(TDYa);
        oDwu.Controls.Add(hDNd);
        oDwu.Location = new Point(4, Class13.IXfr);
        oDwu.Name = Class13.RXfq;
        oDwu.Padding = new Padding(3);
        oDwu.Size = new Size(Class13.pXfk, Class13.CXfM);
        oDwu.TabIndex = 1;
        oDwu.Text = Class13.UXfu;
        oDwu.UseVisualStyleBackColor = true;
        LDBt.Controls.Add(yDBi);
        LDBt.Controls.Add(WDBP);
        LDBt.Controls.Add(CDB7);
        LDBt.Controls.Add(hDBJ);
        LDBt.Controls.Add(RDBF);
        LDBt.Controls.Add(xDBL);
        LDBt.Controls.Add(rDBQ);
        LDBt.Controls.Add(iDBn);
        LDBt.Controls.Add(HDBV);
        LDBt.Location = new Point(6, Class13.HXfg);
        LDBt.Name = Class13.eXf2;
        LDBt.Size = new Size(Class13.OXf3, Class13.PXfd);
        LDBt.TabIndex = 5;
        LDBt.TabStop = false;
        LDBt.Text = Class13.cXfH;
        yDBi.Location = new Point(Class13.nXf4, Class13.yXf5);
        yDBi.Name = Class13.LXfs;
        yDBi.Size = new Size(Class13.lXfZ, Class13.uXfa);
        yDBi.TabIndex = 6;
        yDBi.Text = Class13.FXfj;
        yDBi.UseVisualStyleBackColor = true;
        yDBi.Click += VDCS;
        WDBP.Location = new Point(Class13.FXfz, Class13.TX6E);
        WDBP.Name = Class13.DX6D;
        WDBP.Size = new Size(Class13.FX6X, Class13.IX6p);
        WDBP.TabIndex = Class13.LX6S;
        WDBP.Text = Class13.FX6h;
        WDBP.UseVisualStyleBackColor = true;
        WDBP.Click += PDCp;
        CDB7.Location = new Point(6, Class13.qX6l);
        CDB7.Name = Class13.rX6G;
        CDB7.Size = new Size(Class13.AX6b, Class13.rX6v);
        CDB7.TabIndex = Class13.wX6o;
        CDB7.Text = Class13.fX6t;
        CDB7.UseVisualStyleBackColor = true;
        CDB7.Click += CDCX;
        hDBJ.Location = new Point(Class13.KX6V, Class13.hX6O);
        hDBJ.Name = Class13.BX6e;
        hDBJ.Size = new Size(Class13.JX68, Class13.BX6n);
        hDBJ.TabIndex = 8;
        hDBJ.Text = Class13.PX6Q;
        hDBJ.UseVisualStyleBackColor = true;
        hDBJ.Click += oDCD;
        RDBF.Location = new Point(Class13.mX6F, Class13.pX6L);
        RDBF.Name = Class13.lX6J;
        RDBF.Size = new Size(Class13.SX67, Class13.PX6P);
        RDBF.TabIndex = 7;
        RDBF.Text = Class13.eX6i;
        RDBF.UseVisualStyleBackColor = true;
        RDBF.Click += sDCE;
        xDBL.Location = new Point(6, Class13.PX6m);
        xDBL.Name = Class13.CX60;
        xDBL.Size = new Size(Class13.XX6I, Class13.HX6R);
        xDBL.TabIndex = 6;
        xDBL.Text = Class13.EX6C;
        xDBL.UseVisualStyleBackColor = true;
        rDBQ.Location = new Point(Class13.RX6K, Class13.QX6U);
        rDBQ.Name = Class13.CX6T;
        rDBQ.Size = new Size(Class13.wX61, Class13.aX6W);
        rDBQ.TabIndex = 5;
        rDBQ.Text = Class13.RX6w;
        rDBQ.UseVisualStyleBackColor = true;
        rDBQ.Click += YDRz;
        iDBn.Location = new Point(Class13.XX6N, Class13.JX6Y);
        iDBn.Name = Class13.JX6B;
        iDBn.Size = new Size(Class13.tX6A, Class13.cX6f);
        iDBn.TabIndex = 3;
        iDBn.Text = Class13.eX66;
        iDBn.UseVisualStyleBackColor = true;
        iDBn.Click += HDRj;
        HDBV.Location = new Point(6, Class13.yX6x);
        HDBV.Name = Class13.SX69;
        HDBV.Size = new Size(Class13.FX6c, Class13.KX6y);
        HDBV.TabIndex = 4;
        HDBV.Text = Class13.NX6r;
        HDBV.UseVisualStyleBackColor = true;
        HDBV.Click += YDRa;
        LDBh.Controls.Add(PDBo);
        LDBh.Controls.Add(uDBv);
        LDBh.Controls.Add(bDBb);
        LDBh.Controls.Add(JDBG);
        LDBh.Controls.Add(mDBl);
        LDBh.Location = new Point(Class13.dX6q, Class13.oX6k);
        LDBh.Name = Class13.EX6M;
        LDBh.Size = new Size(Class13.TX6u, Class13.kX6g);
        LDBh.TabIndex = 3;
        LDBh.TabStop = false;
        LDBh.Text = Class13.tX62;
        PDBo.Location = new Point(Class13.XX63, Class13.kX6d);
        PDBo.Name = Class13.hX6H;
        PDBo.Size = new Size(Class13.DX64, Class13.zX65);
        PDBo.TabIndex = 8;
        PDBo.Text = Class13.hX6s;
        PDBo.UseVisualStyleBackColor = true;
        PDBo.Click += yDR5;
        uDBv.Location = new Point(Class13.NX6Z, Class13.FX6a);
        uDBv.Name = Class13.LX6j;
        uDBv.Size = new Size(Class13.jX6z, Class13.OXxE);
        uDBv.TabIndex = 3;
        uDBv.Text = Class13.FXxD;
        uDBv.UseVisualStyleBackColor = true;
        uDBv.Click += BDR4;
        bDBb.Location = new Point(Class13.tXxX, Class13.jXxp);
        bDBb.Name = Class13.cXxS;
        bDBb.Size = new Size(Class13.uXxh, Class13.SXxl);
        bDBb.TabIndex = 5;
        bDBb.Text = Class13.cXxG;
        bDBb.UseVisualStyleBackColor = true;
        bDBb.Click += ADRH;
        JDBG.Location = new Point(Class13.jXxb, Class13.OXxv);
        JDBG.Name = Class13.sXxo;
        JDBG.Size = new Size(Class13.nXxt, Class13.oXxV);
        JDBG.TabIndex = 4;
        JDBG.Text = Class13.jXxO;
        JDBG.UseVisualStyleBackColor = true;
        JDBG.Click += TDRd;
        mDBl.Location = new Point(Class13.pXxe, Class13.XXx8);
        mDBl.Name = Class13.gXxn;
        mDBl.Size = new Size(Class13.GXxQ, Class13.qXxF);
        mDBl.TabIndex = 0;
        mDBl.Text = Class13.sXxL;
        mDBl.UseVisualStyleBackColor = true;
        mDBl.Click += HDR3;
        IDBD.Controls.Add(yDBS);
        IDBD.Controls.Add(gDBp);
        IDBD.Controls.Add(oDBX);
        IDBD.Location = new Point(6, Class13.kXxJ);
        IDBD.Name = Class13.lXx7;
        IDBD.Size = new Size(Class13.hXxP, Class13.sXxi);
        IDBD.TabIndex = 2;
        IDBD.TabStop = false;
        IDBD.Text = Class13.VXxm;
        yDBS.Location = new Point(Class13.EXx0, Class13.sXxI);
        yDBS.Name = Class13.yXxR;
        yDBS.Size = new Size(Class13.eXxC, Class13.qXxK);
        yDBS.TabIndex = 2;
        yDBS.Text = Class13.UXxU;
        yDBS.UseVisualStyleBackColor = true;
        yDBS.Click += IDR2;
        gDBp.Location = new Point(Class13.sXxT, Class13.uXx1);
        gDBp.Name = Class13.JXxW;
        gDBp.Size = new Size(Class13.gXxw, Class13.CXxN);
        gDBp.TabIndex = 1;
        gDBp.Text = Class13.fXxY;
        gDBp.UseVisualStyleBackColor = true;
        gDBp.Click += vDRg;
        oDBX.Location = new Point(6, Class13.OXxB);
        oDBX.Name = Class13.YXxA;
        oDBX.Size = new Size(Class13.IXxf, Class13.uXx6);
        oDBX.TabIndex = 0;
        oDBX.Text = Class13.bXxx;
        oDBX.UseVisualStyleBackColor = true;
        oDBX.Click += KDRu;
        TDYa.Controls.Add(RDBE);
        TDYa.Controls.Add(NDYz);
        TDYa.Controls.Add(cDYj);
        TDYa.Location = new Point(Class13.iXx9, 6);
        TDYa.Name = Class13.KXxc;
        TDYa.Size = new Size(Class13.yXxy, Class13.XXxr);
        TDYa.TabIndex = 1;
        TDYa.TabStop = false;
        TDYa.Text = Class13.KXxq;
        RDBE.Location = new Point(6, Class13.NXxk);
        RDBE.Name = Class13.NXxM;
        RDBE.Size = new Size(Class13.hXxu, Class13.oXxg);
        RDBE.TabIndex = 7;
        RDBE.Text = Class13.RXx2;
        RDBE.UseVisualStyleBackColor = true;
        RDBE.Click += RDRM;
        NDYz.Location = new Point(Class13.jXx3, Class13.uXxd);
        NDYz.Name = Class13.IXxH;
        NDYz.Size = new Size(Class13.dXx4, Class13.FXx5);
        NDYz.TabIndex = 6;
        NDYz.Text = Class13.RXxs;
        NDYz.UseVisualStyleBackColor = true;
        NDYz.Click += bDRk;
        cDYj.Location = new Point(6, Class13.GXxZ);
        cDYj.Name = Class13.RXxa;
        cDYj.Size = new Size(Class13.GXxj, Class13.MXxz);
        cDYj.TabIndex = 5;
        cDYj.Text = Class13.LX9E;
        cDYj.UseVisualStyleBackColor = true;
        cDYj.Click += iDRq;
        hDNd.Controls.Add(CDNH);
        hDNd.Location = new Point(6, 6);
        hDNd.Name = Class13.NX9D;
        hDNd.Size = new Size(Class13.AX9X, Class13.CX9p);
        hDNd.TabIndex = 0;
        hDNd.TabStop = false;
        hDNd.Text = Class13.rX9S;
        CDNH.Location = new Point(6, Class13.NX9h);
        CDNH.Name = Class13.GX9l;
        CDNH.Size = new Size(Class13.HX9G, Class13.zX9b);
        CDNH.TabIndex = 4;
        CDNH.Text = Class13.AX9v;
        CDNH.UseVisualStyleBackColor = true;
        CDNH.Click += SDIZ;
        eDwj.Controls.Add(qDY5);
        eDwj.Controls.Add(dDY3);
        eDwj.Controls.Add(qDYT);
        eDwj.Controls.Add(gDY0);
        eDwj.Controls.Add(QDY7);
        eDwj.Controls.Add(EDYV);
        eDwj.Controls.Add(FDYD);
        eDwj.Controls.Add(CDN4);
        eDwj.Location = new Point(4, Class13.JX9o);
        eDwj.Name = Class13.FX9t;
        eDwj.Padding = new Padding(3);
        eDwj.Size = new Size(Class13.aX9V, Class13.CX9O);
        eDwj.TabIndex = 2;
        eDwj.Text = Class13.TX9e;
        eDwj.UseVisualStyleBackColor = true;
        qDY5.Controls.Add(qDYs);
        qDY5.Controls.Add(LDYZ);
        qDY5.Location = new Point(Class13.nX98, Class13.nX9n);
        qDY5.Name = Class13.iX9Q;
        qDY5.Size = new Size(Class13.mX9F, Class13.UX9L);
        qDY5.TabIndex = Class13.xX9J;
        qDY5.TabStop = false;
        qDY5.Text = Class13.LX97;
        qDYs.Location = new Point(6, Class13.uX9P);
        qDYs.Name = Class13.KX9i;
        qDYs.Size = new Size(Class13.GX9m, Class13.KX90);
        qDYs.TabIndex = 1;
        qDYs.Text = Class13.NX9I;
        qDYs.UseVisualStyleBackColor = true;
        qDYs.Click += aDRr;
        LDYZ.Image = (Image)componentResourceManager.GetObject(Class13.BX9R);
        LDYZ.Location = new Point(Class13.UX9C, Class13.WX9K);
        LDYZ.Name = Class13.aX9U;
        LDYZ.Size = new Size(Class13.PX9T, Class13.yX91);
        LDYZ.TabIndex = 0;
        LDYZ.TabStop = false;
        dDY3.Controls.Add(kDYd);
        dDY3.Controls.Add(ADYH);
        dDY3.Controls.Add(xDY4);
        dDY3.Location = new Point(Class13.oX9W, Class13.YX9w);
        dDY3.Name = Class13.sX9N;
        dDY3.Size = new Size(Class13.yX9Y, Class13.kX9B);
        dDY3.TabIndex = Class13.BX9A;
        dDY3.TabStop = false;
        dDY3.Text = Class13.MX9f;
        kDYd.Location = new Point(Class13.qX96, Class13.WX9x);
        kDYd.Name = Class13.xX99;
        kDYd.Size = new Size(Class13.JX9c, Class13.TX9y);
        kDYd.TabIndex = Class13.iX9r;
        kDYd.Text = Class13.OX9q;
        kDYd.UseVisualStyleBackColor = true;
        kDYd.Click += KDRy;
        ADYH.Location = new Point(6, Class13.QX9k);
        ADYH.Name = Class13.kX9M;
        ADYH.Size = new Size(Class13.xX9u, Class13.VX9g);
        ADYH.TabIndex = Class13.sX92;
        ADYH.Text = Class13.xX93;
        ADYH.UseVisualStyleBackColor = true;
        ADYH.Click += kDRc;
        xDY4.Image = (Image)componentResourceManager.GetObject(Class13.vX9d);
        xDY4.Location = new Point(Class13.SX9H, Class13.vX94);
        xDY4.Name = Class13.LX95;
        xDY4.Size = new Size(Class13.oX9s, Class13.wX9Z);
        xDY4.TabIndex = Class13.bX9a;
        xDY4.TabStop = false;
        qDYT.Controls.Add(LDY2);
        qDYT.Controls.Add(SDYg);
        qDYT.Controls.Add(bDYu);
        qDYT.Controls.Add(bDYM);
        qDYT.Controls.Add(hDYk);
        qDYT.Controls.Add(LDYq);
        qDYT.Controls.Add(BDYr);
        qDYT.Controls.Add(oDYy);
        qDYT.Controls.Add(RDY9);
        qDYT.Controls.Add(uDYc);
        qDYT.Controls.Add(vDYx);
        qDYT.Controls.Add(rDY6);
        qDYT.Controls.Add(hDYf);
        qDYT.Controls.Add(bDYA);
        qDYT.Controls.Add(PDYB);
        qDYT.Controls.Add(UDYY);
        qDYT.Controls.Add(IDYN);
        qDYT.Controls.Add(DDYw);
        qDYT.Controls.Add(CDYW);
        qDYT.Controls.Add(GDY1);
        qDYT.Location = new Point(6, Class13.sX9j);
        qDYT.Name = Class13.GX9z;
        qDYT.Size = new Size(Class13.LXcE, Class13.wXcD);
        qDYT.TabIndex = Class13.bXcX;
        qDYT.TabStop = false;
        qDYT.Text = Class13.OXcp;
        LDY2.Location = new Point(Class13.mXcS, Class13.FXch);
        LDY2.Name = Class13.nXcl;
        LDY2.Size = new Size(Class13.HXcG, Class13.TXcb);
        LDY2.TabIndex = Class13.cXcv;
        LDY2.Text = Class13.CXco;
        LDY2.UseVisualStyleBackColor = true;
        LDY2.Click += MDR9;
        SDYg.Location = new Point(6, Class13.mXct);
        SDYg.Name = Class13.QXcV;
        SDYg.Size = new Size(Class13.jXcO, Class13.EXce);
        SDYg.TabIndex = Class13.cXc8;
        SDYg.Text = Class13.rXcn;
        SDYg.UseVisualStyleBackColor = true;
        SDYg.Click += vDRx;
        bDYu.Location = new Point(Class13.cXcQ, Class13.GXcF);
        bDYu.Name = Class13.gXcL;
        bDYu.Size = new Size(Class13.cXcJ, Class13.HXc7);
        bDYu.TabIndex = 3;
        bDYu.Text = Class13.bXcP;
        bDYu.UseVisualStyleBackColor = true;
        bDYu.Click += fDR6;
        bDYM.Location = new Point(Class13.wXci, Class13.TXcm);
        bDYM.Name = Class13.eXc0;
        bDYM.Size = new Size(Class13.fXcI, Class13.CXcR);
        bDYM.TabIndex = Class13.qXcC;
        bDYM.Text = Class13.wXcK;
        bDYM.UseVisualStyleBackColor = true;
        bDYM.Click += WDRf;
        hDYk.Location = new Point(Class13.HXcU, Class13.kXcT);
        hDYk.Name = Class13.fXc1;
        hDYk.Size = new Size(Class13.pXcW, Class13.dXcw);
        hDYk.TabIndex = Class13.qXcN;
        hDYk.Text = Class13.UXcY;
        hDYk.UseVisualStyleBackColor = true;
        hDYk.Click += ADRA;
        LDYq.Location = new Point(6, Class13.hXcB);
        LDYq.Name = Class13.sXcA;
        LDYq.Size = new Size(Class13.qXcf, Class13.dXc6);
        LDYq.TabIndex = Class13.tXcx;
        LDYq.Text = Class13.LXc9;
        LDYq.UseVisualStyleBackColor = true;
        LDYq.Click += UDRB;
        BDYr.Location = new Point(Class13.kXcc, Class13.pXcy);
        BDYr.Name = Class13.CXcr;
        BDYr.Size = new Size(Class13.KXcq, Class13.dXck);
        BDYr.TabIndex = Class13.hXcM;
        BDYr.Text = Class13.DXcu;
        BDYr.UseVisualStyleBackColor = true;
        BDYr.Click += RDRY;
        oDYy.Location = new Point(6, Class13.cXcg);
        oDYy.Name = Class13.RXc2;
        oDYy.Size = new Size(Class13.vXc3, Class13.zXcd);
        oDYy.TabIndex = Class13.yXcH;
        oDYy.Text = Class13.NXc4;
        oDYy.UseVisualStyleBackColor = true;
        oDYy.Click += aDRN;
        RDY9.Location = new Point(Class13.lXc5, Class13.QXcs);
        RDY9.Name = Class13.BXcZ;
        RDY9.Size = new Size(Class13.WXca, Class13.IXcj);
        RDY9.TabIndex = Class13.WXcz;
        RDY9.Text = Class13.CXyE;
        RDY9.UseVisualStyleBackColor = true;
        RDY9.Click += BDRw;
        uDYc.Location = new Point(Class13.YXyD, Class13.kXyX);
        uDYc.Name = Class13.lXyp;
        uDYc.Size = new Size(Class13.WXyS, Class13.mXyh);
        uDYc.TabIndex = Class13.MXyl;
        uDYc.Text = Class13.pXyG;
        uDYc.UseVisualStyleBackColor = true;
        uDYc.Click += jDRW;
        vDYx.Location = new Point(6, Class13.NXyb);
        vDYx.Name = Class13.yXyv;
        vDYx.Size = new Size(Class13.QXyo, Class13.YXyt);
        vDYx.TabIndex = 3;
        vDYx.Text = Class13.jXyV;
        vDYx.UseVisualStyleBackColor = true;
        vDYx.Click += NDR1;
        rDY6.Location = new Point(Class13.BXyO, Class13.lXye);
        rDY6.Name = Class13.bXy8;
        rDY6.Size = new Size(Class13.DXyn, Class13.mXyQ);
        rDY6.TabIndex = Class13.cXyF;
        rDY6.Text = Class13.FXyL;
        rDY6.UseVisualStyleBackColor = true;
        rDY6.Click += TDRT;
        hDYf.Location = new Point(6, Class13.qXyJ);
        hDYf.Name = Class13.IXy7;
        hDYf.Size = new Size(Class13.rXyP, Class13.GXyi);
        hDYf.TabIndex = Class13.wXym;
        hDYf.Text = Class13.EXy0;
        hDYf.UseVisualStyleBackColor = true;
        hDYf.Click += aDRU;
        bDYA.Location = new Point(Class13.bXyI, Class13.zXyR);
        bDYA.Name = Class13.lXyC;
        bDYA.Size = new Size(Class13.AXyK, Class13.KXyU);
        bDYA.TabIndex = Class13.iXyT;
        bDYA.Text = Class13.CXy1;
        bDYA.UseVisualStyleBackColor = true;
        bDYA.Click += gDRK;
        PDYB.Location = new Point(Class13.zXyW, Class13.pXyw);
        PDYB.Name = Class13.dXyN;
        PDYB.Size = new Size(Class13.CXyY, Class13.kXyB);
        PDYB.TabIndex = Class13.dXyA;
        PDYB.Text = Class13.UXyf;
        PDYB.UseVisualStyleBackColor = true;
        PDYB.Click += HDRC;
        UDYY.Location = new Point(6, Class13.qXy6);
        UDYY.Name = Class13.bXyx;
        UDYY.Size = new Size(Class13.lXy9, Class13.EXyc);
        UDYY.TabIndex = Class13.qXyy;
        UDYY.Text = Class13.iXyr;
        UDYY.UseVisualStyleBackColor = true;
        UDYY.Click += qDRR;
        IDYN.Location = new Point(Class13.SXyq, Class13.iXyk);
        IDYN.Name = Class13.NXyM;
        IDYN.Size = new Size(Class13.rXyu, Class13.kXyg);
        IDYN.TabIndex = Class13.KXy2;
        IDYN.Text = Class13.wXy3;
        IDYN.UseVisualStyleBackColor = true;
        IDYN.Click += hDRI;
        DDYw.Location = new Point(Class13.kXyd, Class13.pXyH);
        DDYw.Name = Class13.KXy4;
        DDYw.Size = new Size(Class13.CXy5, Class13.UXys);
        DDYw.TabIndex = Class13.RXyZ;
        DDYw.Text = Class13.PXya;
        DDYw.UseVisualStyleBackColor = true;
        DDYw.Click += VDR0;
        CDYW.Location = new Point(6, Class13.BXyj);
        CDYW.Name = Class13.CXyz;
        CDYW.Size = new Size(Class13.GXrE, Class13.hXrD);
        CDYW.TabIndex = 1;
        CDYW.Text = Class13.dXrX;
        CDYW.UseVisualStyleBackColor = true;
        CDYW.Click += hDRm;
        GDY1.Image = (Image)componentResourceManager.GetObject(Class13.mXrp);
        GDY1.Location = new Point(Class13.KXrS, Class13.bXrh);
        GDY1.Name = Class13.RXrl;
        GDY1.Size = new Size(Class13.qXrG, Class13.XXrb);
        GDY1.TabIndex = 0;
        GDY1.TabStop = false;
        gDY0.Controls.Add(MDYI);
        gDY0.Controls.Add(WDYR);
        gDY0.Controls.Add(fDYC);
        gDY0.Controls.Add(kDYK);
        gDY0.Location = new Point(Class13.dXrv, Class13.sXro);
        gDY0.Name = Class13.EXrt;
        gDY0.Size = new Size(Class13.kXrV, Class13.gXrO);
        gDY0.TabIndex = Class13.mXre;
        gDY0.TabStop = false;
        gDY0.Text = Class13.EXr8;
        MDYI.Location = new Point(Class13.xXrn, Class13.RXrQ);
        MDYI.Name = Class13.RXrF;
        MDYI.Size = new Size(Class13.GXrL, Class13.RXrJ);
        MDYI.TabIndex = Class13.FXr7;
        MDYI.Text = Class13.pXrP;
        MDYI.UseVisualStyleBackColor = true;
        MDYI.Click += pDRi;
        WDYR.Location = new Point(Class13.gXri, Class13.wXrm);
        WDYR.Name = Class13.EXr0;
        WDYR.Size = new Size(Class13.KXrI, Class13.QXrR);
        WDYR.TabIndex = Class13.xXrC;
        WDYR.Text = Class13.NXrK;
        WDYR.UseVisualStyleBackColor = true;
        WDYR.Click += mDRP;
        fDYC.Location = new Point(6, Class13.OXrU);
        fDYC.Name = Class13.uXrT;
        fDYC.Size = new Size(Class13.JXr1, Class13.tXrW);
        fDYC.TabIndex = Class13.pXrw;
        fDYC.Text = Class13.BXrN;
        fDYC.UseVisualStyleBackColor = true;
        fDYC.Click += aDR7;
        kDYK.Image = (Image)componentResourceManager.GetObject(Class13.LXrY);
        kDYK.Location = new Point(Class13.LXrB, Class13.jXrA);
        kDYK.Name = Class13.wXrf;
        kDYK.Size = new Size(Class13.JXr6, Class13.TXrx);
        kDYK.TabIndex = 0;
        kDYK.TabStop = false;
        QDY7.Controls.Add(cDYU);
        QDY7.Controls.Add(uDYm);
        QDY7.Controls.Add(WDYP);
        QDY7.Controls.Add(HDYi);
        QDY7.Location = new Point(Class13.tXr9, Class13.rXrc);
        QDY7.Name = Class13.vXry;
        QDY7.Size = new Size(Class13.RXrr, Class13.DXrq);
        QDY7.TabIndex = 4;
        QDY7.TabStop = false;
        QDY7.Text = Class13.yXrk;
        cDYU.Location = new Point(Class13.SXrM, Class13.mXru);
        cDYU.Name = Class13.EXrg;
        cDYU.Size = new Size(Class13.RXr2, Class13.KXr3);
        cDYU.TabIndex = Class13.eXrd;
        cDYU.Text = Class13.eXrH;
        cDYU.UseVisualStyleBackColor = true;
        uDYm.Location = new Point(Class13.FXr4, Class13.eXr5);
        uDYm.Name = Class13.KXrs;
        uDYm.Size = new Size(Class13.FXrZ, Class13.GXra);
        uDYm.TabIndex = Class13.DXrj;
        uDYm.Text = Class13.BXrz;
        uDYm.UseVisualStyleBackColor = true;
        uDYm.Click += YDRJ;
        WDYP.Location = new Point(6, Class13.QXqE);
        WDYP.Name = Class13.AXqD;
        WDYP.Size = new Size(Class13.IXqX, Class13.JXqp);
        WDYP.TabIndex = Class13.aXqS;
        WDYP.Text = Class13.dXqh;
        WDYP.UseVisualStyleBackColor = true;
        WDYP.Click += wDRL;
        HDYi.Image = (Image)componentResourceManager.GetObject(Class13.NXql);
        HDYi.Location = new Point(Class13.OXqG, Class13.GXqb);
        HDYi.Name = Class13.nXqv;
        HDYi.Size = new Size(Class13.yXqo, Class13.cXqt);
        HDYi.TabIndex = 0;
        HDYi.TabStop = false;
        EDYV.Controls.Add(ADYJ);
        EDYV.Controls.Add(gDYL);
        EDYV.Controls.Add(nDYF);
        EDYV.Controls.Add(NDYQ);
        EDYV.Controls.Add(ADYn);
        EDYV.Controls.Add(LDY8);
        EDYV.Controls.Add(lDYO);
        EDYV.Controls.Add(SDYe);
        EDYV.Location = new Point(6, Class13.qXqV);
        EDYV.Name = Class13.FXqO;
        EDYV.Size = new Size(Class13.TXqe, Class13.UXq8);
        EDYV.TabIndex = 3;
        EDYV.TabStop = false;
        EDYV.Text = Class13.WXqn;
        ADYJ.Location = new Point(Class13.pXqQ, Class13.IXqF);
        ADYJ.Name = Class13.HXqL;
        ADYJ.Size = new Size(Class13.EXqJ, Class13.nXq7);
        ADYJ.TabIndex = Class13.TXqP;
        ADYJ.Text = Class13.BXqi;
        ADYJ.UseVisualStyleBackColor = true;
        ADYJ.Click += vDRF;
        gDYL.Location = new Point(Class13.FXqm, Class13.nXq0);
        gDYL.Name = Class13.nXqI;
        gDYL.Size = new Size(Class13.NXqR, Class13.rXqC);
        gDYL.TabIndex = Class13.qXqK;
        gDYL.Text = Class13.IXqU;
        gDYL.UseVisualStyleBackColor = true;
        gDYL.Click += TDRQ;
        nDYF.Location = new Point(6, Class13.RXqT);
        nDYF.Name = Class13.lXq1;
        nDYF.Size = new Size(Class13.NXqW, Class13.DXqw);
        nDYF.TabIndex = Class13.sXqN;
        nDYF.Text = Class13.HXqY;
        nDYF.UseVisualStyleBackColor = true;
        nDYF.Click += YDRn;
        NDYQ.Location = new Point(6, Class13.lXqB);
        NDYQ.Name = Class13.UXqA;
        NDYQ.Size = new Size(Class13.aXqf, Class13.IXq6);
        NDYQ.TabIndex = Class13.QXqx;
        NDYQ.Text = Class13.kXq9;
        NDYQ.UseVisualStyleBackColor = true;
        NDYQ.Click += kDRe;
        ADYn.Location = new Point(Class13.nXqc, Class13.CXqy);
        ADYn.Name = Class13.iXqr;
        ADYn.Size = new Size(Class13.LXqq, Class13.iXqk);
        ADYn.TabIndex = Class13.RXqM;
        ADYn.Text = Class13.vXqu;
        ADYn.UseVisualStyleBackColor = true;
        ADYn.Click += bDR8;
        LDY8.Location = new Point(Class13.zXqg, Class13.kXq2);
        LDY8.Name = Class13.JXq3;
        LDY8.Size = new Size(Class13.SXqd, Class13.WXqH);
        LDY8.TabIndex = Class13.JXq4;
        LDY8.Text = Class13.TXq5;
        LDY8.UseVisualStyleBackColor = true;
        LDY8.Click += IDRO;
        lDYO.Location = new Point(6, Class13.QXqs);
        lDYO.Name = Class13.sXqZ;
        lDYO.Size = new Size(Class13.LXqa, Class13.kXqj);
        lDYO.TabIndex = Class13.dXqz;
        lDYO.Text = Class13.RXkE;
        lDYO.UseVisualStyleBackColor = true;
        lDYO.Click += sDRV;
        SDYe.Image = (Image)componentResourceManager.GetObject(Class13.WXkD);
        SDYe.Location = new Point(Class13.FXkX, Class13.aXkp);
        SDYe.Name = Class13.fXkS;
        SDYe.Size = new Size(Class13.KXkh, Class13.WXkl);
        SDYe.TabIndex = 0;
        SDYe.TabStop = false;
        FDYD.Controls.Add(IDYv);
        FDYD.Controls.Add(JDYG);
        FDYD.Controls.Add(hDYX);
        FDYD.Controls.Add(iDYp);
        FDYD.Controls.Add(lDYo);
        FDYD.Controls.Add(qDYt);
        FDYD.Controls.Add(jDYS);
        FDYD.Controls.Add(UDYh);
        FDYD.Controls.Add(qDYl);
        FDYD.Location = new Point(Class13.tXkG, 8);
        FDYD.Name = Class13.vXkb;
        FDYD.Size = new Size(Class13.sXkv, Class13.VXko);
        FDYD.TabIndex = 2;
        FDYD.TabStop = false;
        FDYD.Text = Class13.MXkt;
        IDYv.Location = new Point(6, Class13.GXkV);
        IDYv.Name = Class13.DXkO;
        IDYv.Size = new Size(Class13.SXke, Class13.kXk8);
        IDYv.TabIndex = Class13.WXkn;
        IDYv.Text = Class13.nXkQ;
        IDYv.UseVisualStyleBackColor = true;
        IDYv.Click += gDRh;
        JDYG.Location = new Point(Class13.zXkF, Class13.kXkL);
        JDYG.Name = Class13.JXkJ;
        JDYG.Size = new Size(Class13.SXk7, Class13.rXkP);
        JDYG.TabIndex = Class13.wXki;
        JDYG.Text = Class13.dXkm;
        JDYG.UseVisualStyleBackColor = true;
        JDYG.Click += sDRt;
        hDYX.Location = new Point(Class13.fXk0, Class13.tXkI);
        hDYX.Name = Class13.oXkR;
        hDYX.Size = new Size(Class13.FXkC, Class13.FXkK);
        hDYX.TabIndex = 8;
        hDYX.Text = Class13.nXkU;
        hDYX.UseVisualStyleBackColor = true;
        hDYX.Click += vDRb;
        iDYp.Location = new Point(6, Class13.SXkT);
        iDYp.Name = Class13.FXk1;
        iDYp.Size = new Size(Class13.fXkW, Class13.EXkw);
        iDYp.TabIndex = 7;
        iDYp.Text = Class13.pXkN;
        iDYp.UseVisualStyleBackColor = true;
        iDYp.Click += lDRl;
        lDYo.Location = new Point(Class13.wXkY, Class13.yXkB);
        lDYo.Name = Class13.IXkA;
        lDYo.Size = new Size(Class13.jXkf, Class13.fXk6);
        lDYo.TabIndex = 6;
        lDYo.Text = Class13.kXkx;
        lDYo.UseVisualStyleBackColor = true;
        lDYo.Click += QDRv;
        qDYt.Location = new Point(6, Class13.SXk9);
        qDYt.Name = Class13.mXkc;
        qDYt.Size = new Size(Class13.jXky, Class13.qXkr);
        qDYt.TabIndex = 5;
        qDYt.Text = Class13.LXkq;
        qDYt.UseVisualStyleBackColor = true;
        qDYt.Click += eDRo;
        jDYS.Location = new Point(Class13.PXkk, Class13.GXkM);
        jDYS.Name = Class13.tXku;
        jDYS.Size = new Size(Class13.LXkg, Class13.hXk2);
        jDYS.TabIndex = 4;
        jDYS.Text = Class13.FXk3;
        jDYS.UseVisualStyleBackColor = true;
        jDYS.Click += mDRp;
        UDYh.Location = new Point(Class13.zXkd, Class13.gXkH);
        UDYh.Name = Class13.aXk4;
        UDYh.Size = new Size(Class13.QXk5, Class13.vXks);
        UDYh.TabIndex = 3;
        UDYh.Text = Class13.WXkZ;
        UDYh.UseVisualStyleBackColor = true;
        qDYl.Image = (Image)componentResourceManager.GetObject(Class13.LXka);
        qDYl.Location = new Point(Class13.dXkj, Class13.QXkz);
        qDYl.Name = Class13.jXME;
        qDYl.Size = new Size(Class13.JXMD, Class13.MXMX);
        qDYl.TabIndex = 2;
        qDYl.TabStop = false;
        CDN4.Controls.Add(WDYb);
        CDN4.Controls.Add(cDYE);
        CDN4.Controls.Add(ADNz);
        CDN4.Controls.Add(TDNj);
        CDN4.Controls.Add(TDNa);
        CDN4.Controls.Add(aDNZ);
        CDN4.Controls.Add(ADNs);
        CDN4.Controls.Add(IDN5);
        CDN4.Controls.Add(iDN3);
        CDN4.Location = new Point(6, 8);
        CDN4.Name = Class13.mXMp;
        CDN4.Size = new Size(Class13.eXMS, Class13.aXMh);
        CDN4.TabIndex = 1;
        CDN4.TabStop = false;
        CDN4.Text = Class13.FXMl;
        WDYb.Location = new Point(Class13.vXMG, Class13.IXMb);
        WDYb.Name = Class13.RXMv;
        WDYb.Size = new Size(Class13.HXMo, Class13.sXMt);
        WDYb.TabIndex = Class13.jXMV;
        WDYb.Text = Class13.uXMO;
        WDYb.UseVisualStyleBackColor = true;
        WDYb.Click += WDRS;
        cDYE.Location = new Point(Class13.RXMe, Class13.zXM8);
        cDYE.Name = Class13.XXMn;
        cDYE.Size = new Size(Class13.UXMQ, Class13.IXMF);
        cDYE.TabIndex = 8;
        cDYE.Text = Class13.AXML;
        cDYE.UseVisualStyleBackColor = true;
        cDYE.Click += xDRX;
        ADNz.Location = new Point(6, Class13.UXMJ);
        ADNz.Name = Class13.eXM7;
        ADNz.Size = new Size(Class13.oXMP, Class13.kXMi);
        ADNz.TabIndex = 7;
        ADNz.Text = Class13.qXMm;
        ADNz.UseVisualStyleBackColor = true;
        ADNz.Click += lDRD;
        TDNj.Location = new Point(Class13.GXM0, Class13.kXMI);
        TDNj.Name = Class13.mXMR;
        TDNj.Size = new Size(Class13.FXMC, Class13.LXMK);
        TDNj.TabIndex = 6;
        TDNj.Text = Class13.jXMU;
        TDNj.UseVisualStyleBackColor = true;
        TDNj.Click += IDRE;
        TDNa.Location = new Point(6, Class13.NXMT);
        TDNa.Name = Class13.HXM1;
        TDNa.Size = new Size(Class13.DXMW, Class13.eXMw);
        TDNa.TabIndex = 5;
        TDNa.Text = Class13.mXMN;
        TDNa.UseVisualStyleBackColor = true;
        TDNa.Click += LDIz;
        aDNZ.Location = new Point(Class13.TXMY, Class13.JXMB);
        aDNZ.Name = Class13.hXMA;
        aDNZ.Size = new Size(Class13.gXMf, Class13.MXM6);
        aDNZ.TabIndex = 4;
        aDNZ.Text = Class13.uXMx;
        aDNZ.UseVisualStyleBackColor = true;
        aDNZ.Click += EDIj;
        ADNs.Location = new Point(Class13.hXM9, Class13.NXMc);
        ADNs.Name = Class13.NXMy;
        ADNs.Size = new Size(Class13.hXMr, Class13.lXMq);
        ADNs.TabIndex = 3;
        ADNs.Text = Class13.oXMk;
        ADNs.UseVisualStyleBackColor = true;
        ADNs.Click += PDIa;
        IDN5.Image = (Image)componentResourceManager.GetObject(Class13.OXMM);
        IDN5.Location = new Point(Class13.MXMu, Class13.rXMg);
        IDN5.Name = Class13.WXM2;
        IDN5.Size = new Size(Class13.BXM3, Class13.sXMd);
        IDN5.TabIndex = 2;
        IDN5.TabStop = false;
        iDN3.Location = new Point(6, Class13.nXMH);
        iDN3.Name = Class13.wXM4;
        iDN3.Size = new Size(Class13.DXM5, Class13.SXMs);
        iDN3.TabIndex = 0;
        iDN3.Text = Class13.qXMZ;
        iDN3.UseVisualStyleBackColor = true;
        iDN3.Click += FDIs;
        qDwz.Controls.Add(wDBO);
        qDwz.Controls.Add(aDNq);
        qDwz.Controls.Add(FDN6);
        qDwz.Controls.Add(ADNw);
        qDwz.Location = new Point(4, Class13.oXMa);
        qDwz.Name = Class13.XXMj;
        qDwz.Padding = new Padding(3);
        qDwz.Size = new Size(Class13.PXMz, Class13.nXuE);
        qDwz.TabIndex = 3;
        qDwz.Text = Class13.HXuD;
        qDwz.UseVisualStyleBackColor = true;
        wDBO.Controls.Add(eD64);
        wDBO.Controls.Add(WDBe);
        wDBO.Controls.Add(TDB8);
        wDBO.Location = new Point(Class13.vXuX, Class13.JXup);
        wDBO.Name = Class13.HXuS;
        wDBO.Size = new Size(Class13.JXuh, Class13.AXul);
        wDBO.TabIndex = 3;
        wDBO.TabStop = false;
        wDBO.Text = Class13.dXuG;
        eD64.Location = new Point(Class13.UXub, Class13.bXuv);
        eD64.Name = Class13.cXuo;
        eD64.Size = new Size(Class13.yXut, Class13.lXuV);
        eD64.TabIndex = 5;
        eD64.Text = Class13.BXuO;
        eD64.UseVisualStyleBackColor = true;
        eD64.Click += vDUf;
        WDBe.Location = new Point(Class13.rXue, Class13.IXu8);
        WDBe.Name = Class13.LXun;
        WDBe.Size = new Size(Class13.nXuQ, Class13.dXuF);
        WDBe.TabIndex = 4;
        WDBe.Text = Class13.lXuL;
        WDBe.UseVisualStyleBackColor = true;
        WDBe.Click += IDRZ;
        TDB8.Location = new Point(Class13.FXuJ, Class13.LXu7);
        TDB8.Name = Class13.zXuP;
        TDB8.Size = new Size(Class13.KXui, Class13.IXum);
        TDB8.TabIndex = 0;
        TDB8.Text = Class13.YXu0;
        TDB8.UseVisualStyleBackColor = true;
        TDB8.Click += YDRs;
        aDNq.Controls.Add(rDNk);
        aDNq.Controls.Add(uDNM);
        aDNq.Controls.Add(IDNu);
        aDNq.Controls.Add(WDNg);
        aDNq.Controls.Add(SDN2);
        aDNq.Location = new Point(Class13.qXuI, Class13.wXuR);
        aDNq.Name = Class13.nXuC;
        aDNq.Size = new Size(Class13.iXuK, Class13.aXuU);
        aDNq.TabIndex = 2;
        aDNq.TabStop = false;
        aDNq.Text = Class13.LXuT;
        rDNk.Location = new Point(Class13.FXu1, Class13.jXuW);
        rDNk.Name = Class13.dXuw;
        rDNk.Size = new Size(Class13.LXuN, Class13.QXuY);
        rDNk.TabIndex = Class13.EXuB;
        rDNk.Text = Class13.yXuA;
        rDNk.UseVisualStyleBackColor = true;
        rDNk.Click += ADI4;
        uDNM.Location = new Point(Class13.EXuf, Class13.wXu6);
        uDNM.Name = Class13.oXux;
        uDNM.Size = new Size(Class13.SXu9, Class13.AXuc);
        uDNM.TabIndex = Class13.jXuy;
        uDNM.Text = Class13.FXur;
        uDNM.UseVisualStyleBackColor = true;
        uDNM.Click += iDI5;
        IDNu.Location = new Point(6, Class13.SXuq);
        IDNu.Name = Class13.uXuk;
        IDNu.Size = new Size(Class13.YXuM, Class13.wXuu);
        IDNu.TabIndex = Class13.oXug;
        IDNu.Text = Class13.CXu2;
        IDNu.UseVisualStyleBackColor = true;
        IDNu.Click += RDI3;
        WDNg.Location = new Point(Class13.VXu3, Class13.rXud);
        WDNg.Name = Class13.gXuH;
        WDNg.Size = new Size(Class13.jXu4, Class13.JXu5);
        WDNg.TabIndex = Class13.jXus;
        WDNg.Text = Class13.mXuZ;
        WDNg.UseVisualStyleBackColor = true;
        WDNg.Click += SDIH;
        SDN2.Location = new Point(Class13.lXua, Class13.LXuj);
        SDN2.Name = Class13.tXuz;
        SDN2.Size = new Size(Class13.tXgE, Class13.xXgD);
        SDN2.TabIndex = Class13.QXgX;
        SDN2.Text = Class13.aXgp;
        SDN2.UseVisualStyleBackColor = true;
        SDN2.Click += XDId;
        FDN6.Controls.Add(uDNy);
        FDN6.Controls.Add(hDNr);
        FDN6.Controls.Add(ADNx);
        FDN6.Controls.Add(BDN9);
        FDN6.Controls.Add(ADNc);
        FDN6.Location = new Point(Class13.IXgS, 6);
        FDN6.Name = Class13.FXgh;
        FDN6.Size = new Size(Class13.eXgl, Class13.vXgG);
        FDN6.TabIndex = 1;
        FDN6.TabStop = false;
        FDN6.Text = Class13.DXgb;
        uDNy.Location = new Point(Class13.HXgv, Class13.FXgo);
        uDNy.Name = Class13.wXgt;
        uDNy.Size = new Size(Class13.FXgV, Class13.DXgO);
        uDNy.TabIndex = Class13.RXge;
        uDNy.Text = Class13.zXg8;
        uDNy.UseVisualStyleBackColor = true;
        uDNy.Click += ODI2;
        hDNr.Location = new Point(Class13.jXgn, Class13.CXgQ);
        hDNr.Name = Class13.aXgF;
        hDNr.Size = new Size(Class13.XXgL, Class13.dXgJ);
        hDNr.TabIndex = Class13.QXg7;
        hDNr.Text = Class13.xXgP;
        hDNr.UseVisualStyleBackColor = true;
        hDNr.Click += jDIg;
        ADNx.Location = new Point(Class13.xXgi, Class13.EXgm);
        ADNx.Name = Class13.UXg0;
        ADNx.Size = new Size(Class13.EXgI, Class13.tXgR);
        ADNx.TabIndex = 2;
        ADNx.Text = Class13.HXgC;
        ADNx.UseVisualStyleBackColor = true;
        ADNx.Click += tDIu;
        BDN9.Location = new Point(Class13.wXgK, Class13.XXgU);
        BDN9.Name = Class13.NXgT;
        BDN9.Size = new Size(Class13.jXg1, Class13.BXgW);
        BDN9.TabIndex = 1;
        BDN9.Text = Class13.BXgw;
        BDN9.UseVisualStyleBackColor = true;
        BDN9.Click += vDIM;
        ADNc.Location = new Point(Class13.mXgN, Class13.hXgY);
        ADNc.Name = Class13.aXgB;
        ADNc.Size = new Size(Class13.jXgA, Class13.zXgf);
        ADNc.TabIndex = 0;
        ADNc.Text = Class13.dXg6;
        ADNc.UseVisualStyleBackColor = true;
        ADNc.Click += qDIk;
        ADNw.Controls.Add(zDNA);
        ADNw.Controls.Add(kDNf);
        ADNw.Controls.Add(cDNN);
        ADNw.Controls.Add(iDNY);
        ADNw.Controls.Add(nDNB);
        ADNw.Location = new Point(Class13.BXgx, 6);
        ADNw.Name = Class13.YXg9;
        ADNw.Size = new Size(Class13.pXgc, Class13.eXgy);
        ADNw.TabIndex = 0;
        ADNw.TabStop = false;
        ADNw.Text = Class13.sXgr;
        zDNA.Location = new Point(Class13.mXgq, Class13.DXgk);
        zDNA.Name = Class13.vXgM;
        zDNA.Size = new Size(Class13.EXgu, Class13.jXgg);
        zDNA.TabIndex = Class13.QXg2;
        zDNA.Text = Class13.kXg3;
        zDNA.UseVisualStyleBackColor = true;
        zDNA.Click += kDIq;
        kDNf.Location = new Point(Class13.bXgd, Class13.PXgH);
        kDNf.Name = Class13.KXg4;
        kDNf.Size = new Size(Class13.VXg5, Class13.YXgs);
        kDNf.TabIndex = Class13.SXgZ;
        kDNf.Text = Class13.sXga;
        kDNf.UseVisualStyleBackColor = true;
        kDNf.Click += yDIr;
        cDNN.Location = new Point(6, Class13.YXgj);
        cDNN.Name = Class13.WXgz;
        cDNN.Size = new Size(Class13.MX2E, Class13.mX2D);
        cDNN.TabIndex = Class13.BX2X;
        cDNN.Text = Class13.yX2p;
        cDNN.UseVisualStyleBackColor = true;
        cDNN.Click += xDI9;
        iDNY.Location = new Point(Class13.PX2S, Class13.iX2h);
        iDNY.Name = Class13.qX2l;
        iDNY.Size = new Size(Class13.HX2G, Class13.FX2b);
        iDNY.TabIndex = Class13.fX2v;
        iDNY.Text = Class13.sX2o;
        iDNY.UseVisualStyleBackColor = true;
        iDNY.Click += FDIy;
        nDNB.Location = new Point(Class13.dX2t, Class13.GX2V);
        nDNB.Name = Class13.dX2O;
        nDNB.Size = new Size(Class13.bX2e, Class13.dX28);
        nDNB.TabIndex = Class13.jX2n;
        nDNB.Text = Class13.iX2Q;
        nDNB.UseVisualStyleBackColor = true;
        nDNB.Click += ODIc;
        wDwW.Location = new Point(3, Class13.DX2F);
        wDwW.Name = Class13.gX2L;
        wDwW.Size = new Size(Class13.JX2J, Class13.KX27);
        wDwW.TabIndex = 0;
        wDwW.Text = Class13.VX2P;
        wDwW.UseVisualStyleBackColor = true;
        wDwW.Click += qDIn;
        NDNp.Controls.Add(mDAr);
        NDNp.Controls.Add(IDAk);
        NDNp.Controls.Add(kDWn);
        NDNp.Location = new Point(4, Class13.mX2i);
        NDNp.Name = Class13.VX2m;
        NDNp.Padding = new Padding(3);
        NDNp.Size = new Size(Class13.OX20, Class13.qX2I);
        NDNp.TabIndex = 5;
        NDNp.Text = Class13.QX2R;
        NDNp.UseVisualStyleBackColor = true;
        mDAr.Dock = DockStyle.Fill;
        mDAr.Location = new Point(Class13.XX2C, 3);
        mDAr.Name = Class13.YX2K;
        mDAr.Size = new Size(Class13.UX2U, Class13.IX2T);
        mDAr.TabIndex = 1;
        mDAr.NodeMouseDoubleClick += EDKG;
        IDAk.ColumnCount = 3;
        IDAk.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Class13.eX21));
        IDAk.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Class13.JX2W));
        IDAk.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Class13.YX2w));
        IDAk.Controls.Add(DDAM, 0, 0);
        IDAk.Controls.Add(zDAu, 1, 0);
        IDAk.Controls.Add(TDAg, 2, 0);
        IDAk.Dock = DockStyle.Bottom;
        IDAk.Location = new Point(Class13.IX2N, Class13.QX2Y);
        IDAk.Name = Class13.BX2B;
        IDAk.RowCount = 1;
        IDAk.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.FX2A));
        IDAk.RowStyles.Add(new RowStyle(SizeType.Absolute, Class13.jX2f));
        IDAk.Size = new Size(Class13.NX26, Class13.xX2x);
        IDAk.TabIndex = 2;
        DDAM.Dock = DockStyle.Fill;
        DDAM.Location = new Point(3, 3);
        DDAM.Name = Class13.PX29;
        DDAM.Size = new Size(Class13.hX2c, Class13.DX2y);
        DDAM.TabIndex = 0;
        DDAM.Text = Class13.qX2r;
        DDAM.UseVisualStyleBackColor = true;
        DDAM.Click += NDKv;
        zDAu.Dock = DockStyle.Fill;
        zDAu.Location = new Point(Class13.TX2q, 3);
        zDAu.Name = Class13.pX2k;
        zDAu.Size = new Size(Class13.nX2M, Class13.JX2u);
        zDAu.TabIndex = 1;
        zDAu.Text = Class13.oX2g;
        zDAu.UseVisualStyleBackColor = true;
        zDAu.Click += GDKt;
        TDAg.Dock = DockStyle.Fill;
        TDAg.Location = new Point(Class13.vX22, 3);
        TDAg.Name = Class13.cX23;
        TDAg.Size = new Size(Class13.HX2d, Class13.RX2H);
        TDAg.TabIndex = 2;
        TDAg.Text = Class13.QX24;
        TDAg.UseVisualStyleBackColor = true;
        TDAg.Click += VDKo;
        kDWn.Dock = DockStyle.Left;
        kDWn.FormattingEnabled = true;
        ListBox.ObjectCollection items = kDWn.Items;
        object[] array = new object[Class13.kX25];
        array[0] = Class13.QX2s;
        array[1] = Class13.AX2Z;
        array[2] = Class13.iX2a;
        array[3] = Class13.IX2j;
        array[4] = Class13.XX2z;
        array[5] = Class13.cX3E;
        array[6] = Class13.wX3D;
        array[7] = Class13.hX3X;
        array[8] = Class13.cX3p;
        array[Class13.GX3S] = Class13.aX3h;
        array[Class13.KX3l] = Class13.SX3G;
        array[Class13.iX3b] = Class13.FX3v;
        array[Class13.VX3o] = Class13.yX3t;
        array[Class13.MX3V] = Class13.nX3O;
        array[Class13.bX3e] = Class13.GX38;
        array[Class13.HX3n] = Class13.aX3Q;
        array[Class13.kX3F] = Class13.zX3L;
        array[Class13.iX3J] = Class13.aX37;
        array[Class13.eX3P] = Class13.tX3i;
        array[Class13.fX3m] = Class13.vX30;
        array[Class13.KX3I] = Class13.cX3R;
        array[Class13.KX3C] = Class13.rX3K;
        array[Class13.jX3U] = Class13.jX3T;
        array[Class13.UX31] = Class13.bX3W;
        array[Class13.CX3w] = Class13.FX3N;
        array[Class13.cX3Y] = Class13.fX3B;
        array[Class13.tX3A] = Class13.QX3f;
        array[Class13.cX36] = Class13.IX3x;
        array[Class13.BX39] = Class13.UX3c;
        array[Class13.RX3y] = Class13.DX3r;
        array[Class13.xX3q] = Class13.TX3k;
        array[Class13.hX3M] = Class13.qX3u;
        array[Class13.VX3g] = Class13.QX32;
        array[Class13.JX33] = Class13.fX3d;
        array[Class13.WX3H] = Class13.vX34;
        array[Class13.cX35] = Class13.oX3s;
        array[Class13.XX3Z] = Class13.wX3a;
        array[Class13.GX3j] = Class13.rX3z;
        array[Class13.JXdE] = Class13.HXdD;
        array[Class13.fXdX] = Class13.hXdp;
        array[Class13.DXdS] = Class13.uXdh;
        array[Class13.WXdl] = Class13.UXdG;
        array[Class13.SXdb] = Class13.nXdv;
        array[Class13.QXdo] = Class13.RXdt;
        array[Class13.UXdV] = Class13.sXdO;
        array[Class13.BXde] = Class13.OXd8;
        array[Class13.iXdn] = Class13.OXdQ;
        array[Class13.cXdF] = Class13.HXdL;
        array[Class13.DXdJ] = Class13.OXd7;
        array[Class13.MXdP] = Class13.RXdi;
        array[Class13.cXdm] = Class13.OXd0;
        array[Class13.lXdI] = Class13.XXdR;
        array[Class13.NXdC] = Class13.gXdK;
        array[Class13.RXdU] = Class13.MXdT;
        array[Class13.NXd1] = Class13.QXdW;
        array[Class13.aXdw] = Class13.kXdN;
        array[Class13.tXdY] = Class13.pXdB;
        array[Class13.hXdA] = Class13.iXdf;
        array[Class13.MXd6] = Class13.sXdx;
        array[Class13.uXd9] = Class13.AXdc;
        array[Class13.rXdy] = Class13.FXdr;
        array[Class13.bXdq] = Class13.QXdk;
        array[Class13.nXdM] = Class13.jXdu;
        array[Class13.YXdg] = Class13.eXd2;
        array[Class13.qXd3] = Class13.CXdd;
        array[Class13.MXdH] = Class13.iXd4;
        array[Class13.NXd5] = Class13.nXds;
        array[Class13.AXdZ] = Class13.oXda;
        array[Class13.YXdj] = Class13.HXdz;
        array[Class13.HXHE] = Class13.zXHD;
        array[Class13.VXHX] = Class13.LXHp;
        array[Class13.MXHS] = Class13.CXHh;
        array[Class13.VXHl] = Class13.UXHG;
        array[Class13.MXHb] = Class13.tXHv;
        array[Class13.RXHo] = Class13.QXHt;
        array[Class13.AXHV] = Class13.QXHO;
        array[Class13.AXHe] = Class13.pXH8;
        array[Class13.sXHn] = Class13.WXHQ;
        array[Class13.DXHF] = Class13.dXHL;
        array[Class13.vXHJ] = Class13.EXH7;
        array[Class13.hXHP] = Class13.tXHi;
        array[Class13.HXHm] = Class13.AXH0;
        array[Class13.FXHI] = Class13.wXHR;
        array[Class13.WXHC] = Class13.yXHK;
        array[Class13.fXHU] = Class13.MXHT;
        array[Class13.PXH1] = Class13.VXHW;
        array[Class13.bXHw] = Class13.QXHN;
        array[Class13.HXHY] = Class13.sXHB;
        array[Class13.IXHA] = Class13.lXHf;
        array[Class13.mXH6] = Class13.eXHx;
        array[Class13.SXH9] = Class13.QXHc;
        array[Class13.YXHy] = Class13.HXHr;
        array[Class13.IXHq] = Class13.iXHk;
        array[Class13.EXHM] = Class13.NXHu;
        array[Class13.jXHg] = Class13.fXH2;
        array[Class13.KXH3] = Class13.SXHd;
        array[Class13.KXHH] = Class13.LXH4;
        array[Class13.TXH5] = Class13.TXHs;
        array[Class13.TXHZ] = Class13.RXHa;
        array[Class13.BXHj] = Class13.PXHz;
        array[Class13.lX4E] = Class13.GX4D;
        array[Class13.MX4X] = Class13.wX4p;
        array[Class13.oX4S] = Class13.qX4h;
        array[Class13.TX4l] = Class13.AX4G;
        array[Class13.QX4b] = Class13.bX4v;
        array[Class13.WX4o] = Class13.gX4t;
        array[Class13.SX4V] = Class13.PX4O;
        array[Class13.kX4e] = Class13.XX48;
        array[Class13.YX4n] = Class13.aX4Q;
        array[Class13.VX4F] = Class13.hX4L;
        array[Class13.VX4J] = Class13.EX47;
        array[Class13.qX4P] = Class13.oX4i;
        array[Class13.SX4m] = Class13.WX40;
        array[Class13.BX4I] = Class13.RX4R;
        array[Class13.tX4C] = Class13.lX4K;
        array[Class13.lX4U] = Class13.sX4T;
        array[Class13.SX41] = Class13.nX4W;
        array[Class13.sX4w] = Class13.JX4N;
        array[Class13.lX4Y] = Class13.rX4B;
        array[Class13.lX4A] = Class13.CX4f;
        array[Class13.GX46] = Class13.zX4x;
        array[Class13.rX49] = Class13.EX4c;
        array[Class13.PX4y] = Class13.OX4r;
        array[Class13.AX4q] = Class13.jX4k;
        array[Class13.oX4M] = Class13.RX4u;
        array[Class13.qX4g] = Class13.nX42;
        array[Class13.kX43] = Class13.BX4d;
        array[Class13.uX4H] = Class13.nX44;
        array[Class13.aX45] = Class13.uX4s;
        array[Class13.PX4Z] = Class13.FX4a;
        array[Class13.oX4j] = Class13.vX4z;
        array[Class13.vX5E] = Class13.NX5D;
        array[Class13.eX5X] = Class13.wX5p;
        array[Class13.LX5S] = Class13.VX5h;
        array[Class13.bX5l] = Class13.cX5G;
        array[Class13.lX5b] = Class13.pX5v;
        array[Class13.oX5o] = Class13.LX5t;
        array[Class13.KX5V] = Class13.CX5O;
        array[Class13.tX5e] = Class13.wX58;
        array[Class13.FX5n] = Class13.mX5Q;
        array[Class13.sX5F] = Class13.hX5L;
        array[Class13.vX5J] = Class13.KX57;
        array[Class13.UX5P] = Class13.pX5i;
        array[Class13.AX5m] = Class13.zX50;
        array[Class13.TX5I] = Class13.QX5R;
        array[Class13.cX5C] = Class13.mX5K;
        array[Class13.YX5U] = Class13.yX5T;
        array[Class13.rX51] = Class13.hX5W;
        array[Class13.sX5w] = Class13.SX5N;
        array[Class13.nX5Y] = Class13.hX5B;
        array[Class13.aX5A] = Class13.CX5f;
        array[Class13.XX56] = Class13.QX5x;
        array[Class13.bX59] = Class13.HX5c;
        array[Class13.sX5y] = Class13.oX5r;
        array[Class13.NX5q] = Class13.vX5k;
        array[Class13.JX5M] = Class13.qX5u;
        array[Class13.TX5g] = Class13.bX52;
        array[Class13.lX53] = Class13.BX5d;
        array[Class13.CX5H] = Class13.CX54;
        array[Class13.qX55] = Class13.xX5s;
        array[Class13.fX5Z] = Class13.YX5a;
        array[Class13.RX5j] = Class13.hX5z;
        array[Class13.nXsE] = Class13.QXsD;
        array[Class13.zXsX] = Class13.NXsp;
        array[Class13.RXsS] = Class13.jXsh;
        array[Class13.vXsl] = Class13.LXsG;
        array[Class13.bXsb] = Class13.BXsv;
        array[Class13.DXso] = Class13.lXst;
        array[Class13.wXsV] = Class13.AXsO;
        array[Class13.HXse] = Class13.GXs8;
        array[Class13.wXsn] = Class13.fXsQ;
        array[Class13.uXsF] = Class13.vXsL;
        array[Class13.zXsJ] = Class13.RXs7;
        array[Class13.eXsP] = Class13.bXsi;
        array[Class13.uXsm] = Class13.VXs0;
        array[Class13.JXsI] = Class13.pXsR;
        array[Class13.bXsC] = Class13.oXsK;
        array[Class13.BXsU] = Class13.PXsT;
        array[Class13.oXs1] = Class13.RXsW;
        array[Class13.AXsw] = Class13.EXsN;
        array[Class13.jXsY] = Class13.WXsB;
        array[Class13.uXsA] = Class13.VXsf;
        array[Class13.uXs6] = Class13.SXsx;
        array[Class13.QXs9] = Class13.MXsc;
        array[Class13.pXsy] = Class13.GXsr;
        array[Class13.jXsq] = Class13.GXsk;
        array[Class13.wXsM] = Class13.mXsu;
        array[Class13.tXsg] = Class13.tXs2;
        array[Class13.jXs3] = Class13.xXsd;
        array[Class13.VXsH] = Class13.NXs4;
        array[Class13.mXs5] = Class13.CXss;
        array[Class13.xXsZ] = Class13.iXsa;
        array[Class13.uXsj] = Class13.yXsz;
        array[Class13.JXZE] = Class13.uXZD;
        array[Class13.kXZX] = Class13.MXZp;
        array[Class13.WXZS] = Class13.eXZh;
        array[Class13.hXZl] = Class13.lXZG;
        array[Class13.JXZb] = Class13.iXZv;
        array[Class13.oXZo] = Class13.FXZt;
        array[Class13.XXZV] = Class13.aXZO;
        array[Class13.cXZe] = Class13.tXZ8;
        array[Class13.OXZn] = Class13.dXZQ;
        array[Class13.NXZF] = Class13.RXZL;
        array[Class13.RXZJ] = Class13.bXZ7;
        array[Class13.RXZP] = Class13.yXZi;
        array[Class13.TXZm] = Class13.tXZ0;
        array[Class13.pXZI] = Class13.CXZR;
        array[Class13.SXZC] = Class13.bXZK;
        array[Class13.hXZU] = Class13.GXZT;
        array[Class13.LXZ1] = Class13.kXZW;
        array[Class13.dXZw] = Class13.LXZN;
        array[Class13.yXZY] = Class13.zXZB;
        array[Class13.AXZA] = Class13.DXZf;
        array[Class13.UXZ6] = Class13.oXZx;
        array[Class13.KXZ9] = Class13.iXZc;
        array[Class13.eXZy] = Class13.eXZr;
        array[Class13.TXZq] = Class13.fXZk;
        array[Class13.SXZM] = Class13.oXZu;
        array[Class13.XXZg] = Class13.WXZ2;
        array[Class13.aXZ3] = Class13.qXZd;
        array[Class13.hXZH] = Class13.UXZ4;
        array[Class13.RXZ5] = Class13.YXZs;
        array[Class13.bXZZ] = Class13.SXZa;
        array[Class13.gXZj] = Class13.qXZz;
        array[Class13.dXaE] = Class13.DXaD;
        array[Class13.tXaX] = Class13.SXap;
        array[Class13.rXaS] = Class13.aXah;
        array[Class13.wXal] = Class13.OXaG;
        array[Class13.dXab] = Class13.kXav;
        array[Class13.tXao] = Class13.wXat;
        array[Class13.nXaV] = Class13.JXaO;
        array[Class13.hXae] = Class13.xXa8;
        array[Class13.PXan] = Class13.kXaQ;
        array[Class13.NXaF] = Class13.LXaL;
        array[Class13.hXaJ] = Class13.kXa7;
        array[Class13.TXaP] = Class13.kXai;
        array[Class13.uXam] = Class13.gXa0;
        array[Class13.hXaI] = Class13.VXaR;
        array[Class13.aXaC] = Class13.kXaK;
        array[Class13.GXaU] = Class13.LXaT;
        array[Class13.AXa1] = Class13.mXaW;
        array[Class13.vXaw] = Class13.lXaN;
        array[Class13.HXaY] = Class13.KXaB;
        array[Class13.VXaA] = Class13.yXaf;
        array[Class13.vXa6] = Class13.gXax;
        array[Class13.cXa9] = Class13.HXac;
        array[Class13.SXay] = Class13.DXar;
        array[Class13.nXaq] = Class13.HXak;
        array[Class13.HXaM] = Class13.fXau;
        array[Class13.hXag] = Class13.YXa2;
        array[Class13.NXa3] = Class13.hXad;
        array[Class13.HXaH] = Class13.sXa4;
        array[Class13.fXa5] = Class13.GXas;
        array[Class13.cXaZ] = Class13.DXaa;
        array[Class13.lXaj] = Class13.aXaz;
        array[Class13.qXjE] = Class13.nXjD;
        array[Class13.GXjX] = Class13.BXjp;
        array[Class13.uXjS] = Class13.FXjh;
        array[Class13.HXjl] = Class13.cXjG;
        array[Class13.UXjb] = Class13.jXjv;
        array[Class13.KXjo] = Class13.OXjt;
        array[Class13.yXjV] = Class13.iXjO;
        array[Class13.NXje] = Class13.eXj8;
        array[Class13.NXjn] = Class13.MXjQ;
        array[Class13.hXjF] = Class13.iXjL;
        array[Class13.FXjJ] = Class13.KXj7;
        array[Class13.nXjP] = Class13.sXji;
        array[Class13.kXjm] = Class13.DXj0;
        array[Class13.tXjI] = Class13.AXjR;
        array[Class13.SXjC] = Class13.uXjK;
        array[Class13.LXjU] = Class13.aXjT;
        array[Class13.YXj1] = Class13.DXjW;
        array[Class13.CXjw] = Class13.sXjN;
        array[Class13.OXjY] = Class13.HXjB;
        array[Class13.mXjA] = Class13.QXjf;
        array[Class13.nXj6] = Class13.oXjx;
        array[Class13.XXj9] = Class13.VXjc;
        array[Class13.iXjy] = Class13.gXjr;
        array[Class13.eXjq] = Class13.JXjk;
        array[Class13.PXjM] = Class13.EXju;
        array[Class13.TXjg] = Class13.JXj2;
        array[Class13.oXj3] = Class13.BXjd;
        array[Class13.iXjH] = Class13.kXj4;
        array[Class13.oXj5] = Class13.AXjs;
        array[Class13.FXjZ] = Class13.GXja;
        array[Class13.VXjj] = Class13.xXjz;
        array[Class13.GXzE] = Class13.NXzD;
        array[Class13.NXzX] = Class13.mXzp;
        array[Class13.iXzS] = Class13.PXzh;
        array[Class13.yXzl] = Class13.DXzG;
        array[Class13.tXzb] = Class13.XXzv;
        array[Class13.sXzo] = Class13.jXzt;
        array[Class13.JXzV] = Class13.FXzO;
        array[Class13.iXze] = Class13.EXz8;
        array[Class13.zXzn] = Class13.MXzQ;
        array[Class13.cXzF] = Class13.TXzL;
        array[Class13.uXzJ] = Class13.RXz7;
        array[Class13.iXzP] = Class13.zXzi;
        array[Class13.DXzm] = Class13.wXz0;
        array[Class13.yXzI] = Class13.oXzR;
        array[Class13.NXzC] = Class13.aXzK;
        array[Class13.NXzU] = Class13.FXzT;
        array[Class13.NXz1] = Class13.OXzW;
        array[Class13.eXzw] = Class13.IXzN;
        array[Class13.nXzY] = Class13.sXzB;
        array[Class13.CXzA] = Class13.rXzf;
        array[Class13.UXz6] = Class13.BXzx;
        array[Class13.aXz9] = Class13.DXzc;
        array[Class13.hXzy] = Class13.wXzr;
        array[Class13.WXzq] = Class13.QXzk;
        array[Class13.aXzM] = Class13.SXzu;
        array[Class13.XXzg] = Class13.fXz2;
        array[Class13.yXz3] = Class13.HXzd;
        array[Class13.hXzH] = Class13.HXz4;
        array[Class13.XXz5] = Class13.hXzs;
        array[Class13.vXzZ] = Class13.NXza;
        array[Class13.QXzj] = Class13.zXzz;
        array[Class13.XpEE] = Class13.xpED;
        array[Class13.tpEX] = Class13.apEp;
        array[Class13.LpES] = Class13.XpEh;
        array[Class13.hpEl] = Class13.MpEG;
        array[Class13.epEb] = Class13.rpEv;
        array[Class13.TpEo] = Class13.FpEt;
        array[Class13.upEV] = Class13.EpEO;
        array[Class13.NpEe] = Class13.RpE8;
        array[Class13.PpEn] = Class13.bpEQ;
        array[Class13.NpEF] = Class13.spEL;
        array[Class13.mpEJ] = Class13.tpE7;
        array[Class13.apEP] = Class13.lpEi;
        array[Class13.FpEm] = Class13.PpE0;
        array[Class13.BpEI] = Class13.opER;
        array[Class13.EpEC] = Class13.bpEK;
        array[Class13.GpEU] = Class13.ppET;
        array[Class13.bpE1] = Class13.ipEW;
        array[Class13.jpEw] = Class13.mpEN;
        array[Class13.fpEY] = Class13.HpEB;
        array[Class13.kpEA] = Class13.qpEf;
        array[Class13.kpE6] = Class13.UpEx;
        array[Class13.zpE9] = Class13.DpEc;
        array[Class13.ApEy] = Class13.PpEr;
        items.AddRange(array);
        kDWn.Location = new Point(3, 3);
        kDWn.Name = Class13.RpEq;
        kDWn.Size = new Size(Class13.YpEk, Class13.EpEM);
        kDWn.TabIndex = 0;
        kDWn.SelectedIndexChanged += FDKl;
        kDWn.DoubleClick += BDKh;
        OD6K.Controls.Add(PD6r);
        OD6K.Controls.Add(ID69);
        OD6K.Controls.Add(WD6U);
        OD6K.Location = new Point(4, Class13.cpEu);
        OD6K.Name = Class13.ppEg;
        OD6K.Padding = new Padding(3);
        OD6K.Size = new Size(Class13.kpE2, Class13.npE3);
        OD6K.TabIndex = 7;
        OD6K.Text = Class13.ipEd;
        OD6K.UseVisualStyleBackColor = true;
        PD6r.Controls.Add(fD6d);
        PD6r.Controls.Add(mD63);
        PD6r.Controls.Add(hD62);
        PD6r.Controls.Add(zD6g);
        PD6r.Controls.Add(GD6u);
        PD6r.Controls.Add(YD6k);
        PD6r.Controls.Add(eD6q);
        PD6r.Location = new Point(Class13.WpEH, Class13.CpE4);
        PD6r.Name = Class13.BpE5;
        PD6r.Size = new Size(Class13.dpEs, Class13.KpEZ);
        PD6r.TabIndex = 8;
        PD6r.TabStop = false;
        PD6r.Text = Class13.ipEa;
        fD6d.Location = new Point(Class13.spEj, Class13.RpEz);
        fD6d.Name = Class13.JpDE;
        fD6d.Size = new Size(Class13.epDD, Class13.WpDX);
        fD6d.TabIndex = Class13.FpDp;
        fD6d.Text = Class13.CpDS;
        fD6d.UseVisualStyleBackColor = true;
        fD6d.Click += fDUU;
        mD63.Location = new Point(Class13.epDh, Class13.EpDl);
        mD63.Name = Class13.RpDG;
        mD63.Size = new Size(Class13.vpDb, Class13.wpDv);
        mD63.TabIndex = Class13.zpDo;
        mD63.Text = Class13.RpDt;
        mD63.UseVisualStyleBackColor = true;
        mD63.Click += HDUK;
        hD62.Location = new Point(6, Class13.EpDV);
        hD62.Name = Class13.ppDO;
        hD62.Size = new Size(Class13.rpDe, Class13.TpD8);
        hD62.TabIndex = Class13.epDn;
        hD62.Text = Class13.gpDQ;
        hD62.UseVisualStyleBackColor = true;
        hD62.Click += iDUC;
        zD6g.Location = new Point(6, Class13.IpDF);
        zD6g.Name = Class13.dpDL;
        zD6g.Size = new Size(Class13.ppDJ, Class13.cpD7);
        zD6g.TabIndex = Class13.wpDP;
        zD6g.Text = Class13.qpDi;
        zD6g.UseVisualStyleBackColor = true;
        zD6g.Click += jDUR;
        GD6u.Location = new Point(Class13.ipDm, Class13.IpD0);
        GD6u.Name = Class13.bpDI;
        GD6u.Size = new Size(Class13.dpDR, Class13.epDC);
        GD6u.TabIndex = Class13.UpDK;
        GD6u.Text = Class13.GpDU;
        GD6u.UseVisualStyleBackColor = true;
        GD6u.Click += qDUI;
        YD6k.DropDownStyle = ComboBoxStyle.DropDownList;
        YD6k.FormattingEnabled = true;
        YD6k.Items.AddRange(new object[3] { Class13.xpDT, Class13.VpD1, Class13.BpDW });
        YD6k.Location = new Point(6, Class13.epDw);
        YD6k.Name = Class13.npDN;
        YD6k.Size = new Size(Class13.opDY, Class13.JpDB);
        YD6k.TabIndex = Class13.DpDA;
        eD6q.Location = new Point(Class13.PpDf, Class13.OpD6);
        eD6q.Name = Class13.TpDx;
        eD6q.Size = new Size(Class13.ypD9, Class13.mpDc);
        eD6q.TabIndex = 0;
        eD6q.Text = Class13.WpDy;
        eD6q.UseVisualStyleBackColor = true;
        eD6q.Click += hDUm;
        ID69.Location = new Point(Class13.kpDr, Class13.apDq);
        ID69.Name = Class13.OpDk;
        ID69.Size = new Size(Class13.NpDM, Class13.IpDu);
        ID69.TabIndex = 7;
        ID69.Text = Class13.spDg;
        ID69.UseVisualStyleBackColor = true;
        ID69.Click += sDUi;
        WD6U.Controls.Add(DD6T);
        WD6U.Controls.Add(bD61);
        WD6U.Controls.Add(ND6W);
        WD6U.Controls.Add(pD6w);
        WD6U.Controls.Add(qD6N);
        WD6U.Controls.Add(UD6Y);
        WD6U.Controls.Add(KD6B);
        WD6U.Controls.Add(hD6A);
        WD6U.Controls.Add(HD6f);
        WD6U.Controls.Add(nD66);
        WD6U.Location = new Point(Class13.ypD2, Class13.upD3);
        WD6U.Name = Class13.cpDd;
        WD6U.Size = new Size(Class13.tpDH, Class13.EpD4);
        WD6U.TabIndex = 6;
        WD6U.TabStop = false;
        WD6U.Text = Class13.mpD5;
        DD6T.AutoSize = true;
        DD6T.Font = new Font(Class13.vpDs, Class13.LpDZ, FontStyle.Regular, GraphicsUnit.Point, 0);
        DD6T.ForeColor = SystemColors.ControlDarkDark;
        DD6T.Location = new Point(Class13.DpDa, Class13.WpDj);
        DD6T.Name = Class13.LpDz;
        DD6T.Size = new Size(Class13.kpXE, Class13.ApXD);
        DD6T.TabIndex = Class13.YpXX;
        DD6T.Text = Class13.fpXp;
        bD61.AutoSize = true;
        bD61.Font = new Font(Class13.YpXS, Class13.MpXh, FontStyle.Regular, GraphicsUnit.Point, 0);
        bD61.ForeColor = SystemColors.ControlDarkDark;
        bD61.Location = new Point(Class13.IpXl, Class13.LpXG);
        bD61.Name = Class13.mpXb;
        bD61.Size = new Size(Class13.epXv, Class13.NpXo);
        bD61.TabIndex = Class13.npXt;
        bD61.Text = Class13.ppXV;
        ND6W.AutoSize = true;
        ND6W.Font = new Font(Class13.dpXO, Class13.dpXe, FontStyle.Regular, GraphicsUnit.Point, 0);
        ND6W.ForeColor = SystemColors.ControlDarkDark;
        ND6W.Location = new Point(Class13.ApX8, Class13.hpXn);
        ND6W.Name = Class13.vpXQ;
        ND6W.Size = new Size(Class13.CpXF, Class13.SpXL);
        ND6W.TabIndex = 7;
        ND6W.Text = Class13.BpXJ;
        pD6w.Location = new Point(Class13.MpX7, Class13.GpXP);
        pD6w.Name = Class13.HpXi;
        pD6w.Size = new Size(Class13.TpXm, Class13.dpX0);
        pD6w.TabIndex = Class13.DpXI;
        pD6w.Text = Class13.cpXR;
        pD6w.UseVisualStyleBackColor = true;
        pD6w.Click += yDUJ;
        qD6N.Location = new Point(Class13.YpXC, Class13.RpXK);
        qD6N.Name = Class13.upXU;
        qD6N.Size = new Size(Class13.dpXT, Class13.xpX1);
        qD6N.TabIndex = Class13.CpXW;
        qD6N.Text = Class13.lpXw;
        qD6N.UseVisualStyleBackColor = true;
        qD6N.Click += CDUL;
        UD6Y.Location = new Point(Class13.epXN, Class13.JpXY);
        UD6Y.Name = Class13.upXB;
        UD6Y.Size = new Size(Class13.BpXA, Class13.rpXf);
        UD6Y.TabIndex = 8;
        UD6Y.Text = Class13.xpX6;
        UD6Y.UseVisualStyleBackColor = true;
        UD6Y.Click += rDUF;
        KD6B.BackColor = SystemColors.ButtonShadow;
        KD6B.Enabled = false;
        KD6B.Location = new Point(Class13.lpXx, Class13.XpX9);
        KD6B.Name = Class13.upXc;
        KD6B.Size = new Size(Class13.wpXy, Class13.vpXr);
        KD6B.TabIndex = 7;
        hD6A.BackColor = SystemColors.ButtonShadow;
        hD6A.Enabled = false;
        hD6A.Location = new Point(Class13.zpXq, Class13.spXk);
        hD6A.Name = Class13.hpXM;
        hD6A.Size = new Size(Class13.rpXu, Class13.ApXg);
        hD6A.TabIndex = 6;
        HD6f.BackColor = SystemColors.ButtonShadow;
        HD6f.Enabled = false;
        HD6f.Location = new Point(Class13.CpX2, Class13.wpX3);
        HD6f.Name = Class13.apXd;
        HD6f.Size = new Size(Class13.IpXH, Class13.CpX4);
        HD6f.TabIndex = 5;
        nD66.Location = new Point(Class13.spX5, Class13.MpXs);
        nD66.Name = Class13.TpXZ;
        nD66.Size = new Size(Class13.xpXa, Class13.WpXj);
        nD66.TabIndex = 3;
        nD66.Text = Class13.GpXz;
        nD66.UseVisualStyleBackColor = true;
        nD66.Click += zDU3;
        oD18.Controls.Add(iD1n);
        oD18.Location = new Point(4, Class13.WppE);
        oD18.Name = Class13.DppD;
        oD18.Padding = new Padding(3);
        oD18.Size = new Size(Class13.OppX, Class13.xppp);
        oD18.TabIndex = 1;
        oD18.Text = Class13.CppS;
        oD18.UseVisualStyleBackColor = true;
        iD1n.Controls.Add(kD1Q);
        iD1n.Controls.Add(hD11);
        iD1n.Controls.Add(TDBg);
        iD1n.Dock = DockStyle.Fill;
        iD1n.Location = new Point(3, 3);
        iD1n.Name = Class13.Mpph;
        iD1n.SelectedIndex = 0;
        iD1n.Size = new Size(Class13.uppl, Class13.XppG);
        iD1n.TabIndex = Class13.lppb;
        iD1n.SelectedIndexChanged += hDCf;
        kD1Q.Controls.Add(xDA0);
        kD1Q.Controls.Add(MDAR);
        kD1Q.Controls.Add(CDAi);
        kD1Q.Controls.Add(vDBk);
        kD1Q.Controls.Add(xDBM);
        kD1Q.Controls.Add(MD1F);
        kD1Q.Controls.Add(oD1L);
        kD1Q.Controls.Add(vD1J);
        kD1Q.Controls.Add(hD17);
        kD1Q.Controls.Add(FD1U);
        kD1Q.Controls.Add(nD1T);
        kD1Q.Location = new Point(4, Class13.Cppv);
        kD1Q.Name = Class13.wppo;
        kD1Q.Padding = new Padding(3);
        kD1Q.Size = new Size(Class13.ippt, Class13.KppV);
        kD1Q.TabIndex = 0;
        kD1Q.Text = Class13.cppO;
        kD1Q.UseVisualStyleBackColor = true;
        xDA0.Controls.Add(bD6E);
        xDA0.Controls.Add(XDAU);
        xDA0.Controls.Add(oDAT);
        xDA0.Controls.Add(ODA1);
        xDA0.Controls.Add(bDAW);
        xDA0.Controls.Add(zDAw);
        xDA0.Controls.Add(TDAN);
        xDA0.Controls.Add(VDAY);
        xDA0.Controls.Add(BDAB);
        xDA0.Controls.Add(mDAI);
        xDA0.Location = new Point(Class13.Lppe, Class13.Mpp8);
        xDA0.Name = Class13.jppn;
        xDA0.Size = new Size(Class13.WppQ, Class13.FppF);
        xDA0.TabIndex = Class13.WppL;
        xDA0.TabStop = false;
        xDA0.Text = Class13.RppJ;
        bD6E.Location = new Point(6, Class13.xpp7);
        bD6E.Name = Class13.xppP;
        bD6E.Size = new Size(Class13.hppi, Class13.yppm);
        bD6E.TabIndex = Class13.Rpp0;
        bD6E.Text = Class13.CppI;
        bD6E.UseVisualStyleBackColor = true;
        bD6E.Click += nDUO;
        XDAU.AutoSize = true;
        XDAU.Location = new Point(Class13.lppR, Class13.BppC);
        XDAU.Name = Class13.QppK;
        XDAU.Size = new Size(Class13.kppU, Class13.dppT);
        XDAU.TabIndex = Class13.upp1;
        XDAU.Text = Class13.nppW;
        oDAT.AutoSize = true;
        oDAT.Location = new Point(6, Class13.kppw);
        oDAT.Name = Class13.jppN;
        oDAT.Size = new Size(Class13.hppY, Class13.UppB);
        oDAT.TabIndex = Class13.DppA;
        oDAT.Text = Class13.eppf;
        ODA1.AutoSize = true;
        ODA1.Location = new Point(Class13.Opp6, Class13.eppx);
        ODA1.Name = Class13.Ypp9;
        ODA1.Size = new Size(Class13.appc, Class13.Oppy);
        ODA1.TabIndex = Class13.Oppr;
        ODA1.Text = Class13.Lppq;
        bDAW.DropDownStyle = ComboBoxStyle.DropDownList;
        bDAW.FormattingEnabled = true;
        ComboBox.ObjectCollection items2 = bDAW.Items;
        object[] array2 = new object[Class13.Bppk];
        array2[0] = Class13.HppM;
        array2[1] = Class13.jppu;
        array2[2] = Class13.Qppg;
        array2[3] = Class13.app2;
        array2[4] = Class13.Bpp3;
        array2[5] = Class13.Xppd;
        array2[6] = Class13.YppH;
        array2[7] = Class13.tpp4;
        array2[8] = Class13.hpp5;
        array2[Class13.mpps] = Class13.qppZ;
        array2[Class13.Wppa] = Class13.nppj;
        array2[Class13.Fppz] = Class13.jpSE;
        array2[Class13.TpSD] = Class13.DpSX;
        array2[Class13.FpSp] = Class13.CpSS;
        array2[Class13.GpSh] = Class13.opSl;
        array2[Class13.LpSG] = Class13.IpSb;
        items2.AddRange(array2);
        bDAW.Location = new Point(6, Class13.tpSv);
        bDAW.Name = Class13.UpSo;
        bDAW.Size = new Size(Class13.PpSt, Class13.BpSV);
        bDAW.TabIndex = Class13.NpSO;
        zDAw.DropDownStyle = ComboBoxStyle.DropDownList;
        zDAw.FormattingEnabled = true;
        ComboBox.ObjectCollection items3 = zDAw.Items;
        object[] array3 = new object[Class13.DpSe];
        array3[0] = Class13.kpS8;
        array3[1] = Class13.gpSn;
        array3[2] = Class13.MpSQ;
        array3[3] = Class13.XpSF;
        array3[4] = Class13.JpSL;
        array3[5] = Class13.MpSJ;
        array3[6] = Class13.DpS7;
        array3[7] = Class13.opSP;
        array3[8] = Class13.rpSi;
        array3[Class13.spSm] = Class13.LpS0;
        array3[Class13.NpSI] = Class13.QpSR;
        array3[Class13.fpSC] = Class13.WpSK;
        array3[Class13.ApSU] = Class13.VpST;
        array3[Class13.dpS1] = Class13.HpSW;
        array3[Class13.KpSw] = Class13.DpSN;
        array3[Class13.xpSY] = Class13.FpSB;
        items3.AddRange(array3);
        zDAw.Location = new Point(6, Class13.YpSA);
        zDAw.Name = Class13.EpSf;
        zDAw.Size = new Size(Class13.jpS6, Class13.xpSx);
        zDAw.TabIndex = Class13.gpS9;
        TDAN.DropDownStyle = ComboBoxStyle.DropDownList;
        TDAN.FormattingEnabled = true;
        ComboBox.ObjectCollection items4 = TDAN.Items;
        object[] array4 = new object[Class13.wpSc];
        array4[0] = Class13.zpSy;
        array4[1] = Class13.DpSr;
        array4[2] = Class13.fpSq;
        array4[3] = Class13.CpSk;
        array4[4] = Class13.YpSM;
        array4[5] = Class13.SpSu;
        array4[6] = Class13.EpSg;
        array4[7] = Class13.bpS2;
        array4[8] = Class13.WpS3;
        array4[Class13.HpSd] = Class13.EpSH;
        array4[Class13.XpS4] = Class13.hpS5;
        array4[Class13.hpSs] = Class13.lpSZ;
        array4[Class13.kpSa] = Class13.UpSj;
        array4[Class13.RpSz] = Class13.pphE;
        array4[Class13.VphD] = Class13.RphX;
        array4[Class13.Kphp] = Class13.HphS;
        items4.AddRange(array4);
        TDAN.Location = new Point(6, Class13.nphh);
        TDAN.Name = Class13.ephl;
        TDAN.Size = new Size(Class13.pphG, Class13.Tphb);
        TDAN.TabIndex = Class13.cphv;
        VDAY.DropDownStyle = ComboBoxStyle.DropDownList;
        VDAY.FormattingEnabled = true;
        VDAY.Items.AddRange(new object[4] { Class13.dpho, Class13.Ppht, Class13.ophV, Class13.LphO });
        VDAY.Location = new Point(Class13.Vphe, Class13.Xph8);
        VDAY.Name = Class13.jphn;
        VDAY.Size = new Size(Class13.yphQ, Class13.aphF);
        VDAY.TabIndex = Class13.aphL;
        BDAB.Location = new Point(Class13.nphJ, Class13.mph7);
        BDAB.Maximum = new decimal(new int[4] { 3, 0, 0, 0 });
        BDAB.Name = Class13.cphP;
        BDAB.Size = new Size(Class13.sphi, Class13.nphm);
        BDAB.TabIndex = Class13.Mph0;
        BDAB.ValueChanged += YDKp;
        mDAI.Location = new Point(Class13.kphI, Class13.sphR);
        mDAI.Name = Class13.HphC;
        mDAI.Size = new Size(Class13.YphK, Class13.bphU);
        mDAI.TabIndex = 3;
        mDAI.Text = Class13.FphT;
        mDAI.UseVisualStyleBackColor = true;
        mDAI.Click += hDKS;
        MDAR.Controls.Add(tD6D);
        MDAR.Controls.Add(ADAA);
        MDAR.Controls.Add(hDAf);
        MDAR.Controls.Add(UDA6);
        MDAR.Controls.Add(qDAx);
        MDAR.Controls.Add(vDA9);
        MDAR.Controls.Add(RDAc);
        MDAR.Controls.Add(YDAy);
        MDAR.Controls.Add(bDAK);
        MDAR.Controls.Add(jDAC);
        MDAR.Location = new Point(6, Class13.uph1);
        MDAR.Name = Class13.VphW;
        MDAR.Size = new Size(Class13.Jphw, Class13.GphN);
        MDAR.TabIndex = Class13.LphY;
        MDAR.TabStop = false;
        MDAR.Text = Class13.LphB;
        tD6D.Location = new Point(6, Class13.ephA);
        tD6D.Name = Class13.qphf;
        tD6D.Size = new Size(Class13.Hph6, Class13.Pphx);
        tD6D.TabIndex = Class13.oph9;
        tD6D.Text = Class13.aphc;
        tD6D.UseVisualStyleBackColor = true;
        tD6D.Click += cDUe;
        ADAA.AutoSize = true;
        ADAA.Location = new Point(Class13.yphy, Class13.mphr);
        ADAA.Name = Class13.cphq;
        ADAA.Size = new Size(Class13.ephk, Class13.mphM);
        ADAA.TabIndex = Class13.fphu;
        ADAA.Text = Class13.Hphg;
        hDAf.AutoSize = true;
        hDAf.Location = new Point(6, Class13.eph2);
        hDAf.Name = Class13.gph3;
        hDAf.Size = new Size(Class13.Tphd, Class13.xphH);
        hDAf.TabIndex = Class13.Hph4;
        hDAf.Text = Class13.iph5;
        UDA6.AutoSize = true;
        UDA6.Location = new Point(Class13.gphs, Class13.YphZ);
        UDA6.Name = Class13.Tpha;
        UDA6.Size = new Size(Class13.rphj, Class13.Ephz);
        UDA6.TabIndex = Class13.bplE;
        UDA6.Text = Class13.pplD;
        qDAx.DropDownStyle = ComboBoxStyle.DropDownList;
        qDAx.FormattingEnabled = true;
        ComboBox.ObjectCollection items5 = qDAx.Items;
        object[] array5 = new object[Class13.AplX];
        array5[0] = Class13.Splp;
        array5[1] = Class13.mplS;
        array5[2] = Class13.Jplh;
        array5[3] = Class13.Upll;
        array5[4] = Class13.kplG;
        array5[5] = Class13.jplb;
        array5[6] = Class13.Kplv;
        array5[7] = Class13.pplo;
        array5[8] = Class13.lplt;
        array5[Class13.NplV] = Class13.SplO;
        array5[Class13.bple] = Class13.tpl8;
        array5[Class13.wpln] = Class13.HplQ;
        array5[Class13.tplF] = Class13.oplL;
        array5[Class13.mplJ] = Class13.fpl7;
        array5[Class13.NplP] = Class13.xpli;
        array5[Class13.Bplm] = Class13.ppl0;
        items5.AddRange(array5);
        qDAx.Location = new Point(6, Class13.XplI);
        qDAx.Name = Class13.JplR;
        qDAx.Size = new Size(Class13.iplC, Class13.fplK);
        qDAx.TabIndex = Class13.cplU;
        vDA9.DropDownStyle = ComboBoxStyle.DropDownList;
        vDA9.FormattingEnabled = true;
        ComboBox.ObjectCollection items6 = vDA9.Items;
        object[] array6 = new object[Class13.YplT];
        array6[0] = Class13.kpl1;
        array6[1] = Class13.cplW;
        array6[2] = Class13.qplw;
        array6[3] = Class13.WplN;
        array6[4] = Class13.xplY;
        array6[5] = Class13.gplB;
        array6[6] = Class13.nplA;
        array6[7] = Class13.kplf;
        array6[8] = Class13.wpl6;
        array6[Class13.jplx] = Class13.cpl9;
        array6[Class13.yplc] = Class13.gply;
        array6[Class13.mplr] = Class13.jplq;
        array6[Class13.Gplk] = Class13.SplM;
        array6[Class13.nplu] = Class13.dplg;
        array6[Class13.Hpl2] = Class13.mpl3;
        array6[Class13.spld] = Class13.splH;
        items6.AddRange(array6);
        vDA9.Location = new Point(6, Class13.Epl4);
        vDA9.Name = Class13.Bpl5;
        vDA9.Size = new Size(Class13.ypls, Class13.OplZ);
        vDA9.TabIndex = Class13.Ypla;
        RDAc.DropDownStyle = ComboBoxStyle.DropDownList;
        RDAc.FormattingEnabled = true;
        ComboBox.ObjectCollection items7 = RDAc.Items;
        object[] array7 = new object[Class13.Cplj];
        array7[0] = Class13.uplz;
        array7[1] = Class13.ipGE;
        array7[2] = Class13.PpGD;
        array7[3] = Class13.spGX;
        array7[4] = Class13.IpGp;
        array7[5] = Class13.gpGS;
        array7[6] = Class13.WpGh;
        array7[7] = Class13.zpGl;
        array7[8] = Class13.xpGG;
        array7[Class13.KpGb] = Class13.upGv;
        array7[Class13.EpGo] = Class13.npGt;
        array7[Class13.spGV] = Class13.CpGO;
        array7[Class13.jpGe] = Class13.PpG8;
        array7[Class13.kpGn] = Class13.ypGQ;
        array7[Class13.cpGF] = Class13.ApGL;
        array7[Class13.dpGJ] = Class13.wpG7;
        items7.AddRange(array7);
        RDAc.Location = new Point(6, Class13.RpGP);
        RDAc.Name = Class13.SpGi;
        RDAc.Size = new Size(Class13.mpGm, Class13.apG0);
        RDAc.TabIndex = Class13.ypGI;
        YDAy.DropDownStyle = ComboBoxStyle.DropDownList;
        YDAy.FormattingEnabled = true;
        YDAy.Items.AddRange(new object[4] { Class13.dpGR, Class13.IpGC, Class13.upGK, Class13.xpGU });
        YDAy.Location = new Point(Class13.EpGT, Class13.SpG1);
        YDAy.Name = Class13.fpGW;
        YDAy.Size = new Size(Class13.WpGw, Class13.hpGN);
        YDAy.TabIndex = Class13.FpGY;
        bDAK.Location = new Point(Class13.hpGB, Class13.TpGA);
        bDAK.Maximum = new decimal(new int[4] { 3, 0, 0, 0 });
        bDAK.Name = Class13.UpGf;
        bDAK.Size = new Size(Class13.OpG6, Class13.vpGx);
        bDAK.TabIndex = 6;
        bDAK.ValueChanged += WDKX;
        jDAC.Location = new Point(Class13.apG9, Class13.gpGc);
        jDAC.Name = Class13.mpGy;
        jDAC.Size = new Size(Class13.kpGr, Class13.ppGq);
        jDAC.TabIndex = 5;
        jDAC.Text = Class13.CpGk;
        jDAC.UseVisualStyleBackColor = true;
        jDAC.Click += SDKD;
        CDAi.Controls.Add(eDAm);
        CDAi.Controls.Add(HDAP);
        CDAi.Location = new Point(Class13.zpGM, Class13.UpGu);
        CDAi.Name = Class13.wpGg;
        CDAi.Size = new Size(Class13.bpG2, Class13.qpG3);
        CDAi.TabIndex = Class13.PpGd;
        CDAi.TabStop = false;
        CDAi.Text = Class13.MpGH;
        eDAm.Location = new Point(Class13.upG4, Class13.fpG5);
        eDAm.Name = Class13.upGs;
        eDAm.Size = new Size(Class13.rpGZ, Class13.XpGa);
        eDAm.TabIndex = 7;
        eDAm.Text = Class13.wpGj;
        eDAm.UseVisualStyleBackColor = true;
        eDAm.Click += lDCA;
        HDAP.Location = new Point(Class13.qpGz, Class13.qpbE);
        HDAP.Name = Class13.opbD;
        HDAP.Size = new Size(Class13.dpbX, Class13.Ypbp);
        HDAP.TabIndex = 6;
        HDAP.Text = Class13.JpbS;
        HDAP.UseVisualStyleBackColor = true;
        HDAP.Click += oDCB;
        vDBk.Controls.Add(bDwq);
        vDBk.Location = new Point(Class13.bpbh, Class13.ypbl);
        vDBk.Name = Class13.upbG;
        vDBk.Size = new Size(Class13.Ypbb, Class13.xpbv);
        vDBk.TabIndex = Class13.vpbo;
        vDBk.TabStop = false;
        vDBk.Text = Class13.xpbt;
        bDwq.ForeColor = Color.Black;
        bDwq.Location = new Point(Class13.WpbV, Class13.KpbO);
        bDwq.Name = Class13.Epbe;
        bDwq.Size = new Size(Class13.Vpb8, Class13.Mpbn);
        bDwq.TabIndex = Class13.MpbQ;
        bDwq.Text = Class13.IpbF;
        MD6H.SetToolTip(bDwq, Class13.npbL);
        bDwq.UseVisualStyleBackColor = true;
        bDwq.Click += DDI0;
        xDBM.Controls.Add(xDNP);
        xDBM.Location = new Point(6, Class13.TpbJ);
        xDBM.Name = Class13.hpb7;
        xDBM.Size = new Size(Class13.tpbP, Class13.Epbi);
        xDBM.TabIndex = Class13.Ppbm;
        xDBM.TabStop = false;
        xDBM.Text = Class13.ppb0;
        xDNP.ForeColor = Color.Black;
        xDNP.Location = new Point(Class13.kpbI, Class13.xpbR);
        xDNP.Name = Class13.HpbC;
        xDNP.Size = new Size(Class13.WpbK, Class13.TpbU);
        xDNP.TabIndex = Class13.WpbT;
        xDNP.Text = Class13.epb1;
        xDNP.UseVisualStyleBackColor = true;
        xDNP.Click += xDIW;
        MD1F.AutoSize = true;
        MD1F.Font = new Font(Class13.jpbW, Class13.ipbw, FontStyle.Regular, GraphicsUnit.Point, 0);
        MD1F.Location = new Point(Class13.YpbN, Class13.vpbY);
        MD1F.Name = Class13.jpbB;
        MD1F.Size = new Size(Class13.LpbA, Class13.apbf);
        MD1F.TabIndex = Class13.Kpb6;
        MD1F.Text = Class13.Qpbx;
        oD1L.Location = new Point(Class13.hpb9, Class13.upbc);
        oD1L.Maximum = new decimal(new int[4] { Class13.spby, 0, 0, 0 });
        oD1L.Name = Class13.Lpbr;
        oD1L.Size = new Size(Class13.npbq, Class13.Fpbk);
        oD1L.TabIndex = Class13.KpbM;
        vD1J.Location = new Point(Class13.Npbu, Class13.spbg);
        vD1J.Maximum = new decimal(new int[4] { Class13.opb2, 0, 0, 0 });
        vD1J.Name = Class13.kpb3;
        vD1J.Size = new Size(Class13.Xpbd, Class13.npbH);
        vD1J.TabIndex = Class13.qpb4;
        hD17.Controls.Add(JDwr);
        hD17.Controls.Add(pD1P);
        hD17.Controls.Add(SD1i);
        hD17.Controls.Add(SD1m);
        hD17.Controls.Add(yD10);
        hD17.Controls.Add(uD1I);
        hD17.Controls.Add(tD1R);
        hD17.Controls.Add(OD1C);
        hD17.Controls.Add(iD1K);
        hD17.Location = new Point(Class13.Spb5, 6);
        hD17.Name = Class13.mpbs;
        hD17.Size = new Size(Class13.GpbZ, Class13.Xpba);
        hD17.TabIndex = 8;
        hD17.TabStop = false;
        hD17.Text = Class13.npbj;
        JDwr.AutoSize = true;
        JDwr.Location = new Point(Class13.npbz, Class13.hpvE);
        JDwr.Name = Class13.xpvD;
        JDwr.Size = new Size(Class13.vpvX, Class13.gpvp);
        JDwr.TabIndex = Class13.FpvS;
        JDwr.Text = Class13.kpvh;
        JDwr.UseVisualStyleBackColor = true;
        pD1P.Location = new Point(Class13.fpvl, Class13.npvG);
        pD1P.Name = Class13.Ipvb;
        pD1P.Size = new Size(Class13.hpvv, Class13.rpvo);
        pD1P.TabIndex = Class13.Npvt;
        pD1P.Text = Class13.BpvV;
        pD1P.UseVisualStyleBackColor = true;
        pD1P.Click += UD0Y;
        SD1i.AutoSize = true;
        SD1i.Location = new Point(Class13.MpvO, Class13.dpve);
        SD1i.Name = Class13.Kpv8;
        SD1i.Size = new Size(Class13.opvn, Class13.ypvQ);
        SD1i.TabIndex = Class13.lpvF;
        SD1i.Text = Class13.RpvL;
        SD1i.UseVisualStyleBackColor = true;
        SD1m.AutoSize = true;
        SD1m.Checked = true;
        SD1m.CheckState = CheckState.Checked;
        SD1m.Location = new Point(Class13.SpvJ, Class13.Ipv7);
        SD1m.Name = Class13.npvP;
        SD1m.Size = new Size(Class13.Upvi, Class13.Xpvm);
        SD1m.TabIndex = Class13.xpv0;
        SD1m.Text = Class13.YpvI;
        SD1m.UseVisualStyleBackColor = true;
        yD10.AutoSize = true;
        yD10.Location = new Point(7, Class13.rpvR);
        yD10.Name = Class13.VpvC;
        yD10.Size = new Size(Class13.EpvK, Class13.PpvU);
        yD10.TabIndex = Class13.dpvT;
        yD10.Text = Class13.rpv1;
        uD1I.DropDownStyle = ComboBoxStyle.DropDownList;
        uD1I.FormattingEnabled = true;
        ComboBox.ObjectCollection items8 = uD1I.Items;
        object[] array8 = new object[Class13.JpvW];
        array8[0] = Class13.epvw;
        array8[1] = Class13.TpvN;
        array8[2] = Class13.hpvY;
        array8[3] = Class13.QpvB;
        array8[4] = Class13.EpvA;
        array8[5] = Class13.Npvf;
        array8[6] = Class13.wpv6;
        array8[7] = Class13.vpvx;
        array8[8] = Class13.Qpv9;
        array8[Class13.vpvc] = Class13.npvy;
        array8[Class13.Npvr] = Class13.Opvq;
        array8[Class13.kpvk] = Class13.cpvM;
        array8[Class13.Epvu] = Class13.Xpvg;
        array8[Class13.Jpv2] = Class13.wpv3;
        array8[Class13.npvd] = Class13.epvH;
        array8[Class13.Vpv4] = Class13.Ipv5;
        array8[Class13.bpvs] = Class13.xpvZ;
        array8[Class13.Cpva] = Class13.tpvj;
        array8[Class13.mpvz] = Class13.ApoE;
        array8[Class13.TpoD] = Class13.QpoX;
        items8.AddRange(array8);
        uD1I.Location = new Point(6, Class13.ppop);
        uD1I.Name = Class13.YpoS;
        uD1I.Size = new Size(Class13.apoh, Class13.tpol);
        uD1I.TabIndex = Class13.upoG;
        tD1R.Location = new Point(Class13.Rpob, Class13.Apov);
        tD1R.Name = Class13.bpoo;
        tD1R.Size = new Size(Class13.npot, Class13.ppoV);
        tD1R.TabIndex = Class13.upoO;
        tD1R.Text = Class13.npoe;
        tD1R.UseVisualStyleBackColor = true;
        tD1R.Click += AD0B;
        OD1C.AutoSize = true;
        OD1C.Location = new Point(7, Class13.apo8);
        OD1C.Name = Class13.Hpon;
        OD1C.Size = new Size(Class13.EpoQ, Class13.vpoF);
        OD1C.TabIndex = 4;
        OD1C.Text = Class13.xpoL;
        iD1K.DropDownStyle = ComboBoxStyle.DropDownList;
        iD1K.FormattingEnabled = true;
        ComboBox.ObjectCollection items9 = iD1K.Items;
        object[] array9 = new object[Class13.YpoJ];
        array9[0] = Class13.hpo7;
        array9[1] = Class13.RpoP;
        array9[2] = Class13.Xpoi;
        array9[3] = Class13.Epom;
        array9[4] = Class13.hpo0;
        array9[5] = Class13.PpoI;
        array9[6] = Class13.HpoR;
        array9[7] = Class13.jpoC;
        array9[8] = Class13.ApoK;
        array9[Class13.fpoU] = Class13.FpoT;
        array9[Class13.Ipo1] = Class13.ppoW;
        array9[Class13.jpow] = Class13.jpoN;
        array9[Class13.JpoY] = Class13.cpoB;
        array9[Class13.upoA] = Class13.Ipof;
        array9[Class13.spo6] = Class13.Spox;
        array9[Class13.Mpo9] = Class13.Ypoc;
        array9[Class13.Epoy] = Class13.Ipor;
        array9[Class13.jpoq] = Class13.dpok;
        array9[Class13.JpoM] = Class13.tpou;
        array9[Class13.Ypog] = Class13.Mpo2;
        array9[Class13.hpo3] = Class13.kpod;
        array9[Class13.VpoH] = Class13.cpo4;
        array9[Class13.Ypo5] = Class13.Tpos;
        array9[Class13.PpoZ] = Class13.Ipoa;
        array9[Class13.Spoj] = Class13.kpoz;
        array9[Class13.fptE] = Class13.tptD;
        array9[Class13.KptX] = Class13.Yptp;
        array9[Class13.tptS] = Class13.gpth;
        array9[Class13.bptl] = Class13.xptG;
        array9[Class13.mptb] = Class13.Uptv;
        array9[Class13.qpto] = Class13.Tptt;
        array9[Class13.GptV] = Class13.QptO;
        array9[Class13.hpte] = Class13.Jpt8;
        array9[Class13.pptn] = Class13.iptQ;
        array9[Class13.MptF] = Class13.FptL;
        array9[Class13.RptJ] = Class13.spt7;
        array9[Class13.zptP] = Class13.Hpti;
        array9[Class13.Optm] = Class13.gpt0;
        array9[Class13.dptI] = Class13.lptR;
        array9[Class13.TptC] = Class13.DptK;
        array9[Class13.JptU] = Class13.iptT;
        array9[Class13.ept1] = Class13.dptW;
        array9[Class13.tptw] = Class13.gptN;
        array9[Class13.vptY] = Class13.vptB;
        array9[Class13.KptA] = Class13.rptf;
        array9[Class13.lpt6] = Class13.Vptx;
        array9[Class13.Hpt9] = Class13.yptc;
        array9[Class13.opty] = Class13.fptr;
        array9[Class13.Jptq] = Class13.gptk;
        array9[Class13.FptM] = Class13.Rptu;
        array9[Class13.dptg] = Class13.Spt2;
        array9[Class13.Vpt3] = Class13.Rptd;
        array9[Class13.rptH] = Class13.lpt4;
        array9[Class13.Vpt5] = Class13.lpts;
        array9[Class13.GptZ] = Class13.Wpta;
        array9[Class13.Pptj] = Class13.Lptz;
        array9[Class13.wpVE] = Class13.WpVD;
        items9.AddRange(array9);
        iD1K.Location = new Point(6, Class13.SpVX);
        iD1K.Name = Class13.gpVp;
        iD1K.Size = new Size(Class13.opVS, Class13.PpVh);
        iD1K.TabIndex = 2;
        FD1U.Location = new Point(Class13.kpVl, Class13.rpVG);
        FD1U.Name = Class13.rpVb;
        FD1U.Size = new Size(Class13.npVv, Class13.WpVo);
        FD1U.TabIndex = Class13.qpVt;
        FD1U.Text = Class13.epVV;
        FD1U.UseVisualStyleBackColor = true;
        FD1U.Click += JD0A;
        nD1T.AutoSize = true;
        nD1T.Location = new Point(Class13.GpVO, Class13.wpVe);
        nD1T.Name = Class13.bpV8;
        nD1T.Size = new Size(Class13.TpVn, Class13.FpVQ);
        nD1T.TabIndex = Class13.XpVF;
        nD1T.Text = Class13.ipVL;
        hD11.Controls.Add(oD1W);
        hD11.Location = new Point(4, Class13.ypVJ);
        hD11.Name = Class13.fpV7;
        hD11.Padding = new Padding(3);
        hD11.Size = new Size(Class13.lpVP, Class13.EpVi);
        hD11.TabIndex = 1;
        hD11.Text = Class13.tpVm;
        hD11.UseVisualStyleBackColor = true;
        oD1W.Controls.Add(hD1w);
        oD1W.Controls.Add(kD1Y);
        oD1W.Controls.Add(JD1A);
        oD1W.Controls.Add(aD16);
        oD1W.Controls.Add(tD19);
        oD1W.Controls.Add(TD1y);
        oD1W.Controls.Add(HD1q);
        oD1W.Controls.Add(eD1M);
        oD1W.Controls.Add(xD1g);
        oD1W.Controls.Add(ED13);
        oD1W.Controls.Add(LD1H);
        oD1W.Controls.Add(aD15);
        oD1W.Controls.Add(YD1Z);
        oD1W.Controls.Add(BD1j);
        oD1W.Controls.Add(tDWE);
        oD1W.Controls.Add(aDWX);
        oD1W.Dock = DockStyle.Fill;
        oD1W.Location = new Point(3, 3);
        oD1W.Name = Class13.JpV0;
        oD1W.SelectedIndex = 0;
        oD1W.Size = new Size(Class13.ppVI, Class13.WpVR);
        oD1W.TabIndex = 0;
        hD1w.Controls.Add(LD1N);
        hD1w.Location = new Point(4, Class13.OpVC);
        hD1w.Name = Class13.ypVK;
        hD1w.Padding = new Padding(3);
        hD1w.Size = new Size(Class13.KpVU, Class13.hpVT);
        hD1w.TabIndex = 0;
        hD1w.Text = Class13.SpV1;
        hD1w.UseVisualStyleBackColor = true;
        LD1N.Dock = DockStyle.Fill;
        LD1N.Location = new Point(3, 3);
        LD1N.Name = Class13.YpVW;
        LD1N.Size = new Size(Class13.opVw, Class13.dpVN);
        LD1N.TabIndex = 0;
        LD1N.UseCompatibleStateImageBehavior = false;
        kD1Y.Controls.Add(ND1B);
        kD1Y.Location = new Point(4, Class13.EpVY);
        kD1Y.Name = Class13.JpVB;
        kD1Y.Padding = new Padding(3);
        kD1Y.Size = new Size(Class13.dpVA, Class13.zpVf);
        kD1Y.TabIndex = 1;
        kD1Y.Text = Class13.mpV6;
        kD1Y.UseVisualStyleBackColor = true;
        ND1B.Dock = DockStyle.Fill;
        ND1B.Location = new Point(3, 3);
        ND1B.Name = Class13.fpVx;
        ND1B.Size = new Size(Class13.spV9, Class13.SpVc);
        ND1B.TabIndex = 0;
        ND1B.UseCompatibleStateImageBehavior = false;
        JD1A.Controls.Add(bD1f);
        JD1A.Location = new Point(4, Class13.UpVy);
        JD1A.Name = Class13.KpVr;
        JD1A.Padding = new Padding(3);
        JD1A.Size = new Size(Class13.cpVq, Class13.MpVk);
        JD1A.TabIndex = 2;
        JD1A.Text = Class13.xpVM;
        JD1A.UseVisualStyleBackColor = true;
        bD1f.Dock = DockStyle.Fill;
        bD1f.Location = new Point(3, 3);
        bD1f.Name = Class13.OpVu;
        bD1f.Size = new Size(Class13.OpVg, Class13.upV2);
        bD1f.TabIndex = 0;
        bD1f.UseCompatibleStateImageBehavior = false;
        aD16.Controls.Add(XD1x);
        aD16.Location = new Point(4, Class13.DpV3);
        aD16.Name = Class13.qpVd;
        aD16.Padding = new Padding(3);
        aD16.Size = new Size(Class13.spVH, Class13.vpV4);
        aD16.TabIndex = 3;
        aD16.Text = Class13.HpV5;
        aD16.UseVisualStyleBackColor = true;
        XD1x.Dock = DockStyle.Fill;
        XD1x.Location = new Point(3, 3);
        XD1x.Name = Class13.ApVs;
        XD1x.Size = new Size(Class13.mpVZ, Class13.KpVa);
        XD1x.TabIndex = 0;
        XD1x.UseCompatibleStateImageBehavior = false;
        tD19.Controls.Add(kD1c);
        tD19.Location = new Point(4, Class13.ppVj);
        tD19.Name = Class13.TpVz;
        tD19.Padding = new Padding(3);
        tD19.Size = new Size(Class13.spOE, Class13.cpOD);
        tD19.TabIndex = 4;
        tD19.Text = Class13.upOX;
        tD19.UseVisualStyleBackColor = true;
        kD1c.Dock = DockStyle.Fill;
        kD1c.Location = new Point(3, 3);
        kD1c.Name = Class13.opOp;
        kD1c.Size = new Size(Class13.gpOS, Class13.EpOh);
        kD1c.TabIndex = 0;
        kD1c.UseCompatibleStateImageBehavior = false;
        TD1y.Controls.Add(cD1r);
        TD1y.Location = new Point(4, Class13.npOl);
        TD1y.Name = Class13.CpOG;
        TD1y.Padding = new Padding(3);
        TD1y.Size = new Size(Class13.WpOb, Class13.IpOv);
        TD1y.TabIndex = 5;
        TD1y.Text = Class13.SpOo;
        TD1y.UseVisualStyleBackColor = true;
        cD1r.Dock = DockStyle.Fill;
        cD1r.Location = new Point(3, 3);
        cD1r.Name = Class13.apOt;
        cD1r.Size = new Size(Class13.mpOV, Class13.EpOO);
        cD1r.TabIndex = 0;
        cD1r.UseCompatibleStateImageBehavior = false;
        HD1q.Controls.Add(BD1k);
        HD1q.Location = new Point(4, Class13.TpOe);
        HD1q.Name = Class13.MpO8;
        HD1q.Padding = new Padding(3);
        HD1q.Size = new Size(Class13.spOn, Class13.CpOQ);
        HD1q.TabIndex = 6;
        HD1q.Text = Class13.WpOF;
        HD1q.UseVisualStyleBackColor = true;
        BD1k.Dock = DockStyle.Fill;
        BD1k.Location = new Point(3, 3);
        BD1k.Name = Class13.upOL;
        BD1k.Size = new Size(Class13.wpOJ, Class13.HpO7);
        BD1k.TabIndex = 0;
        BD1k.UseCompatibleStateImageBehavior = false;
        eD1M.Controls.Add(lD1u);
        eD1M.Location = new Point(4, Class13.UpOP);
        eD1M.Name = Class13.kpOi;
        eD1M.Padding = new Padding(3);
        eD1M.Size = new Size(Class13.OpOm, Class13.upO0);
        eD1M.TabIndex = 7;
        eD1M.Text = Class13.XpOI;
        eD1M.UseVisualStyleBackColor = true;
        lD1u.Dock = DockStyle.Fill;
        lD1u.Location = new Point(3, 3);
        lD1u.Name = Class13.MpOR;
        lD1u.Size = new Size(Class13.HpOC, Class13.ipOK);
        lD1u.TabIndex = 0;
        lD1u.UseCompatibleStateImageBehavior = false;
        xD1g.Controls.Add(MD12);
        xD1g.Location = new Point(4, Class13.XpOU);
        xD1g.Name = Class13.ppOT;
        xD1g.Padding = new Padding(3);
        xD1g.Size = new Size(Class13.ppO1, Class13.JpOW);
        xD1g.TabIndex = 8;
        xD1g.Text = Class13.NpOw;
        xD1g.UseVisualStyleBackColor = true;
        MD12.Dock = DockStyle.Fill;
        MD12.Location = new Point(3, 3);
        MD12.Name = Class13.EpON;
        MD12.Size = new Size(Class13.gpOY, Class13.lpOB);
        MD12.TabIndex = 0;
        MD12.UseCompatibleStateImageBehavior = false;
        ED13.Controls.Add(zD1d);
        ED13.Location = new Point(4, Class13.ppOA);
        ED13.Name = Class13.TpOf;
        ED13.Padding = new Padding(3);
        ED13.Size = new Size(Class13.lpO6, Class13.QpOx);
        ED13.TabIndex = Class13.fpO9;
        ED13.Text = Class13.KpOc;
        ED13.UseVisualStyleBackColor = true;
        zD1d.Dock = DockStyle.Fill;
        zD1d.Location = new Point(3, 3);
        zD1d.Name = Class13.LpOy;
        zD1d.Size = new Size(Class13.MpOr, Class13.ypOq);
        zD1d.TabIndex = 0;
        zD1d.UseCompatibleStateImageBehavior = false;
        zD1d.View = View.List;
        LD1H.Controls.Add(gD14);
        LD1H.Location = new Point(4, Class13.qpOk);
        LD1H.Name = Class13.xpOM;
        LD1H.Padding = new Padding(3);
        LD1H.Size = new Size(Class13.DpOu, Class13.dpOg);
        LD1H.TabIndex = Class13.fpO2;
        LD1H.Text = Class13.dpO3;
        LD1H.UseVisualStyleBackColor = true;
        gD14.Dock = DockStyle.Fill;
        gD14.Location = new Point(3, 3);
        gD14.Name = Class13.fpOd;
        gD14.Size = new Size(Class13.rpOH, Class13.DpO4);
        gD14.TabIndex = 0;
        gD14.UseCompatibleStateImageBehavior = false;
        aD15.Controls.Add(ID1s);
        aD15.Location = new Point(4, Class13.YpO5);
        aD15.Name = Class13.fpOs;
        aD15.Padding = new Padding(3);
        aD15.Size = new Size(Class13.apOZ, Class13.SpOa);
        aD15.TabIndex = Class13.zpOj;
        aD15.Text = Class13.HpOz;
        aD15.UseVisualStyleBackColor = true;
        ID1s.Dock = DockStyle.Fill;
        ID1s.Location = new Point(3, 3);
        ID1s.Name = Class13.CpeE;
        ID1s.Size = new Size(Class13.VpeD, Class13.epeX);
        ID1s.TabIndex = 0;
        ID1s.UseCompatibleStateImageBehavior = false;
        YD1Z.Controls.Add(OD1a);
        YD1Z.Location = new Point(4, Class13.Lpep);
        YD1Z.Name = Class13.tpeS;
        YD1Z.Padding = new Padding(3);
        YD1Z.Size = new Size(Class13.vpeh, Class13.rpel);
        YD1Z.TabIndex = Class13.xpeG;
        YD1Z.Text = Class13.Hpeb;
        YD1Z.UseVisualStyleBackColor = true;
        OD1a.Dock = DockStyle.Fill;
        OD1a.Location = new Point(3, 3);
        OD1a.Name = Class13.Ppev;
        OD1a.Size = new Size(Class13.kpeo, Class13.jpet);
        OD1a.TabIndex = 0;
        OD1a.UseCompatibleStateImageBehavior = false;
        BD1j.Controls.Add(hD1z);
        BD1j.Location = new Point(4, Class13.OpeV);
        BD1j.Name = Class13.LpeO;
        BD1j.Padding = new Padding(3);
        BD1j.Size = new Size(Class13.epee, Class13.epe8);
        BD1j.TabIndex = Class13.lpen;
        BD1j.Text = Class13.UpeQ;
        BD1j.UseVisualStyleBackColor = true;
        hD1z.Dock = DockStyle.Fill;
        hD1z.Location = new Point(3, 3);
        hD1z.Name = Class13.SpeF;
        hD1z.Size = new Size(Class13.mpeL, Class13.rpeJ);
        hD1z.TabIndex = 0;
        hD1z.UseCompatibleStateImageBehavior = false;
        tDWE.Controls.Add(qDWD);
        tDWE.Location = new Point(4, Class13.Fpe7);
        tDWE.Name = Class13.dpeP;
        tDWE.Padding = new Padding(3);
        tDWE.Size = new Size(Class13.vpei, Class13.Bpem);
        tDWE.TabIndex = Class13.epe0;
        tDWE.Text = Class13.CpeI;
        tDWE.UseVisualStyleBackColor = true;
        qDWD.Dock = DockStyle.Fill;
        qDWD.Location = new Point(3, 3);
        qDWD.Name = Class13.SpeR;
        qDWD.Size = new Size(Class13.SpeC, Class13.xpeK);
        qDWD.TabIndex = 0;
        qDWD.UseCompatibleStateImageBehavior = false;
        aDWX.Controls.Add(iDWp);
        aDWX.Location = new Point(4, Class13.KpeU);
        aDWX.Name = Class13.GpeT;
        aDWX.Padding = new Padding(3);
        aDWX.Size = new Size(Class13.npe1, Class13.UpeW);
        aDWX.TabIndex = Class13.npew;
        aDWX.Text = Class13.OpeN;
        aDWX.UseVisualStyleBackColor = true;
        iDWp.Dock = DockStyle.Fill;
        iDWp.Location = new Point(3, 3);
        iDWp.Name = Class13.ypeY;
        iDWp.Size = new Size(Class13.WpeB, Class13.tpeA);
        iDWp.TabIndex = 0;
        iDWp.UseCompatibleStateImageBehavior = false;
        TDBg.Controls.Add(sDB2);
        TDBg.Location = new Point(4, Class13.Spef);
        TDBg.Name = Class13.Ype6;
        TDBg.Padding = new Padding(3);
        TDBg.Size = new Size(Class13.Opex, Class13.Cpe9);
        TDBg.TabIndex = 2;
        TDBg.Text = Class13.Tpec;
        TDBg.UseVisualStyleBackColor = true;
        sDB2.Controls.Add(bDB3);
        sDB2.Controls.Add(aDBH);
        sDB2.Controls.Add(hDB5);
        sDB2.Controls.Add(tDBZ);
        sDB2.Controls.Add(BDBj);
        sDB2.Controls.Add(vDAE);
        sDB2.Controls.Add(gDAX);
        sDB2.Controls.Add(mDAS);
        sDB2.Controls.Add(JDAl);
        sDB2.Controls.Add(pDAb);
        sDB2.Controls.Add(HDAo);
        sDB2.Controls.Add(MDAV);
        sDB2.Controls.Add(gDAe);
        sDB2.Controls.Add(IDAn);
        sDB2.Controls.Add(UDAF);
        sDB2.Controls.Add(QDAJ);
        sDB2.Dock = DockStyle.Fill;
        sDB2.Location = new Point(3, 3);
        sDB2.Name = Class13.Xpey;
        sDB2.SelectedIndex = 0;
        sDB2.Size = new Size(Class13.vper, Class13.Jpeq);
        sDB2.TabIndex = 1;
        bDB3.Controls.Add(kDBd);
        bDB3.Location = new Point(4, Class13.opek);
        bDB3.Name = Class13.JpeM;
        bDB3.Padding = new Padding(3);
        bDB3.Size = new Size(Class13.Npeu, Class13.Bpeg);
        bDB3.TabIndex = 0;
        bDB3.Text = Class13.ppe2;
        bDB3.UseVisualStyleBackColor = true;
        kDBd.Dock = DockStyle.Fill;
        kDBd.Location = new Point(3, 3);
        kDBd.Name = Class13.Xpe3;
        kDBd.Size = new Size(Class13.Pped, Class13.OpeH);
        kDBd.TabIndex = 0;
        kDBd.UseCompatibleStateImageBehavior = false;
        aDBH.Controls.Add(dDB4);
        aDBH.Location = new Point(4, Class13.upe4);
        aDBH.Name = Class13.npe5;
        aDBH.Padding = new Padding(3);
        aDBH.Size = new Size(Class13.opes, Class13.BpeZ);
        aDBH.TabIndex = 1;
        aDBH.Text = Class13.Xpea;
        aDBH.UseVisualStyleBackColor = true;
        dDB4.Dock = DockStyle.Fill;
        dDB4.Location = new Point(3, 3);
        dDB4.Name = Class13.Spej;
        dDB4.Size = new Size(Class13.Upez, Class13.yp8E);
        dDB4.TabIndex = 0;
        dDB4.UseCompatibleStateImageBehavior = false;
        hDB5.Controls.Add(VDBs);
        hDB5.Location = new Point(4, Class13.Yp8D);
        hDB5.Name = Class13.rp8X;
        hDB5.Padding = new Padding(3);
        hDB5.Size = new Size(Class13.ap8p, Class13.zp8S);
        hDB5.TabIndex = 2;
        hDB5.Text = Class13.Mp8h;
        hDB5.UseVisualStyleBackColor = true;
        VDBs.Dock = DockStyle.Fill;
        VDBs.Location = new Point(3, 3);
        VDBs.Name = Class13.Dp8l;
        VDBs.Size = new Size(Class13.Vp8G, Class13.Dp8b);
        VDBs.TabIndex = 0;
        VDBs.UseCompatibleStateImageBehavior = false;
        tDBZ.Controls.Add(UDBa);
        tDBZ.Location = new Point(4, Class13.sp8v);
        tDBZ.Name = Class13.op8o;
        tDBZ.Padding = new Padding(3);
        tDBZ.Size = new Size(Class13.Fp8t, Class13.mp8V);
        tDBZ.TabIndex = 3;
        tDBZ.Text = Class13.gp8O;
        tDBZ.UseVisualStyleBackColor = true;
        UDBa.Dock = DockStyle.Fill;
        UDBa.Location = new Point(3, 3);
        UDBa.Name = Class13.dp8e;
        UDBa.Size = new Size(Class13.jp88, Class13.Lp8n);
        UDBa.TabIndex = 0;
        UDBa.UseCompatibleStateImageBehavior = false;
        BDBj.Controls.Add(xDBz);
        BDBj.Location = new Point(4, Class13.zp8Q);
        BDBj.Name = Class13.Bp8F;
        BDBj.Padding = new Padding(3);
        BDBj.Size = new Size(Class13.gp8L, Class13.yp8J);
        BDBj.TabIndex = 4;
        BDBj.Text = Class13.Op87;
        BDBj.UseVisualStyleBackColor = true;
        xDBz.Dock = DockStyle.Fill;
        xDBz.Location = new Point(3, 3);
        xDBz.Name = Class13.ap8P;
        xDBz.Size = new Size(Class13.xp8i, Class13.up8m);
        xDBz.TabIndex = 0;
        xDBz.UseCompatibleStateImageBehavior = false;
        vDAE.Controls.Add(yDAD);
        vDAE.Location = new Point(4, Class13.wp80);
        vDAE.Name = Class13.np8I;
        vDAE.Padding = new Padding(3);
        vDAE.Size = new Size(Class13.Yp8R, Class13.ap8C);
        vDAE.TabIndex = 5;
        vDAE.Text = Class13.op8K;
        vDAE.UseVisualStyleBackColor = true;
        yDAD.Dock = DockStyle.Fill;
        yDAD.Location = new Point(3, 3);
        yDAD.Name = Class13.Tp8U;
        yDAD.Size = new Size(Class13.xp8T, Class13.jp81);
        yDAD.TabIndex = 0;
        yDAD.UseCompatibleStateImageBehavior = false;
        gDAX.Controls.Add(GDAp);
        gDAX.Location = new Point(4, Class13.Xp8W);
        gDAX.Name = Class13.Rp8w;
        gDAX.Padding = new Padding(3);
        gDAX.Size = new Size(Class13.ap8N, Class13.Op8Y);
        gDAX.TabIndex = 6;
        gDAX.Text = Class13.jp8B;
        gDAX.UseVisualStyleBackColor = true;
        GDAp.Dock = DockStyle.Fill;
        GDAp.Location = new Point(3, 3);
        GDAp.Name = Class13.pp8A;
        GDAp.Size = new Size(Class13.Tp8f, Class13.Vp86);
        GDAp.TabIndex = 0;
        GDAp.UseCompatibleStateImageBehavior = false;
        mDAS.Controls.Add(mDAh);
        mDAS.Location = new Point(4, Class13.Cp8x);
        mDAS.Name = Class13.Up89;
        mDAS.Padding = new Padding(3);
        mDAS.Size = new Size(Class13.Vp8c, Class13.yp8y);
        mDAS.TabIndex = 7;
        mDAS.Text = Class13.xp8r;
        mDAS.UseVisualStyleBackColor = true;
        mDAh.Dock = DockStyle.Fill;
        mDAh.Location = new Point(3, 3);
        mDAh.Name = Class13.mp8q;
        mDAh.Size = new Size(Class13.bp8k, Class13.Bp8M);
        mDAh.TabIndex = 0;
        mDAh.UseCompatibleStateImageBehavior = false;
        JDAl.Controls.Add(pDAG);
        JDAl.Location = new Point(4, Class13.Up8u);
        JDAl.Name = Class13.pp8g;
        JDAl.Padding = new Padding(3);
        JDAl.Size = new Size(Class13.Lp82, Class13.Jp83);
        JDAl.TabIndex = 8;
        JDAl.Text = Class13.Op8d;
        JDAl.UseVisualStyleBackColor = true;
        pDAG.Dock = DockStyle.Fill;
        pDAG.Location = new Point(3, 3);
        pDAG.Name = Class13.cp8H;
        pDAG.Size = new Size(Class13.ap84, Class13.Tp85);
        pDAG.TabIndex = 0;
        pDAG.UseCompatibleStateImageBehavior = false;
        pDAb.Controls.Add(MDAv);
        pDAb.Location = new Point(4, Class13.Gp8s);
        pDAb.Name = Class13.Kp8Z;
        pDAb.Padding = new Padding(3);
        pDAb.Size = new Size(Class13.Ep8a, Class13.Np8j);
        pDAb.TabIndex = Class13.Xp8z;
        pDAb.Text = Class13.IpnE;
        pDAb.UseVisualStyleBackColor = true;
        MDAv.Dock = DockStyle.Fill;
        MDAv.Location = new Point(3, 3);
        MDAv.Name = Class13.dpnD;
        MDAv.Size = new Size(Class13.zpnX, Class13.vpnp);
        MDAv.TabIndex = 0;
        MDAv.UseCompatibleStateImageBehavior = false;
        MDAv.View = View.List;
        HDAo.Controls.Add(MDAt);
        HDAo.Location = new Point(4, Class13.PpnS);
        HDAo.Name = Class13.opnh;
        HDAo.Padding = new Padding(3);
        HDAo.Size = new Size(Class13.hpnl, Class13.xpnG);
        HDAo.TabIndex = Class13.Npnb;
        HDAo.Text = Class13.Bpnv;
        HDAo.UseVisualStyleBackColor = true;
        MDAt.Dock = DockStyle.Fill;
        MDAt.Location = new Point(3, 3);
        MDAt.Name = Class13.lpno;
        MDAt.Size = new Size(Class13.hpnt, Class13.QpnV);
        MDAt.TabIndex = 0;
        MDAt.UseCompatibleStateImageBehavior = false;
        MDAV.Controls.Add(tDAO);
        MDAV.Location = new Point(4, Class13.zpnO);
        MDAV.Name = Class13.jpne;
        MDAV.Padding = new Padding(3);
        MDAV.Size = new Size(Class13.Rpn8, Class13.Tpnn);
        MDAV.TabIndex = Class13.ypnQ;
        MDAV.Text = Class13.TpnF;
        MDAV.UseVisualStyleBackColor = true;
        tDAO.Dock = DockStyle.Fill;
        tDAO.Location = new Point(3, 3);
        tDAO.Name = Class13.JpnL;
        tDAO.Size = new Size(Class13.XpnJ, Class13.qpn7);
        tDAO.TabIndex = 0;
        tDAO.UseCompatibleStateImageBehavior = false;
        gDAe.Controls.Add(XDA8);
        gDAe.Location = new Point(4, Class13.QpnP);
        gDAe.Name = Class13.Npni;
        gDAe.Padding = new Padding(3);
        gDAe.Size = new Size(Class13.vpnm, Class13.Ypn0);
        gDAe.TabIndex = Class13.wpnI;
        gDAe.Text = Class13.XpnR;
        gDAe.UseVisualStyleBackColor = true;
        XDA8.Dock = DockStyle.Fill;
        XDA8.Location = new Point(3, 3);
        XDA8.Name = Class13.apnC;
        XDA8.Size = new Size(Class13.DpnK, Class13.PpnU);
        XDA8.TabIndex = 0;
        XDA8.UseCompatibleStateImageBehavior = false;
        IDAn.Controls.Add(JDAQ);
        IDAn.Location = new Point(4, Class13.OpnT);
        IDAn.Name = Class13.Bpn1;
        IDAn.Padding = new Padding(3);
        IDAn.Size = new Size(Class13.UpnW, Class13.vpnw);
        IDAn.TabIndex = Class13.SpnN;
        IDAn.Text = Class13.qpnY;
        IDAn.UseVisualStyleBackColor = true;
        JDAQ.Dock = DockStyle.Fill;
        JDAQ.Location = new Point(3, 3);
        JDAQ.Name = Class13.LpnB;
        JDAQ.Size = new Size(Class13.mpnA, Class13.vpnf);
        JDAQ.TabIndex = 0;
        JDAQ.UseCompatibleStateImageBehavior = false;
        UDAF.Controls.Add(qDAL);
        UDAF.Location = new Point(4, Class13.kpn6);
        UDAF.Name = Class13.Cpnx;
        UDAF.Padding = new Padding(3);
        UDAF.Size = new Size(Class13.Dpn9, Class13.Wpnc);
        UDAF.TabIndex = Class13.Ppny;
        UDAF.Text = Class13.Ipnr;
        UDAF.UseVisualStyleBackColor = true;
        qDAL.Dock = DockStyle.Fill;
        qDAL.Location = new Point(3, 3);
        qDAL.Name = Class13.Lpnq;
        qDAL.Size = new Size(Class13.Ipnk, Class13.kpnM);
        qDAL.TabIndex = 0;
        qDAL.UseCompatibleStateImageBehavior = false;
        QDAJ.Controls.Add(NDA7);
        QDAJ.Location = new Point(4, Class13.cpnu);
        QDAJ.Name = Class13.Bpng;
        QDAJ.Padding = new Padding(3);
        QDAJ.Size = new Size(Class13.Vpn2, Class13.jpn3);
        QDAJ.TabIndex = Class13.Wpnd;
        QDAJ.Text = Class13.zpnH;
        QDAJ.UseVisualStyleBackColor = true;
        NDA7.Dock = DockStyle.Fill;
        NDA7.Location = new Point(3, 3);
        NDA7.Name = Class13.apn4;
        NDA7.Size = new Size(Class13.Apn5, Class13.npns);
        NDA7.TabIndex = 0;
        NDA7.UseCompatibleStateImageBehavior = false;
        mDWS.Controls.Add(aDWh);
        mDWS.Location = new Point(4, Class13.zpnZ);
        mDWS.Name = Class13.Spna;
        mDWS.Padding = new Padding(3);
        mDWS.Size = new Size(Class13.kpnj, Class13.epnz);
        mDWS.TabIndex = 4;
        mDWS.Text = Class13.JpQE;
        mDWS.UseVisualStyleBackColor = true;
        aDWh.Controls.Add(iDWl);
        aDWh.Controls.Add(FDWG);
        aDWh.Dock = DockStyle.Fill;
        aDWh.Location = new Point(3, 3);
        aDWh.Name = Class13.NpQD;
        aDWh.SelectedIndex = 0;
        aDWh.Size = new Size(Class13.LpQX, Class13.MpQp);
        aDWh.TabIndex = 0;
        iDWl.Controls.Add(QDNi);
        iDWl.Controls.Add(kDNS);
        iDWl.Location = new Point(4, Class13.ApQS);
        iDWl.Name = Class13.JpQh;
        iDWl.Padding = new Padding(3);
        iDWl.Size = new Size(Class13.ApQl, Class13.ppQG);
        iDWl.TabIndex = 0;
        iDWl.Text = Class13.HpQb;
        iDWl.UseVisualStyleBackColor = true;
        QDNi.Controls.Add(PDNm);
        QDNi.Controls.Add(jDN0);
        QDNi.Controls.Add(yDNI);
        QDNi.Dock = DockStyle.Fill;
        QDNi.Location = new Point(3, 3);
        QDNi.Name = Class13.JpQv;
        QDNi.SelectedIndex = 0;
        QDNi.Size = new Size(Class13.SpQo, Class13.epQt);
        QDNi.TabIndex = 1;
        PDNm.Controls.Add(ODNR);
        PDNm.Location = new Point(4, Class13.upQV);
        PDNm.Name = Class13.KpQO;
        PDNm.Padding = new Padding(3);
        PDNm.Size = new Size(Class13.KpQe, Class13.QpQ8);
        PDNm.TabIndex = 0;
        PDNm.Text = Class13.TpQn;
        PDNm.UseVisualStyleBackColor = true;
        ODNR.AutoScroll = true;
        ODNR.Dock = DockStyle.Fill;
        ODNR.Location = new Point(3, 3);
        ODNR.Name = Class13.dpQQ;
        ODNR.Size = new Size(Class13.opQF, Class13.KpQL);
        ODNR.TabIndex = 0;
        jDN0.Controls.Add(iDNC);
        jDN0.Location = new Point(4, Class13.QpQJ);
        jDN0.Name = Class13.kpQ7;
        jDN0.Padding = new Padding(3);
        jDN0.Size = new Size(Class13.DpQP, Class13.ypQi);
        jDN0.TabIndex = 1;
        jDN0.Text = Class13.rpQm;
        jDN0.UseVisualStyleBackColor = true;
        iDNC.AutoScroll = true;
        iDNC.Dock = DockStyle.Fill;
        iDNC.Location = new Point(3, 3);
        iDNC.Name = Class13.xpQ0;
        iDNC.Size = new Size(Class13.kpQI, Class13.JpQR);
        iDNC.TabIndex = 0;
        yDNI.Controls.Add(IDNK);
        yDNI.Location = new Point(4, Class13.JpQC);
        yDNI.Name = Class13.kpQK;
        yDNI.Padding = new Padding(3);
        yDNI.Size = new Size(Class13.MpQU, Class13.bpQT);
        yDNI.TabIndex = 2;
        yDNI.Text = Class13.LpQ1;
        yDNI.UseVisualStyleBackColor = true;
        IDNK.AutoScroll = true;
        IDNK.Dock = DockStyle.Fill;
        IDNK.Location = new Point(3, 3);
        IDNK.Name = Class13.OpQW;
        IDNK.Size = new Size(Class13.hpQw, Class13.xpQN);
        IDNK.TabIndex = 0;
        kDNS.ColumnCount = 4;
        kDNS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Class13.KpQY));
        kDNS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Class13.hpQB));
        kDNS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Class13.spQA));
        kDNS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Class13.CpQf));
        kDNS.Controls.Add(rDNh, 0, 0);
        kDNS.Controls.Add(yDNl, 2, 0);
        kDNS.Controls.Add(LDNG, 0, 1);
        kDNS.Controls.Add(KDNb, 2, 1);
        kDNS.Controls.Add(tDNv, 0, 2);
        kDNS.Controls.Add(rDNo, 0, 3);
        kDNS.Controls.Add(MDNt, 0, 4);
        kDNS.Controls.Add(aDNV, 2, 2);
        kDNS.Controls.Add(IDNO, 2, 3);
        kDNS.Controls.Add(iDNe, 1, 0);
        kDNS.Controls.Add(SDN8, 3, 0);
        kDNS.Controls.Add(oDNn, 3, 5);
        kDNS.Controls.Add(UDNQ, 2, 4);
        kDNS.Controls.Add(DDNF, 3, 4);
        kDNS.Controls.Add(LDNL, 1, 4);
        kDNS.Controls.Add(eDNJ, 1, 3);
        kDNS.Controls.Add(rDN7, 3, 3);
        kDNS.Controls.Add(EDNU, 3, 2);
        kDNS.Controls.Add(PDNT, 1, 2);
        kDNS.Controls.Add(dDN1, 1, 1);
        kDNS.Controls.Add(gDNW, 3, 1);
        kDNS.Dock = DockStyle.Right;
        kDNS.Enabled = false;
        kDNS.Location = new Point(Class13.opQ6, 3);
        kDNS.Name = Class13.HpQx;
        kDNS.RowCount = 6;
        kDNS.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.ppQ9));
        kDNS.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.YpQc));
        kDNS.RowStyles.Add(new RowStyle(SizeType.Absolute, Class13.HpQy));
        kDNS.RowStyles.Add(new RowStyle(SizeType.Absolute, Class13.SpQr));
        kDNS.RowStyles.Add(new RowStyle(SizeType.Absolute, Class13.ipQq));
        kDNS.RowStyles.Add(new RowStyle(SizeType.Absolute, Class13.npQk));
        kDNS.Size = new Size(Class13.cpQM, Class13.KpQu);
        kDNS.TabIndex = 0;
        rDNh.Anchor = AnchorStyles.None;
        rDNh.AutoSize = true;
        rDNh.Location = new Point(Class13.lpQg, Class13.JpQ2);
        rDNh.Name = Class13.bpQ3;
        rDNh.Size = new Size(Class13.DpQd, Class13.npQH);
        rDNh.TabIndex = 0;
        rDNh.Text = Class13.WpQ4;
        yDNl.Anchor = AnchorStyles.None;
        yDNl.AutoSize = true;
        yDNl.Location = new Point(Class13.EpQ5, Class13.opQs);
        yDNl.Name = Class13.RpQZ;
        yDNl.Size = new Size(Class13.ppQa, Class13.jpQj);
        yDNl.TabIndex = 1;
        yDNl.Text = Class13.tpQz;
        LDNG.Anchor = AnchorStyles.None;
        LDNG.AutoSize = true;
        LDNG.Location = new Point(Class13.ipFE, Class13.ypFD);
        LDNG.Name = Class13.ApFX;
        LDNG.Size = new Size(Class13.LpFp, Class13.RpFS);
        LDNG.TabIndex = 2;
        LDNG.Text = Class13.DpFh;
        KDNb.Anchor = AnchorStyles.None;
        KDNb.AutoSize = true;
        KDNb.Location = new Point(Class13.xpFl, Class13.JpFG);
        KDNb.Name = Class13.HpFb;
        KDNb.Size = new Size(Class13.SpFv, Class13.SpFo);
        KDNb.TabIndex = 3;
        KDNb.Text = Class13.DpFt;
        tDNv.Anchor = AnchorStyles.None;
        tDNv.AutoSize = true;
        tDNv.Location = new Point(5, Class13.FpFV);
        tDNv.Name = Class13.cpFO;
        tDNv.Size = new Size(Class13.jpFe, Class13.MpF8);
        tDNv.TabIndex = 4;
        tDNv.Text = Class13.TpFn;
        rDNo.Anchor = AnchorStyles.None;
        rDNo.AutoSize = true;
        rDNo.Location = new Point(5, Class13.apFQ);
        rDNo.Name = Class13.DpFF;
        rDNo.Size = new Size(Class13.jpFL, Class13.ipFJ);
        rDNo.TabIndex = 5;
        rDNo.Text = Class13.gpF7;
        MDNt.Anchor = AnchorStyles.None;
        MDNt.AutoSize = true;
        MDNt.Location = new Point(Class13.fpFP, Class13.UpFi);
        MDNt.Name = Class13.vpFm;
        MDNt.Size = new Size(Class13.ypF0, Class13.zpFI);
        MDNt.TabIndex = 7;
        MDNt.Text = Class13.apFR;
        aDNV.Anchor = AnchorStyles.None;
        aDNV.AutoSize = true;
        aDNV.Location = new Point(Class13.epFC, Class13.MpFK);
        aDNV.Name = Class13.MpFU;
        aDNV.Size = new Size(Class13.lpFT, Class13.HpF1);
        aDNV.TabIndex = 6;
        aDNV.Text = Class13.NpFW;
        IDNO.Anchor = AnchorStyles.None;
        IDNO.AutoSize = true;
        IDNO.Location = new Point(Class13.npFw, Class13.TpFN);
        IDNO.Name = Class13.ipFY;
        IDNO.Size = new Size(Class13.gpFB, Class13.fpFA);
        IDNO.TabIndex = 8;
        IDNO.Text = Class13.jpFf;
        iDNe.Anchor = AnchorStyles.None;
        iDNe.AutoSize = true;
        iDNe.Location = new Point(Class13.TpF6, Class13.wpFx);
        iDNe.Name = Class13.LpF9;
        iDNe.Size = new Size(0, Class13.opFc);
        iDNe.TabIndex = Class13.kpFy;
        SDN8.Anchor = AnchorStyles.None;
        SDN8.AutoSize = true;
        SDN8.Location = new Point(Class13.rpFr, Class13.kpFq);
        SDN8.Name = Class13.BpFk;
        SDN8.Size = new Size(0, Class13.MpFM);
        SDN8.TabIndex = Class13.bpFu;
        oDNn.Anchor = AnchorStyles.None;
        oDNn.Location = new Point(Class13.gpFg, Class13.hpF2);
        oDNn.Name = Class13.FpF3;
        oDNn.Size = new Size(Class13.WpFd, Class13.xpFH);
        oDNn.TabIndex = Class13.bpF4;
        oDNn.Text = Class13.JpF5;
        oDNn.UseVisualStyleBackColor = true;
        oDNn.Click += NDIA;
        UDNQ.Anchor = AnchorStyles.None;
        UDNQ.BackColor = Color.Black;
        UDNQ.BackgroundImage = (Image)componentResourceManager.GetObject(Class13.apFs);
        UDNQ.BackgroundImageLayout = ImageLayout.Center;
        UDNQ.Image = (Image)componentResourceManager.GetObject(Class13.xpFZ);
        UDNQ.Location = new Point(Class13.GpFa, Class13.VpFj);
        UDNQ.Name = Class13.rpFz;
        UDNQ.Size = new Size(Class13.apLE, Class13.SpLD);
        UDNQ.TabIndex = Class13.MpLX;
        UDNQ.UseVisualStyleBackColor = false;
        UDNQ.Click += JDI6;
        DDNF.Anchor = AnchorStyles.None;
        DDNF.BackColor = Color.Black;
        DDNF.BackgroundImage = (Image)componentResourceManager.GetObject(Class13.HpLp);
        DDNF.BackgroundImageLayout = ImageLayout.Center;
        DDNF.Image = (Image)componentResourceManager.GetObject(Class13.PpLS);
        DDNF.Location = new Point(Class13.qpLh, Class13.ppLl);
        DDNF.Name = Class13.ipLG;
        DDNF.Size = new Size(Class13.bpLb, Class13.hpLv);
        DDNF.TabIndex = Class13.epLo;
        DDNF.UseVisualStyleBackColor = false;
        DDNF.Click += JDIx;
        LDNL.Anchor = AnchorStyles.None;
        LDNL.BackColor = Color.Black;
        LDNL.BackgroundImage = (Image)componentResourceManager.GetObject(Class13.ApLt);
        LDNL.BackgroundImageLayout = ImageLayout.Center;
        LDNL.Image = (Image)componentResourceManager.GetObject(Class13.FpLV);
        LDNL.Location = new Point(Class13.TpLO, Class13.bpLe);
        LDNL.Name = Class13.SpL8;
        LDNL.Size = new Size(Class13.mpLn, Class13.QpLQ);
        LDNL.TabIndex = Class13.gpLF;
        LDNL.UseVisualStyleBackColor = false;
        LDNL.Click += BDIf;
        eDNJ.Anchor = AnchorStyles.None;
        eDNJ.BackColor = Color.Black;
        eDNJ.BackgroundImage = (Image)componentResourceManager.GetObject(Class13.KpLL);
        eDNJ.BackgroundImageLayout = ImageLayout.Center;
        eDNJ.Image = (Image)componentResourceManager.GetObject(Class13.dpLJ);
        eDNJ.Location = new Point(Class13.fpL7, Class13.JpLP);
        eDNJ.Name = Class13.ApLi;
        eDNJ.Size = new Size(Class13.TpLm, Class13.JpL0);
        eDNJ.TabIndex = Class13.HpLI;
        eDNJ.UseVisualStyleBackColor = false;
        rDN7.Anchor = AnchorStyles.None;
        rDN7.BackColor = Color.White;
        rDN7.BackgroundImage = (Image)componentResourceManager.GetObject(Class13.cpLR);
        rDN7.BackgroundImageLayout = ImageLayout.Center;
        rDN7.Image = (Image)componentResourceManager.GetObject(Class13.BpLC);
        rDN7.Location = new Point(Class13.opLK, Class13.EpLU);
        rDN7.Name = Class13.ppLT;
        rDN7.Size = new Size(Class13.hpL1, Class13.gpLW);
        rDN7.TabIndex = Class13.qpLw;
        rDN7.UseVisualStyleBackColor = false;
        EDNU.Anchor = AnchorStyles.None;
        EDNU.AutoSize = true;
        EDNU.Location = new Point(Class13.DpLN, Class13.ApLY);
        EDNU.Name = Class13.IpLB;
        EDNU.Size = new Size(Class13.mpLA, Class13.YpLf);
        EDNU.TabIndex = Class13.PpL6;
        EDNU.UseVisualStyleBackColor = true;
        PDNT.Anchor = AnchorStyles.None;
        PDNT.Location = new Point(Class13.GpLx, Class13.rpL9);
        PDNT.Name = Class13.TpLc;
        PDNT.Size = new Size(Class13.dpLy, Class13.GpLr);
        PDNT.TabIndex = Class13.mpLq;
        PDNT.ValueChanged += qDIY;
        dDN1.Anchor = AnchorStyles.None;
        dDN1.Location = new Point(Class13.epLk, Class13.XpLM);
        dDN1.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
        dDN1.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        dDN1.Name = Class13.TpLu;
        dDN1.Size = new Size(Class13.MpLg, Class13.kpL2);
        dDN1.TabIndex = Class13.epL3;
        dDN1.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        dDN1.ValueChanged += LDIw;
        gDNW.Anchor = AnchorStyles.None;
        gDNW.Location = new Point(Class13.gpLd, Class13.zpLH);
        gDNW.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
        gDNW.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        gDNW.Name = Class13.WpL4;
        gDNW.Size = new Size(Class13.tpL5, Class13.spLs);
        gDNW.TabIndex = Class13.WpLZ;
        gDNW.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        gDNW.ValueChanged += YDIN;
        FDWG.Controls.Add(UDwy);
        FDWG.Controls.Add(LDww);
        FDWG.Location = new Point(4, Class13.rpLa);
        FDWG.Name = Class13.npLj;
        FDWG.Padding = new Padding(3);
        FDWG.Size = new Size(Class13.opLz, Class13.cpJE);
        FDWG.TabIndex = 1;
        FDWG.Text = Class13.FpJD;
        FDWG.UseVisualStyleBackColor = true;
        UDwy.AutoScroll = true;
        UDwy.Dock = DockStyle.Fill;
        UDwy.Location = new Point(3, 3);
        UDwy.Name = Class13.JpJX;
        UDwy.Size = new Size(Class13.fpJp, Class13.epJS);
        UDwy.TabIndex = 1;
        LDww.ColumnCount = 2;
        LDww.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Class13.MpJh));
        LDww.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Class13.lpJl));
        LDww.Controls.Add(dDwN, 0, 0);
        LDww.Controls.Add(iDwY, 1, 0);
        LDww.Controls.Add(bDwB, 0, 1);
        LDww.Controls.Add(RDwA, 1, 1);
        LDww.Controls.Add(hDwf, 0, 2);
        LDww.Controls.Add(gDw6, 0, 3);
        LDww.Controls.Add(pDwx, 1, 3);
        LDww.Controls.Add(UDw9, 1, 2);
        LDww.Controls.Add(mDwc, 1, 4);
        LDww.Controls.Add(LDAq, 0, 4);
        LDww.Dock = DockStyle.Right;
        LDww.Enabled = false;
        LDww.Location = new Point(Class13.zpJG, 3);
        LDww.Name = Class13.upJb;
        LDww.RowCount = 5;
        LDww.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.HpJv));
        LDww.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.DpJo));
        LDww.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.zpJt));
        LDww.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.qpJV));
        LDww.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.vpJO));
        LDww.RowStyles.Add(new RowStyle(SizeType.Absolute, Class13.apJe));
        LDww.Size = new Size(Class13.apJ8, Class13.YpJn);
        LDww.TabIndex = 0;
        dDwN.Anchor = AnchorStyles.None;
        dDwN.AutoSize = true;
        dDwN.Location = new Point(Class13.xpJQ, Class13.BpJF);
        dDwN.Name = Class13.upJL;
        dDwN.Size = new Size(Class13.VpJJ, Class13.DpJ7);
        dDwN.TabIndex = 0;
        dDwN.Text = Class13.vpJP;
        iDwY.Anchor = AnchorStyles.None;
        iDwY.AutoSize = true;
        iDwY.Location = new Point(Class13.LpJi, Class13.RpJm);
        iDwY.Name = Class13.JpJ0;
        iDwY.Size = new Size(0, Class13.NpJI);
        iDwY.TabIndex = 1;
        bDwB.Anchor = AnchorStyles.None;
        bDwB.AutoSize = true;
        bDwB.Location = new Point(Class13.xpJR, Class13.OpJC);
        bDwB.Name = Class13.LpJK;
        bDwB.Size = new Size(Class13.OpJU, Class13.rpJT);
        bDwB.TabIndex = 2;
        bDwB.Text = Class13.OpJ1;
        RDwA.Anchor = AnchorStyles.None;
        RDwA.AutoSize = true;
        RDwA.Location = new Point(Class13.rpJW, Class13.kpJw);
        RDwA.Name = Class13.hpJN;
        RDwA.Size = new Size(0, Class13.YpJY);
        RDwA.TabIndex = 3;
        hDwf.Anchor = AnchorStyles.None;
        hDwf.AutoSize = true;
        hDwf.Location = new Point(Class13.rpJB, Class13.epJA);
        hDwf.Name = Class13.wpJf;
        hDwf.Size = new Size(Class13.fpJ6, Class13.npJx);
        hDwf.TabIndex = 4;
        hDwf.Text = Class13.PpJ9;
        gDw6.Anchor = AnchorStyles.None;
        gDw6.AutoSize = true;
        gDw6.Location = new Point(Class13.YpJc, Class13.LpJy);
        gDw6.Name = Class13.UpJr;
        gDw6.Size = new Size(Class13.ppJq, Class13.ypJk);
        gDw6.TabIndex = 6;
        gDw6.Text = Class13.DpJM;
        pDwx.Anchor = AnchorStyles.None;
        pDwx.AutoSize = true;
        pDwx.Location = new Point(Class13.BpJu, Class13.JpJg);
        pDwx.Name = Class13.gpJ2;
        pDwx.Size = new Size(Class13.EpJ3, Class13.HpJd);
        pDwx.TabIndex = 7;
        pDwx.UseVisualStyleBackColor = true;
        UDw9.Anchor = AnchorStyles.None;
        UDw9.Location = new Point(Class13.opJH, Class13.NpJ4);
        UDw9.Maximum = new decimal(new int[4] { Class13.fpJ5, 0, 0, 0 });
        UDw9.Name = Class13.EpJs;
        UDw9.Size = new Size(Class13.EpJZ, Class13.QpJa);
        UDw9.TabIndex = 8;
        UDw9.ValueChanged += yDIL;
        mDwc.Anchor = AnchorStyles.None;
        mDwc.Location = new Point(Class13.kpJj, Class13.GpJz);
        mDwc.Name = Class13.yp7E;
        mDwc.Size = new Size(Class13.Fp7D, Class13.Rp7X);
        mDwc.TabIndex = Class13.up7p;
        mDwc.Text = Class13.Tp7S;
        mDwc.UseVisualStyleBackColor = true;
        mDwc.Click += XDIQ;
        LDAq.Anchor = AnchorStyles.None;
        LDAq.Location = new Point(Class13.ip7h, Class13.Sp7l);
        LDAq.Name = Class13.bp7G;
        LDAq.Size = new Size(Class13.Yp7b, Class13.Hp7v);
        LDAq.TabIndex = Class13.ep7o;
        LDAq.Text = Class13.vp7t;
        LDAq.UseVisualStyleBackColor = true;
        LDAq.Click += mDKb;
        EDWb.Controls.Add(MDw0);
        EDWb.Controls.Add(rDwI);
        EDWb.Controls.Add(iDWv);
        EDWb.Controls.Add(DDWO);
        EDWb.Controls.Add(HDWF);
        EDWb.Controls.Add(FDWL);
        EDWb.Controls.Add(aDWJ);
        EDWb.Controls.Add(DDWC);
        EDWb.Controls.Add(GDW9);
        EDWb.Controls.Add(KDWq);
        EDWb.Controls.Add(JDW2);
        EDWb.Controls.Add(rDWH);
        EDWb.Controls.Add(nDwE);
        EDWb.ImeMode = ImeMode.NoControl;
        EDWb.Location = new Point(4, Class13.dp7V);
        EDWb.Name = Class13.Ap7O;
        EDWb.Padding = new Padding(3);
        EDWb.Size = new Size(Class13.ep7e, Class13.Tp78);
        EDWb.TabIndex = 0;
        EDWb.Text = Class13.yp7n;
        EDWb.UseVisualStyleBackColor = true;
        MDw0.Location = new Point(Class13.rp7Q, Class13.Rp7F);
        MDw0.Name = Class13.Pp7L;
        MDw0.Size = new Size(Class13.Sp7J, Class13.up77);
        MDw0.TabIndex = Class13.Tp7P;
        MDw0.Text = Class13.rp7i;
        MDw0.UseVisualStyleBackColor = true;
        MDw0.Click += NDIb;
        rDwI.Location = new Point(Class13.Bp7m, Class13.rp70);
        rDwI.Name = Class13.np7I;
        rDwI.Size = new Size(Class13.zp7R, Class13.Ap7C);
        rDwI.TabIndex = Class13.tp7K;
        rDwI.Text = Class13.Dp7U;
        rDwI.UseVisualStyleBackColor = true;
        rDwI.Click += kDIG;
        iDWv.Controls.Add(ODWo);
        iDWv.Controls.Add(bDWt);
        iDWv.Controls.Add(hDWV);
        iDWv.Location = new Point(Class13.Vp7T, Class13.op71);
        iDWv.Name = Class13.Hp7W;
        iDWv.Size = new Size(Class13.rp7w, Class13.Ep7N);
        iDWv.TabIndex = Class13.xp7Y;
        iDWv.TabStop = false;
        iDWv.Text = Class13.bp7B;
        ODWo.AutoSize = true;
        ODWo.Location = new Point(Class13.jp7A, Class13.ep7f);
        ODWo.Name = Class13.Cp76;
        ODWo.Size = new Size(Class13.qp7x, Class13.Kp79);
        ODWo.TabIndex = Class13.Fp7c;
        ODWo.UseVisualStyleBackColor = true;
        bDWt.DropDownStyle = ComboBoxStyle.DropDownList;
        bDWt.FormattingEnabled = true;
        bDWt.Items.AddRange(new object[6] { Class13.Tp7y, Class13.Op7r, Class13.Np7q, Class13.Vp7k, Class13.rp7M, Class13.Cp7u });
        bDWt.Location = new Point(Class13.kp7g, Class13.np72);
        bDWt.Name = Class13.Ep73;
        bDWt.Size = new Size(Class13.Up7d, Class13.bp7H);
        bDWt.TabIndex = Class13.gp74;
        hDWV.AutoSize = true;
        hDWV.Location = new Point(Class13.Np75, Class13.Pp7s);
        hDWV.Name = Class13.wp7Z;
        hDWV.Size = new Size(Class13.Hp7a, Class13.Gp7j);
        hDWV.TabIndex = Class13.sp7z;
        hDWV.Text = Class13.apPE;
        DDWO.Controls.Add(vDWe);
        DDWO.Controls.Add(CDW8);
        DDWO.Controls.Add(VDWQ);
        DDWO.Location = new Point(Class13.vpPD, Class13.spPX);
        DDWO.Name = Class13.VpPp;
        DDWO.Size = new Size(Class13.GpPS, Class13.IpPh);
        DDWO.TabIndex = Class13.ypPl;
        DDWO.TabStop = false;
        DDWO.Text = Class13.wpPG;
        vDWe.ImeMode = ImeMode.NoControl;
        vDWe.Location = new Point(6, Class13.bpPb);
        vDWe.Name = Class13.QpPv;
        vDWe.Size = new Size(Class13.YpPo, Class13.HpPt);
        vDWe.TabIndex = Class13.BpPV;
        vDWe.Text = Class13.DpPO;
        vDWe.UseVisualStyleBackColor = true;
        vDWe.Click += nD07;
        CDW8.ImeMode = ImeMode.NoControl;
        CDW8.Location = new Point(6, Class13.JpPe);
        CDW8.Name = Class13.FpP8;
        CDW8.Size = new Size(Class13.CpPn, Class13.WpPQ);
        CDW8.TabIndex = Class13.LpPF;
        CDW8.Text = Class13.IpPL;
        CDW8.UseVisualStyleBackColor = true;
        CDW8.Click += RD0i;
        VDWQ.ImeMode = ImeMode.NoControl;
        VDWQ.Location = new Point(6, Class13.ApPJ);
        VDWQ.Name = Class13.rpP7;
        VDWQ.Size = new Size(Class13.vpPP, Class13.qpPi);
        VDWQ.TabIndex = Class13.JpPm;
        VDWQ.Text = Class13.ApP0;
        VDWQ.UseVisualStyleBackColor = true;
        VDWQ.Click += WD0P;
        HDWF.Location = new Point(Class13.jpPI, Class13.JpPR);
        HDWF.Name = Class13.NpPC;
        HDWF.Size = new Size(Class13.gpPK, Class13.HpPU);
        HDWF.TabIndex = Class13.CpPT;
        HDWF.Text = Class13.lpP1;
        HDWF.UseVisualStyleBackColor = true;
        HDWF.Click += pD08;
        FDWL.Location = new Point(Class13.BpPW, Class13.PpPw);
        FDWL.Name = Class13.ipPN;
        FDWL.RightToLeft = RightToLeft.No;
        FDWL.Size = new Size(Class13.epPY, Class13.LpPB);
        FDWL.TabIndex = Class13.CpPA;
        FDWL.Text = Class13.xpPf;
        FDWL.UseVisualStyleBackColor = true;
        FDWL.Click += lD0o;
        aDWJ.Controls.Add(JDW7);
        aDWJ.Controls.Add(TDWP);
        aDWJ.Controls.Add(zDWi);
        aDWJ.Controls.Add(oDWR);
        aDWJ.Location = new Point(Class13.PpP6, Class13.KpPx);
        aDWJ.Name = Class13.spP9;
        aDWJ.Size = new Size(Class13.lpPc, Class13.wpPy);
        aDWJ.TabIndex = Class13.GpPr;
        aDWJ.TabStop = false;
        aDWJ.Text = Class13.PpPq;
        JDW7.AutoSize = true;
        JDW7.Location = new Point(Class13.bpPk, Class13.npPM);
        JDW7.Name = Class13.lpPu;
        JDW7.Size = new Size(Class13.CpPg, Class13.IpP2);
        JDW7.TabIndex = Class13.TpP3;
        JDW7.UseVisualStyleBackColor = true;
        TDWP.AutoSize = true;
        TDWP.ImeMode = ImeMode.NoControl;
        TDWP.Location = new Point(6, Class13.dpPd);
        TDWP.Name = Class13.dpPH;
        TDWP.Size = new Size(Class13.fpP4, Class13.QpP5);
        TDWP.TabIndex = 2;
        TDWP.Text = Class13.HpPs;
        zDWi.Columns.AddRange(new ColumnHeader[3] { PDWm, CDW0, yDWI });
        zDWi.Location = new Point(6, Class13.TpPZ);
        zDWi.Name = Class13.rpPa;
        zDWi.Size = new Size(Class13.mpPj, Class13.ApPz);
        zDWi.TabIndex = 0;
        zDWi.UseCompatibleStateImageBehavior = false;
        zDWi.View = View.Details;
        PDWm.Text = Class13.IpiE;
        PDWm.Width = Class13.FpiD;
        CDW0.Text = Class13.JpiX;
        CDW0.Width = Class13.opip;
        yDWI.Text = Class13.ypiS;
        oDWR.ImeMode = ImeMode.NoControl;
        oDWR.Location = new Point(Class13.Wpih, Class13.ipil);
        oDWR.Name = Class13.hpiG;
        oDWR.Size = new Size(Class13.upib, Class13.Ipiv);
        oDWR.TabIndex = 1;
        oDWR.Text = Class13.Tpio;
        oDWR.UseVisualStyleBackColor = true;
        DDWC.Controls.Add(VDWK);
        DDWC.Controls.Add(NDWU);
        DDWC.Controls.Add(JDWT);
        DDWC.Controls.Add(dDW1);
        DDWC.Controls.Add(MDWW);
        DDWC.Controls.Add(uDWw);
        DDWC.Controls.Add(UDWN);
        DDWC.Controls.Add(lDWY);
        DDWC.Controls.Add(QDWB);
        DDWC.Controls.Add(tDWA);
        DDWC.Controls.Add(eDWf);
        DDWC.Controls.Add(oDW6);
        DDWC.Controls.Add(sDWx);
        DDWC.Location = new Point(Class13.Vpit, Class13.WpiV);
        DDWC.Name = Class13.rpiO;
        DDWC.Size = new Size(Class13.Lpie, Class13.Gpi8);
        DDWC.TabIndex = Class13.Apin;
        DDWC.TabStop = false;
        DDWC.Text = Class13.rpiQ;
        VDWK.AutoSize = true;
        VDWK.Location = new Point(Class13.epiF, Class13.upiL);
        VDWK.Name = Class13.jpiJ;
        VDWK.Size = new Size(Class13.Bpi7, Class13.IpiP);
        VDWK.TabIndex = Class13.Epii;
        VDWK.UseVisualStyleBackColor = true;
        NDWU.Location = new Point(Class13.Spim, Class13.qpi0);
        NDWU.Maximum = new decimal(new int[4] { Class13.KpiI, 0, 0, 0 });
        NDWU.Name = Class13.QpiR;
        NDWU.Size = new Size(Class13.DpiC, Class13.CpiK);
        NDWU.TabIndex = Class13.dpiU;
        JDWT.DropDownStyle = ComboBoxStyle.DropDownList;
        JDWT.FormattingEnabled = true;
        JDWT.Items.AddRange(new object[5] { Class13.UpiT, Class13.Npi1, Class13.hpiW, Class13.fpiw, Class13.ipiN });
        JDWT.Location = new Point(Class13.xpiY, Class13.GpiB);
        JDWT.Name = Class13.FpiA;
        JDWT.Size = new Size(Class13.spif, Class13.Spi6);
        JDWT.TabIndex = Class13.Npix;
        dDW1.AutoSize = true;
        dDW1.ImeMode = ImeMode.NoControl;
        dDW1.Location = new Point(Class13.opi9, Class13.Kpic);
        dDW1.Name = Class13.opiy;
        dDW1.Size = new Size(Class13.hpir, Class13.tpiq);
        dDW1.TabIndex = Class13.Rpik;
        dDW1.Text = Class13.gpiM;
        MDWW.AutoSize = true;
        MDWW.ImeMode = ImeMode.NoControl;
        MDWW.Location = new Point(Class13.vpiu, Class13.vpig);
        MDWW.Name = Class13.Xpi2;
        MDWW.Size = new Size(Class13.Api3, Class13.Dpid);
        MDWW.TabIndex = Class13.bpiH;
        MDWW.Text = Class13.Npi4;
        uDWw.DropDownStyle = ComboBoxStyle.DropDownList;
        uDWw.FormattingEnabled = true;
        uDWw.Items.AddRange(new object[5] { Class13.tpi5, Class13.Npis, Class13.PpiZ, Class13.Mpia, Class13.xpij });
        uDWw.Location = new Point(Class13.ipiz, Class13.npmE);
        uDWw.Name = Class13.opmD;
        uDWw.Size = new Size(Class13.EpmX, Class13.Fpmp);
        uDWw.TabIndex = 7;
        UDWN.AutoSize = true;
        UDWN.ImeMode = ImeMode.NoControl;
        UDWN.Location = new Point(Class13.kpmS, Class13.Rpmh);
        UDWN.Name = Class13.Cpml;
        UDWN.Size = new Size(Class13.XpmG, Class13.Opmb);
        UDWN.TabIndex = 8;
        UDWN.Text = Class13.fpmv;
        lDWY.DropDownStyle = ComboBoxStyle.DropDownList;
        lDWY.FormattingEnabled = true;
        lDWY.Items.AddRange(new object[4] { Class13.Wpmo, Class13.Qpmt, Class13.tpmV, Class13.cpmO });
        lDWY.Location = new Point(Class13.Cpme, Class13.Gpm8);
        lDWY.Name = Class13.Dpmn;
        lDWY.Size = new Size(Class13.RpmQ, Class13.gpmF);
        lDWY.TabIndex = 5;
        QDWB.AutoSize = true;
        QDWB.ImeMode = ImeMode.NoControl;
        QDWB.Location = new Point(Class13.ipmL, Class13.FpmJ);
        QDWB.Name = Class13.mpm7;
        QDWB.Size = new Size(Class13.fpmP, Class13.npmi);
        QDWB.TabIndex = 6;
        QDWB.Text = Class13.Npmm;
        tDWA.DropDownStyle = ComboBoxStyle.DropDownList;
        tDWA.FormattingEnabled = true;
        tDWA.Items.AddRange(new object[4] { Class13.Lpm0, Class13.xpmI, Class13.xpmR, Class13.ApmC });
        tDWA.Location = new Point(Class13.dpmK, Class13.CpmU);
        tDWA.Name = Class13.BpmT;
        tDWA.Size = new Size(Class13.Fpm1, Class13.wpmW);
        tDWA.TabIndex = 1;
        eDWf.AutoSize = true;
        eDWf.ImeMode = ImeMode.NoControl;
        eDWf.Location = new Point(Class13.xpmw, Class13.apmN);
        eDWf.Name = Class13.apmY;
        eDWf.Size = new Size(Class13.OpmB, Class13.BpmA);
        eDWf.TabIndex = 2;
        eDWf.Text = Class13.upmf;
        oDW6.AutoSize = true;
        oDW6.ImeMode = ImeMode.NoControl;
        oDW6.Location = new Point(Class13.Npm6, Class13.opmx);
        oDW6.Name = Class13.Mpm9;
        oDW6.Size = new Size(Class13.mpmc, Class13.Spmy);
        oDW6.TabIndex = 4;
        oDW6.Text = Class13.Npmr;
        sDWx.DropDownStyle = ComboBoxStyle.DropDownList;
        sDWx.FormattingEnabled = true;
        sDWx.Items.AddRange(new object[4] { Class13.Cpmq, Class13.vpmk, Class13.apmM, Class13.upmu });
        sDWx.Location = new Point(Class13.jpmg, Class13.Hpm2);
        sDWx.Name = Class13.lpm3;
        sDWx.Size = new Size(Class13.Qpmd, Class13.UpmH);
        sDWx.TabIndex = 3;
        GDW9.Controls.Add(nDWc);
        GDW9.Controls.Add(UDWy);
        GDW9.Controls.Add(sDWr);
        GDW9.Location = new Point(Class13.gpm4, 6);
        GDW9.Name = Class13.rpm5;
        GDW9.Size = new Size(Class13.Ypms, Class13.bpmZ);
        GDW9.TabIndex = Class13.lpma;
        GDW9.TabStop = false;
        GDW9.Text = Class13.Upmj;
        nDWc.ImeMode = ImeMode.NoControl;
        nDWc.Location = new Point(Class13.Ypmz, Class13.gp0E);
        nDWc.Name = Class13.Pp0D;
        nDWc.Size = new Size(Class13.Xp0X, Class13.Ip0p);
        nDWc.TabIndex = Class13.jp0S;
        nDWc.Text = Class13.mp0h;
        nDWc.UseVisualStyleBackColor = true;
        nDWc.Click += lD0J;
        UDWy.ImeMode = ImeMode.NoControl;
        UDWy.Location = new Point(Class13.Np0l, Class13.Bp0G);
        UDWy.Name = Class13.yp0b;
        UDWy.Size = new Size(Class13.Gp0v, Class13.rp0o);
        UDWy.TabIndex = Class13.sp0t;
        UDWy.Text = Class13.Bp0V;
        UDWy.UseVisualStyleBackColor = true;
        UDWy.Click += ID0e;
        sDWr.ImeMode = ImeMode.NoControl;
        sDWr.Location = new Point(Class13.Yp0O, Class13.Mp0e);
        sDWr.Name = Class13.bp08;
        sDWr.Size = new Size(Class13.Up0n, Class13.Ip0Q);
        sDWr.TabIndex = Class13.up0F;
        sDWr.Text = Class13.fp0L;
        sDWr.UseVisualStyleBackColor = true;
        sDWr.Click += eD0V;
        KDWq.Controls.Add(LDWk);
        KDWq.Controls.Add(vDWM);
        KDWq.Controls.Add(BDWu);
        KDWq.Controls.Add(zDWg);
        KDWq.Location = new Point(Class13.gp0J, 6);
        KDWq.Name = Class13.Mp07;
        KDWq.Size = new Size(Class13.ap0P, Class13.Jp0i);
        KDWq.TabIndex = 3;
        KDWq.TabStop = false;
        KDWq.Text = Class13.ap0m;
        LDWk.Location = new Point(6, Class13.tp00);
        LDWk.Name = Class13.yp0I;
        LDWk.Size = new Size(Class13.Mp0R, Class13.hp0C);
        LDWk.TabIndex = 4;
        LDWk.Text = Class13.yp0K;
        LDWk.UseVisualStyleBackColor = true;
        LDWk.Click += dD0F;
        vDWM.Location = new Point(6, Class13.dp0U);
        vDWM.Name = Class13.Hp0T;
        vDWM.Size = new Size(Class13.op01, Class13.Op0W);
        vDWM.TabIndex = 5;
        vDWM.Text = Class13.Sp0w;
        vDWM.UseVisualStyleBackColor = true;
        vDWM.Click += ND0Q;
        BDWu.Location = new Point(6, Class13.Xp0N);
        BDWu.Name = Class13.Np0Y;
        BDWu.Size = new Size(Class13.kp0B, Class13.Ap0A);
        BDWu.TabIndex = 1;
        BDWu.Text = Class13.Qp0f;
        BDWu.UseVisualStyleBackColor = true;
        BDWu.Click += tD0L;
        zDWg.Location = new Point(6, Class13.Mp06);
        zDWg.Name = Class13.Fp0x;
        zDWg.Size = new Size(Class13.Op09, Class13.vp0c);
        zDWg.TabIndex = 0;
        zDWg.Text = Class13.xp0y;
        zDWg.UseVisualStyleBackColor = true;
        zDWg.Click += hD0n;
        JDW2.Controls.Add(KDW3);
        JDW2.Controls.Add(QDWd);
        JDW2.Location = new Point(Class13.ep0r, 6);
        JDW2.Name = Class13.Gp0q;
        JDW2.Size = new Size(Class13.lp0k, Class13.Mp0M);
        JDW2.TabIndex = 2;
        JDW2.TabStop = false;
        JDW2.Text = Class13.Rp0u;
        KDW3.Location = new Point(6, Class13.ep0g);
        KDW3.Name = Class13.Sp02;
        KDW3.Size = new Size(Class13.Cp03, Class13.Yp0d);
        KDW3.TabIndex = 1;
        KDW3.Text = Class13.Bp0H;
        KDW3.UseVisualStyleBackColor = true;
        KDW3.Click += JD0I;
        QDWd.Location = new Point(6, Class13.gp04);
        QDWd.Name = Class13.pp05;
        QDWd.Size = new Size(Class13.wp0s, Class13.Sp0Z);
        QDWd.TabIndex = 0;
        QDWd.Text = Class13.up0a;
        QDWd.UseVisualStyleBackColor = true;
        QDWd.Click += iD00;
        rDWH.Controls.Add(vDW4);
        rDWH.Controls.Add(WDW5);
        rDWH.Controls.Add(rDWs);
        rDWH.Controls.Add(yDWZ);
        rDWH.Controls.Add(tDWa);
        rDWH.Controls.Add(jDWj);
        rDWH.Controls.Add(wDWz);
        rDWH.Location = new Point(Class13.qp0j, 6);
        rDWH.Name = Class13.tp0z;
        rDWH.Size = new Size(Class13.SpIE, Class13.WpID);
        rDWH.TabIndex = 1;
        rDWH.TabStop = false;
        rDWH.Text = Class13.MpIX;
        vDW4.AutoSize = true;
        vDW4.Location = new Point(Class13.UpIp, 8);
        vDW4.Name = Class13.spIS;
        vDW4.Size = new Size(Class13.gpIh, Class13.zpIl);
        vDW4.TabIndex = Class13.NpIG;
        vDW4.UseVisualStyleBackColor = true;
        WDW5.DropDownStyle = ComboBoxStyle.DropDownList;
        WDW5.FormattingEnabled = true;
        WDW5.Items.AddRange(new object[7] { Class13.HpIb, Class13.xpIv, Class13.MpIo, Class13.DpIt, Class13.vpIV, Class13.MpIO, Class13.epIe });
        WDW5.Location = new Point(Class13.epI8, Class13.PpIn);
        WDW5.Name = Class13.ApIQ;
        WDW5.Size = new Size(Class13.DpIF, Class13.rpIL);
        WDW5.TabIndex = Class13.npIJ;
        rDWs.DropDownStyle = ComboBoxStyle.DropDownList;
        rDWs.FormattingEnabled = true;
        rDWs.Items.AddRange(new object[7] { Class13.RpI7, Class13.vpIP, Class13.DpIi, Class13.VpIm, Class13.BpI0, Class13.ppII, Class13.apIR });
        rDWs.Location = new Point(Class13.fpIC, Class13.vpIK);
        rDWs.Name = Class13.epIU;
        rDWs.Size = new Size(Class13.XpIT, Class13.VpI1);
        rDWs.TabIndex = Class13.bpIW;
        yDWZ.DropDownStyle = ComboBoxStyle.DropDownList;
        yDWZ.FormattingEnabled = true;
        yDWZ.Items.AddRange(new object[3] { Class13.IpIw, Class13.WpIN, Class13.HpIY });
        yDWZ.Location = new Point(Class13.LpIB, Class13.hpIA);
        yDWZ.Name = Class13.apIf;
        yDWZ.Size = new Size(Class13.bpI6, Class13.GpIx);
        yDWZ.TabIndex = 8;
        tDWa.AutoSize = true;
        tDWa.Location = new Point(6, Class13.EpI9);
        tDWa.Name = Class13.VpIc;
        tDWa.Size = new Size(Class13.KpIy, Class13.ApIr);
        tDWa.TabIndex = 5;
        tDWa.Text = Class13.LpIq;
        jDWj.AutoSize = true;
        jDWj.Location = new Point(6, Class13.spIk);
        jDWj.Name = Class13.CpIM;
        jDWj.Size = new Size(Class13.lpIu, Class13.YpIg);
        jDWj.TabIndex = 3;
        jDWj.Text = Class13.MpI2;
        wDWz.AutoSize = true;
        wDWz.Location = new Point(6, Class13.OpI3);
        wDWz.Name = Class13.GpId;
        wDWz.Size = new Size(Class13.UpIH, Class13.ApI4);
        wDWz.TabIndex = 1;
        wDWz.Text = Class13.VpI5;
        nDwE.Controls.Add(UDwD);
        nDwE.Controls.Add(GDwX);
        nDwE.Controls.Add(UDwp);
        nDwE.Controls.Add(XDwS);
        nDwE.Controls.Add(VDwh);
        nDwE.Controls.Add(sDwl);
        nDwE.Controls.Add(tDwG);
        nDwE.Controls.Add(EDwb);
        nDwE.Controls.Add(VDwv);
        nDwE.Controls.Add(mDwo);
        nDwE.Location = new Point(6, 6);
        nDwE.Name = Class13.ipIs;
        nDwE.Size = new Size(Class13.MpIZ, Class13.mpIa);
        nDwE.TabIndex = 0;
        nDwE.TabStop = false;
        nDwE.Text = Class13.rpIj;
        UDwD.Location = new Point(Class13.kpIz, Class13.JpRE);
        UDwD.Maximum = new decimal(new int[4] { Class13.TpRD, 0, 0, 0 });
        UDwD.Name = Class13.opRX;
        UDwD.Size = new Size(Class13.ipRp, Class13.IpRS);
        UDwD.TabIndex = Class13.bpRh;
        GDwX.AutoSize = true;
        GDwX.Location = new Point(Class13.xpRl, 8);
        GDwX.Name = Class13.upRG;
        GDwX.Size = new Size(Class13.spRb, Class13.XpRv);
        GDwX.TabIndex = Class13.hpRo;
        GDwX.UseVisualStyleBackColor = true;
        UDwp.DropDownStyle = ComboBoxStyle.DropDownList;
        UDwp.FormattingEnabled = true;
        ComboBox.ObjectCollection items10 = UDwp.Items;
        object[] array10 = new object[Class13.vpRt];
        array10[0] = Class13.rpRV;
        array10[1] = Class13.kpRO;
        array10[2] = Class13.dpRe;
        array10[3] = Class13.NpR8;
        array10[4] = Class13.DpRn;
        array10[5] = Class13.vpRQ;
        array10[6] = Class13.jpRF;
        array10[7] = Class13.lpRL;
        array10[8] = Class13.cpRJ;
        array10[Class13.wpR7] = Class13.npRP;
        array10[Class13.QpRi] = Class13.WpRm;
        items10.AddRange(array10);
        UDwp.Location = new Point(Class13.CpR0, Class13.EpRI);
        UDwp.Name = Class13.ppRR;
        UDwp.Size = new Size(Class13.lpRC, Class13.wpRK);
        UDwp.TabIndex = 7;
        XDwS.AutoSize = true;
        XDwS.Location = new Point(6, Class13.kpRU);
        XDwS.Name = Class13.UpRT;
        XDwS.Size = new Size(Class13.TpR1, Class13.rpRW);
        XDwS.TabIndex = 6;
        XDwS.Text = Class13.apRw;
        VDwh.AutoSize = true;
        VDwh.Location = new Point(6, Class13.apRN);
        VDwh.Name = Class13.PpRY;
        VDwh.Size = new Size(Class13.fpRB, Class13.BpRA);
        VDwh.TabIndex = 5;
        VDwh.Text = Class13.YpRf;
        sDwl.Location = new Point(Class13.JpR6, Class13.kpRx);
        sDwl.Maximum = new decimal(new int[4] { Class13.XpR9, 0, 0, 0 });
        sDwl.Name = Class13.ppRc;
        sDwl.Size = new Size(Class13.OpRy, Class13.ppRr);
        sDwl.TabIndex = 4;
        tDwG.AutoSize = true;
        tDwG.Location = new Point(6, Class13.LpRq);
        tDwG.Name = Class13.jpRk;
        tDwG.Size = new Size(Class13.mpRM, Class13.MpRu);
        tDwG.TabIndex = 3;
        tDwG.Text = Class13.WpRg;
        EDwb.Location = new Point(Class13.WpR2, Class13.apR3);
        EDwb.Maximum = new decimal(new int[4] { Class13.vpRd, 0, 0, 0 });
        EDwb.Name = Class13.ppRH;
        EDwb.Size = new Size(Class13.RpR4, Class13.gpR5);
        EDwb.TabIndex = 2;
        VDwv.AutoSize = true;
        VDwv.Location = new Point(6, Class13.dpRs);
        VDwv.Name = Class13.WpRZ;
        VDwv.Size = new Size(Class13.XpRa, Class13.lpRj);
        VDwv.TabIndex = 1;
        VDwv.Text = Class13.dpRz;
        mDwo.Location = new Point(Class13.GpCE, Class13.opCD);
        mDwo.Maximum = new decimal(new int[4] { Class13.RpCX, 0, 0, 0 });
        mDwo.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        mDwo.Name = Class13.MpCp;
        mDwo.Size = new Size(Class13.vpCS, Class13.OpCh);
        mDwo.TabIndex = 0;
        mDwo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        GDwt.Controls.Add(EDWb);
        GDwt.Controls.Add(mDWS);
        GDwt.Controls.Add(oD18);
        GDwt.Controls.Add(jDTB);
        GDwt.Controls.Add(uDxp);
        GDwt.Controls.Add(iD6Z);
        GDwt.Enabled = false;
        GDwt.Location = new Point(Class13.KpCl, -1);
        GDwt.Name = Class13.lpCG;
        GDwt.SelectedIndex = 0;
        GDwt.Size = new Size(Class13.kpCb, Class13.lpCv);
        GDwt.TabIndex = Class13.fpCo;
        uDxp.AutoScroll = true;
        uDxp.Controls.Add(fDxS);
        uDxp.Controls.Add(oDxh);
        uDxp.Controls.Add(nDxl);
        uDxp.Controls.Add(pDxG);
        uDxp.Controls.Add(bDxb);
        uDxp.Controls.Add(yDxv);
        uDxp.Controls.Add(qDxo);
        uDxp.Controls.Add(ADxt);
        uDxp.Controls.Add(DDxV);
        uDxp.Controls.Add(GDxO);
        uDxp.Controls.Add(yDxe);
        uDxp.Controls.Add(vDx8);
        uDxp.Controls.Add(nDxn);
        uDxp.Controls.Add(RDxQ);
        uDxp.Controls.Add(MDxF);
        uDxp.Controls.Add(JDxL);
        uDxp.Location = new Point(4, Class13.NpCt);
        uDxp.Name = Class13.RpCV;
        uDxp.Padding = new Padding(3);
        uDxp.Size = new Size(Class13.upCO, Class13.WpCe);
        uDxp.TabIndex = 5;
        uDxp.Text = Class13.apC8;
        uDxp.UseVisualStyleBackColor = true;
        fDxS.AutoSize = true;
        fDxS.Location = new Point(Class13.cpCn, 3);
        fDxS.Name = Class13.ipCQ;
        fDxS.Size = new Size(0, Class13.OpCF);
        fDxS.TabIndex = Class13.wpCL;
        oDxh.AutoSize = true;
        oDxh.Location = new Point(Class13.LpCJ, 3);
        oDxh.Name = Class13.kpC7;
        oDxh.Size = new Size(0, Class13.kpCP);
        oDxh.TabIndex = Class13.UpCi;
        nDxl.Location = new Point(Class13.KpCm, Class13.cpC0);
        nDxl.Name = Class13.UpCI;
        nDxl.Size = new Size(Class13.tpCR, Class13.jpCC);
        nDxl.TabIndex = Class13.BpCK;
        nDxl.TabStop = false;
        pDxG.Location = new Point(Class13.ipCU, Class13.qpCT);
        pDxG.Name = Class13.vpC1;
        pDxG.Size = new Size(Class13.npCW, Class13.dpCw);
        pDxG.TabIndex = Class13.MpCN;
        pDxG.TabStop = false;
        bDxb.Location = new Point(Class13.cpCY, 3);
        bDxb.Name = Class13.QpCB;
        bDxb.Size = new Size(Class13.epCA, Class13.NpCf);
        bDxb.TabIndex = Class13.PpC6;
        bDxb.TabStop = false;
        yDxv.Location = new Point(Class13.wpCx, 3);
        yDxv.Name = Class13.xpC9;
        yDxv.Size = new Size(Class13.kpCc, Class13.UpCy);
        yDxv.TabIndex = Class13.SpCr;
        yDxv.TabStop = false;
        qDxo.Location = new Point(Class13.SpCq, Class13.apCk);
        qDxo.Name = Class13.YpCM;
        qDxo.Size = new Size(Class13.npCu, Class13.dpCg);
        qDxo.TabIndex = Class13.cpC2;
        qDxo.TabStop = false;
        ADxt.Location = new Point(Class13.lpC3, Class13.ypCd);
        ADxt.Name = Class13.epCH;
        ADxt.Size = new Size(Class13.FpC4, Class13.EpC5);
        ADxt.TabIndex = Class13.lpCs;
        ADxt.TabStop = false;
        DDxV.Location = new Point(Class13.rpCZ, 3);
        DDxV.Name = Class13.TpCa;
        DDxV.Size = new Size(Class13.VpCj, Class13.ypCz);
        DDxV.TabIndex = Class13.XpKE;
        DDxV.TabStop = false;
        GDxO.Location = new Point(Class13.dpKD, 3);
        GDxO.Name = Class13.vpKX;
        GDxO.Size = new Size(Class13.qpKp, Class13.WpKS);
        GDxO.TabIndex = Class13.UpKh;
        GDxO.TabStop = false;
        yDxe.AutoSize = true;
        yDxe.Location = new Point(Class13.VpKl, 3);
        yDxe.Name = Class13.ppKG;
        yDxe.Size = new Size(0, Class13.ipKb);
        yDxe.TabIndex = Class13.WpKv;
        vDx8.Location = new Point(6, Class13.xpKo);
        vDx8.Name = Class13.FpKt;
        vDx8.Size = new Size(Class13.vpKV, Class13.JpKO);
        vDx8.TabIndex = Class13.BpKe;
        vDx8.TabStop = false;
        nDxn.AutoSize = true;
        nDxn.Location = new Point(Class13.tpK8, 3);
        nDxn.Name = Class13.dpKn;
        nDxn.Size = new Size(0, Class13.PpKQ);
        nDxn.TabIndex = Class13.hpKF;
        RDxQ.ColumnCount = 5;
        RDxQ.ColumnStyles.Add(new ColumnStyle());
        RDxQ.ColumnStyles.Add(new ColumnStyle());
        RDxQ.ColumnStyles.Add(new ColumnStyle());
        RDxQ.ColumnStyles.Add(new ColumnStyle());
        RDxQ.ColumnStyles.Add(new ColumnStyle());
        RDxQ.Location = new Point(Class13.WpKL, Class13.CpKJ);
        RDxQ.Name = Class13.gpK7;
        RDxQ.RowCount = 6;
        RDxQ.RowStyles.Add(new RowStyle());
        RDxQ.RowStyles.Add(new RowStyle());
        RDxQ.RowStyles.Add(new RowStyle());
        RDxQ.RowStyles.Add(new RowStyle());
        RDxQ.RowStyles.Add(new RowStyle());
        RDxQ.RowStyles.Add(new RowStyle(SizeType.Absolute, Class13.FpKP));
        RDxQ.Size = new Size(Class13.epKi, Class13.ppKm);
        RDxQ.TabIndex = Class13.LpK0;
        MDxF.ColumnCount = 5;
        MDxF.ColumnStyles.Add(new ColumnStyle());
        MDxF.ColumnStyles.Add(new ColumnStyle());
        MDxF.ColumnStyles.Add(new ColumnStyle());
        MDxF.ColumnStyles.Add(new ColumnStyle());
        MDxF.ColumnStyles.Add(new ColumnStyle());
        MDxF.Location = new Point(6, Class13.fpKI);
        MDxF.Name = Class13.upKR;
        MDxF.RowCount = 5;
        MDxF.RowStyles.Add(new RowStyle());
        MDxF.RowStyles.Add(new RowStyle());
        MDxF.RowStyles.Add(new RowStyle());
        MDxF.RowStyles.Add(new RowStyle());
        MDxF.RowStyles.Add(new RowStyle());
        MDxF.RowStyles.Add(new RowStyle(SizeType.Absolute, Class13.PpKC));
        MDxF.Size = new Size(Class13.WpKK, Class13.KpKU);
        MDxF.TabIndex = 0;
        JDxL.AutoSize = true;
        JDxL.Location = new Point(Class13.ppKT, 3);
        JDxL.Name = Class13.DpK1;
        JDxL.Size = new Size(0, Class13.ApKW);
        JDxL.TabIndex = Class13.DpKw;
        iD6Z.Controls.Add(FDxX);
        iD6Z.Controls.Add(yD6a);
        iD6Z.Controls.Add(iD6j);
        iD6Z.Controls.Add(JD6z);
        iD6Z.Controls.Add(sDxE);
        iD6Z.Controls.Add(VDxD);
        iD6Z.Location = new Point(4, Class13.JpKN);
        iD6Z.Name = Class13.opKY;
        iD6Z.Padding = new Padding(3);
        iD6Z.Size = new Size(Class13.FpKB, Class13.jpKA);
        iD6Z.TabIndex = 6;
        iD6Z.Text = Class13.SpKf;
        iD6Z.UseVisualStyleBackColor = true;
        FDxX.FormattingEnabled = true;
        FDxX.HorizontalScrollbar = true;
        FDxX.Location = new Point(Class13.kpK6, Class13.upKx);
        FDxX.Name = Class13.tpK9;
        FDxX.Size = new Size(Class13.CpKc, Class13.rpKy);
        FDxX.TabIndex = 5;
        yD6a.Location = new Point(Class13.wpKr, Class13.CpKq);
        yD6a.Name = Class13.DpKk;
        yD6a.Size = new Size(Class13.SpKM, Class13.jpKu);
        yD6a.TabIndex = 4;
        yD6a.Text = Class13.DpKg;
        yD6a.UseVisualStyleBackColor = true;
        yD6a.Click += PDU9;
        iD6j.Location = new Point(Class13.opK2, Class13.XpK3);
        iD6j.Name = Class13.ppKd;
        iD6j.Size = new Size(Class13.BpKH, Class13.mpK4);
        iD6j.TabIndex = 3;
        iD6j.Text = Class13.ypK5;
        iD6j.UseVisualStyleBackColor = true;
        iD6j.Click += tDUr;
        JD6z.Location = new Point(Class13.mpKs, Class13.SpKZ);
        JD6z.Name = Class13.SpKa;
        JD6z.Size = new Size(Class13.zpKj, Class13.vpKz);
        JD6z.TabIndex = 2;
        JD6z.Text = Class13.DpUE;
        JD6z.UseVisualStyleBackColor = true;
        JD6z.Click += LDUy;
        sDxE.FormattingEnabled = true;
        sDxE.HorizontalScrollbar = true;
        sDxE.Location = new Point(Class13.JpUD, 6);
        sDxE.Name = Class13.zpUX;
        sDxE.Size = new Size(Class13.xpUp, Class13.WpUS);
        sDxE.TabIndex = 1;
        VDxD.FormattingEnabled = true;
        VDxD.Location = new Point(6, 6);
        VDxD.MultiColumn = true;
        VDxD.Name = Class13.rpUh;
        VDxD.Size = new Size(Class13.ipUl, Class13.UpUG);
        VDxD.TabIndex = 0;
        nDwg.Text = Class13.ApUb;
        pDw2.Text = Class13.TpUv;
        pDw2.Width = Class13.GpUo;
        nDw3.Text = Class13.spUt;
        nDw3.Width = Class13.FpUV;
        NDwd.Text = Class13.fpUO;
        QDwH.Text = Class13.CpUe;
        TD6c.DoWork += QDU7;
        VDxJ.Anchor = AnchorStyles.None;
        VDxJ.BackColor = Color.DarkGray;
        VDxJ.BackgroundImageLayout = ImageLayout.Center;
        VDxJ.Image = (Image)componentResourceManager.GetObject(Class13.ypU8);
        VDxJ.Location = new Point(Class13.RpUn, Class13.WpUQ);
        VDxJ.Name = Class13.upUF;
        VDxJ.Size = new Size(Class13.epUL, Class13.JpUJ);
        VDxJ.SizeMode = PictureBoxSizeMode.StretchImage;
        VDxJ.TabIndex = Class13.ppU7;
        VDxJ.TabStop = false;
        sDx7.Anchor = AnchorStyles.None;
        sDx7.BackColor = Color.DarkGray;
        sDx7.BackgroundImageLayout = ImageLayout.Center;
        sDx7.Image = (Image)componentResourceManager.GetObject(Class13.NpUP);
        sDx7.Location = new Point(Class13.mpUi, Class13.SpUm);
        sDx7.Name = Class13.cpU0;
        sDx7.Size = new Size(Class13.mpUI, Class13.ApUR);
        sDx7.SizeMode = PictureBoxSizeMode.StretchImage;
        sDx7.TabIndex = Class13.dpUC;
        sDx7.TabStop = false;
        WDxP.Anchor = AnchorStyles.None;
        WDxP.BackColor = Color.DarkGray;
        WDxP.BackgroundImageLayout = ImageLayout.Center;
        WDxP.Image = (Image)componentResourceManager.GetObject(Class13.LpUK);
        WDxP.Location = new Point(Class13.ipUU, Class13.dpUT);
        WDxP.Name = Class13.opU1;
        WDxP.Size = new Size(Class13.apUW, Class13.xpUw);
        WDxP.SizeMode = PictureBoxSizeMode.StretchImage;
        WDxP.TabIndex = Class13.fpUN;
        WDxP.TabStop = false;
        yDxi.Anchor = AnchorStyles.None;
        yDxi.BackColor = Color.DarkGray;
        yDxi.BackgroundImageLayout = ImageLayout.Center;
        yDxi.Image = (Image)componentResourceManager.GetObject(Class13.GpUY);
        yDxi.Location = new Point(Class13.DpUB, Class13.SpUA);
        yDxi.Name = Class13.ipUf;
        yDxi.Size = new Size(Class13.ypU6, Class13.KpUx);
        yDxi.SizeMode = PictureBoxSizeMode.StretchImage;
        yDxi.TabIndex = Class13.jpU9;
        yDxi.TabStop = false;
        jDxm.Anchor = AnchorStyles.None;
        jDxm.BackColor = Color.DarkGray;
        jDxm.BackgroundImageLayout = ImageLayout.Center;
        jDxm.Image = (Image)componentResourceManager.GetObject(Class13.CpUc);
        jDxm.Location = new Point(Class13.UpUy, Class13.dpUr);
        jDxm.Name = Class13.xpUq;
        jDxm.Size = new Size(Class13.IpUk, Class13.HpUM);
        jDxm.SizeMode = PictureBoxSizeMode.StretchImage;
        jDxm.TabIndex = Class13.zpUu;
        jDxm.TabStop = false;
        aDx0.Anchor = AnchorStyles.None;
        aDx0.BackColor = Color.DarkGray;
        aDx0.BackgroundImageLayout = ImageLayout.Center;
        aDx0.Image = (Image)componentResourceManager.GetObject(Class13.SpUg);
        aDx0.Location = new Point(Class13.gpU2, Class13.MpU3);
        aDx0.Name = Class13.LpUd;
        aDx0.Size = new Size(Class13.zpUH, Class13.OpU4);
        aDx0.SizeMode = PictureBoxSizeMode.StretchImage;
        aDx0.TabIndex = Class13.XpU5;
        aDx0.TabStop = false;
        pDxI.Anchor = AnchorStyles.None;
        pDxI.AutoSize = true;
        pDxI.Location = new Point(Class13.vpUs, Class13.KpUZ);
        pDxI.Name = Class13.KpUa;
        pDxI.Size = new Size(0, Class13.npUj);
        pDxI.TabIndex = Class13.lpUz;
        DDxR.Anchor = AnchorStyles.None;
        DDxR.AutoSize = true;
        DDxR.Location = new Point(Class13.EpTE, Class13.ypTD);
        DDxR.Name = Class13.UpTX;
        DDxR.Size = new Size(0, Class13.NpTp);
        DDxR.TabIndex = Class13.CpTS;
        kDxC.Anchor = AnchorStyles.None;
        kDxC.AutoSize = true;
        kDxC.Location = new Point(Class13.tpTh, Class13.HpTl);
        kDxC.Name = Class13.GpTG;
        kDxC.Size = new Size(0, Class13.ApTb);
        kDxC.TabIndex = Class13.VpTv;
        lDxK.Anchor = AnchorStyles.None;
        lDxK.AutoSize = true;
        lDxK.Location = new Point(Class13.opTo, Class13.npTt);
        lDxK.Name = Class13.MpTV;
        lDxK.Size = new Size(0, Class13.FpTO);
        lDxK.TabIndex = Class13.vpTe;
        ADxU.Anchor = AnchorStyles.None;
        ADxU.AutoSize = true;
        ADxU.Location = new Point(Class13.NpT8, 0);
        ADxU.Name = Class13.bpTn;
        ADxU.Size = new Size(Class13.tpTQ, Class13.OpTF);
        ADxU.TabIndex = Class13.DpTL;
        CDxT.Anchor = AnchorStyles.None;
        CDxT.AutoSize = true;
        CDxT.Location = new Point(Class13.lpTJ, 0);
        CDxT.Name = Class13.kpT7;
        CDxT.Size = new Size(Class13.qpTP, Class13.opTi);
        CDxT.TabIndex = Class13.spTm;
        HDx1.Anchor = AnchorStyles.None;
        HDx1.AutoSize = true;
        HDx1.Location = new Point(Class13.epT0, 0);
        HDx1.Name = Class13.qpTI;
        HDx1.Size = new Size(Class13.gpTR, Class13.rpTC);
        HDx1.TabIndex = Class13.SpTK;
        KDxW.Anchor = AnchorStyles.None;
        KDxW.AutoSize = true;
        KDxW.Location = new Point(Class13.IpTU, 0);
        KDxW.Name = Class13.MpTT;
        KDxW.Size = new Size(Class13.GpT1, Class13.mpTW);
        KDxW.TabIndex = Class13.upTw;
        rDxw.Anchor = AnchorStyles.None;
        rDxw.AutoSize = true;
        rDxw.Location = new Point(3, 0);
        rDxw.Name = Class13.zpTN;
        rDxw.Size = new Size(Class13.xpTY, Class13.dpTB);
        rDxw.TabIndex = Class13.opTA;
        TDxN.Anchor = AnchorStyles.None;
        TDxN.BackColor = Color.DarkGray;
        TDxN.BackgroundImageLayout = ImageLayout.Center;
        TDxN.Image = (Image)componentResourceManager.GetObject(Class13.NpTf);
        TDxN.Location = new Point(Class13.lpT6, Class13.YpTx);
        TDxN.Name = Class13.bpT9;
        TDxN.Size = new Size(Class13.JpTc, Class13.MpTy);
        TDxN.SizeMode = PictureBoxSizeMode.StretchImage;
        TDxN.TabIndex = Class13.jpTr;
        TDxN.TabStop = false;
        PDxY.Anchor = AnchorStyles.None;
        PDxY.BackColor = Color.DarkGray;
        PDxY.BackgroundImageLayout = ImageLayout.Center;
        PDxY.Image = (Image)componentResourceManager.GetObject(Class13.ypTq);
        PDxY.Location = new Point(Class13.LpTk, Class13.dpTM);
        PDxY.Name = Class13.QpTu;
        PDxY.Size = new Size(Class13.lpTg, Class13.JpT2);
        PDxY.SizeMode = PictureBoxSizeMode.StretchImage;
        PDxY.TabIndex = Class13.gpT3;
        PDxY.TabStop = false;
        zDxB.Anchor = AnchorStyles.None;
        zDxB.BackColor = Color.DarkGray;
        zDxB.BackgroundImageLayout = ImageLayout.Center;
        zDxB.Image = (Image)componentResourceManager.GetObject(Class13.NpTd);
        zDxB.Location = new Point(Class13.FpTH, Class13.ipT4);
        zDxB.Name = Class13.HpT5;
        zDxB.Size = new Size(Class13.apTs, Class13.RpTZ);
        zDxB.SizeMode = PictureBoxSizeMode.StretchImage;
        zDxB.TabIndex = Class13.jpTa;
        zDxB.TabStop = false;
        pDxA.Anchor = AnchorStyles.None;
        pDxA.BackColor = Color.DarkGray;
        pDxA.BackgroundImageLayout = ImageLayout.Center;
        pDxA.Image = (Image)componentResourceManager.GetObject(Class13.VpTj);
        pDxA.Location = new Point(Class13.mpTz, Class13.Bp1E);
        pDxA.Name = Class13.Kp1D;
        pDxA.Size = new Size(Class13.wp1X, Class13.cp1p);
        pDxA.SizeMode = PictureBoxSizeMode.StretchImage;
        pDxA.TabIndex = Class13.Qp1S;
        pDxA.TabStop = false;
        JDxf.Anchor = AnchorStyles.None;
        JDxf.BackColor = Color.DarkGray;
        JDxf.BackgroundImageLayout = ImageLayout.Center;
        JDxf.Image = (Image)componentResourceManager.GetObject(Class13.mp1h);
        JDxf.Location = new Point(Class13.Dp1l, Class13.Mp1G);
        JDxf.Name = Class13.Kp1b;
        JDxf.Size = new Size(Class13.cp1v, Class13.Fp1o);
        JDxf.SizeMode = PictureBoxSizeMode.StretchImage;
        JDxf.TabIndex = 8;
        JDxf.TabStop = false;
        KDx6.Anchor = AnchorStyles.None;
        KDx6.BackColor = Color.DarkGray;
        KDx6.BackgroundImageLayout = ImageLayout.Center;
        KDx6.Image = (Image)componentResourceManager.GetObject(Class13.Hp1t);
        KDx6.Location = new Point(Class13.np1V, Class13.Up1O);
        KDx6.Name = Class13.Rp1e;
        KDx6.Size = new Size(Class13.np18, Class13.Gp1n);
        KDx6.SizeMode = PictureBoxSizeMode.StretchImage;
        KDx6.TabIndex = 7;
        KDx6.TabStop = false;
        LDxx.Anchor = AnchorStyles.None;
        LDxx.BackColor = Color.DarkGray;
        LDxx.BackgroundImageLayout = ImageLayout.Center;
        LDxx.Image = (Image)componentResourceManager.GetObject(Class13.Sp1Q);
        LDxx.Location = new Point(Class13.Tp1F, Class13.Cp1L);
        LDxx.Name = Class13.Fp1J;
        LDxx.Size = new Size(Class13.Pp17, Class13.rp1P);
        LDxx.SizeMode = PictureBoxSizeMode.StretchImage;
        LDxx.TabIndex = 6;
        LDxx.TabStop = false;
        UDx9.Anchor = AnchorStyles.None;
        UDx9.BackColor = Color.DarkGray;
        UDx9.BackgroundImageLayout = ImageLayout.Center;
        UDx9.Image = (Image)componentResourceManager.GetObject(Class13.gp1i);
        UDx9.Location = new Point(Class13.Fp1m, Class13.gp10);
        UDx9.Name = Class13.Yp1I;
        UDx9.Size = new Size(Class13.qp1R, Class13.Op1C);
        UDx9.SizeMode = PictureBoxSizeMode.StretchImage;
        UDx9.TabIndex = 5;
        UDx9.TabStop = false;
        DDxc.Anchor = AnchorStyles.None;
        DDxc.BackColor = Color.DarkGray;
        DDxc.BackgroundImageLayout = ImageLayout.Center;
        DDxc.Image = (Image)componentResourceManager.GetObject(Class13.Tp1K);
        DDxc.Location = new Point(Class13.fp1U, Class13.Gp1T);
        DDxc.Name = Class13.pp11;
        DDxc.Size = new Size(Class13.Ap1W, Class13.Cp1w);
        DDxc.SizeMode = PictureBoxSizeMode.StretchImage;
        DDxc.TabIndex = 4;
        DDxc.TabStop = false;
        IDxy.Anchor = AnchorStyles.None;
        IDxy.BackColor = Color.DarkGray;
        IDxy.BackgroundImageLayout = ImageLayout.Center;
        IDxy.Image = (Image)componentResourceManager.GetObject(Class13.Np1N);
        IDxy.Location = new Point(Class13.up1Y, Class13.dp1B);
        IDxy.Name = Class13.jp1A;
        IDxy.Size = new Size(Class13.qp1f, Class13.rp16);
        IDxy.SizeMode = PictureBoxSizeMode.StretchImage;
        IDxy.TabIndex = 3;
        IDxy.TabStop = false;
        DDxr.Anchor = AnchorStyles.None;
        DDxr.AutoSize = true;
        DDxr.Location = new Point(Class13.kp1x, Class13.Vp19);
        DDxr.Name = Class13.Fp1c;
        DDxr.Size = new Size(0, Class13.Np1y);
        DDxr.TabIndex = Class13.Mp1r;
        PDxq.Anchor = AnchorStyles.None;
        PDxq.AutoSize = true;
        PDxq.Location = new Point(3, 0);
        PDxq.Name = Class13.Qp1q;
        PDxq.Size = new Size(Class13.Op1k, Class13.kp1M);
        PDxq.TabIndex = Class13.Lp1u;
        GDxk.Anchor = AnchorStyles.None;
        GDxk.BackColor = Color.DarkGray;
        GDxk.BackgroundImageLayout = ImageLayout.Center;
        GDxk.Image = (Image)componentResourceManager.GetObject(Class13.pp1g);
        GDxk.Location = new Point(Class13.ap12, Class13.ap13);
        GDxk.Name = Class13.Up1d;
        GDxk.Size = new Size(Class13.Tp1H, Class13.fp14);
        GDxk.SizeMode = PictureBoxSizeMode.StretchImage;
        GDxk.TabIndex = Class13.bp15;
        GDxk.TabStop = false;
        MDxM.Anchor = AnchorStyles.None;
        MDxM.BackColor = Color.DarkGray;
        MDxM.BackgroundImageLayout = ImageLayout.Center;
        MDxM.Image = (Image)componentResourceManager.GetObject(Class13.kp1s);
        MDxM.Location = new Point(Class13.Np1Z, Class13.tp1a);
        MDxM.Name = Class13.Wp1j;
        MDxM.Size = new Size(Class13.Ip1z, Class13.wpWE);
        MDxM.SizeMode = PictureBoxSizeMode.StretchImage;
        MDxM.TabIndex = Class13.XpWD;
        MDxM.TabStop = false;
        jDxu.Anchor = AnchorStyles.None;
        jDxu.BackColor = Color.DarkGray;
        jDxu.BackgroundImageLayout = ImageLayout.Center;
        jDxu.Image = (Image)componentResourceManager.GetObject(Class13.CpWX);
        jDxu.Location = new Point(Class13.QpWp, Class13.upWS);
        jDxu.Name = Class13.YpWh;
        jDxu.Size = new Size(Class13.qpWl, Class13.dpWG);
        jDxu.SizeMode = PictureBoxSizeMode.StretchImage;
        jDxu.TabIndex = Class13.MpWb;
        jDxu.TabStop = false;
        DDxg.Anchor = AnchorStyles.None;
        DDxg.BackColor = Color.DarkGray;
        DDxg.BackgroundImageLayout = ImageLayout.Center;
        DDxg.Image = (Image)componentResourceManager.GetObject(Class13.UpWv);
        DDxg.Location = new Point(Class13.qpWo, Class13.GpWt);
        DDxg.Name = Class13.mpWV;
        DDxg.Size = new Size(Class13.upWO, Class13.apWe);
        DDxg.SizeMode = PictureBoxSizeMode.StretchImage;
        DDxg.TabIndex = Class13.ApW8;
        DDxg.TabStop = false;
        ADx2.Anchor = AnchorStyles.None;
        ADx2.AutoSize = true;
        ADx2.Location = new Point(Class13.epWn, Class13.lpWQ);
        ADx2.Name = Class13.FpWF;
        ADx2.Size = new Size(0, Class13.jpWL);
        ADx2.TabIndex = Class13.LpWJ;
        uDx3.Anchor = AnchorStyles.None;
        uDx3.AutoSize = true;
        uDx3.Location = new Point(Class13.cpW7, Class13.BpWP);
        uDx3.Name = Class13.GpWi;
        uDx3.Size = new Size(0, Class13.epWm);
        uDx3.TabIndex = Class13.bpW0;
        dDxd.Anchor = AnchorStyles.None;
        dDxd.AutoSize = true;
        dDxd.Location = new Point(Class13.bpWI, Class13.HpWR);
        dDxd.Name = Class13.wpWC;
        dDxd.Size = new Size(0, Class13.gpWK);
        dDxd.TabIndex = Class13.WpWU;
        gDxH.Anchor = AnchorStyles.None;
        gDxH.AutoSize = true;
        gDxH.Location = new Point(Class13.fpWT, 0);
        gDxH.Name = Class13.SpW1;
        gDxH.Size = new Size(Class13.KpWW, Class13.DpWw);
        gDxH.TabIndex = Class13.CpWN;
        JDx4.Anchor = AnchorStyles.None;
        JDx4.AutoSize = true;
        JDx4.Location = new Point(Class13.NpWY, 0);
        JDx4.Name = Class13.FpWB;
        JDx4.Size = new Size(Class13.cpWA, Class13.VpWf);
        JDx4.TabIndex = Class13.EpW6;
        jDx5.Anchor = AnchorStyles.None;
        jDx5.AutoSize = true;
        jDx5.Location = new Point(Class13.apWx, 0);
        jDx5.Name = Class13.GpW9;
        jDx5.Size = new Size(Class13.ipWc, Class13.FpWy);
        jDx5.TabIndex = Class13.JpWr;
        DDxs.Anchor = AnchorStyles.None;
        DDxs.AutoSize = true;
        DDxs.Location = new Point(Class13.DpWq, 0);
        DDxs.Name = Class13.dpWk;
        DDxs.Size = new Size(Class13.QpWM, Class13.cpWu);
        DDxs.TabIndex = Class13.XpWg;
        CDxZ.Anchor = AnchorStyles.None;
        CDxZ.BackColor = Color.DarkGray;
        CDxZ.BackgroundImageLayout = ImageLayout.Center;
        CDxZ.Image = (Image)componentResourceManager.GetObject(Class13.JpW2);
        CDxZ.Location = new Point(Class13.ypW3, Class13.ypWd);
        CDxZ.Name = Class13.KpWH;
        CDxZ.Size = new Size(Class13.RpW4, Class13.cpW5);
        CDxZ.SizeMode = PictureBoxSizeMode.StretchImage;
        CDxZ.TabIndex = Class13.XpWs;
        CDxZ.TabStop = false;
        BDxa.Anchor = AnchorStyles.None;
        BDxa.BackColor = Color.DarkGray;
        BDxa.BackgroundImageLayout = ImageLayout.Center;
        BDxa.Image = (Image)componentResourceManager.GetObject(Class13.jpWZ);
        BDxa.Location = new Point(Class13.xpWa, Class13.wpWj);
        BDxa.Name = Class13.mpWz;
        BDxa.Size = new Size(Class13.rpwE, Class13.UpwD);
        BDxa.SizeMode = PictureBoxSizeMode.StretchImage;
        BDxa.TabIndex = Class13.WpwX;
        BDxa.TabStop = false;
        iDxj.Anchor = AnchorStyles.None;
        iDxj.BackColor = Color.DarkGray;
        iDxj.BackgroundImageLayout = ImageLayout.Center;
        iDxj.Image = (Image)componentResourceManager.GetObject(Class13.Npwp);
        iDxj.Location = new Point(Class13.TpwS, Class13.ypwh);
        iDxj.Name = Class13.Ypwl;
        iDxj.Size = new Size(Class13.kpwG, Class13.Xpwb);
        iDxj.SizeMode = PictureBoxSizeMode.StretchImage;
        iDxj.TabIndex = Class13.Qpwv;
        iDxj.TabStop = false;
        YDxz.Anchor = AnchorStyles.None;
        YDxz.BackColor = Color.DarkGray;
        YDxz.BackgroundImageLayout = ImageLayout.Center;
        YDxz.Image = (Image)componentResourceManager.GetObject(Class13.Spwo);
        YDxz.Location = new Point(Class13.mpwt, Class13.npwV);
        YDxz.Name = Class13.CpwO;
        YDxz.Size = new Size(Class13.ypwe, Class13.zpw8);
        YDxz.SizeMode = PictureBoxSizeMode.StretchImage;
        YDxz.TabIndex = Class13.jpwn;
        YDxz.TabStop = false;
        wD9E.Anchor = AnchorStyles.None;
        wD9E.BackColor = Color.DarkGray;
        wD9E.BackgroundImageLayout = ImageLayout.Center;
        wD9E.Image = (Image)componentResourceManager.GetObject(Class13.YpwQ);
        wD9E.Location = new Point(Class13.ypwF, Class13.RpwL);
        wD9E.Name = Class13.kpwJ;
        wD9E.Size = new Size(Class13.kpw7, Class13.PpwP);
        wD9E.SizeMode = PictureBoxSizeMode.StretchImage;
        wD9E.TabIndex = Class13.ypwi;
        wD9E.TabStop = false;
        fD9D.Anchor = AnchorStyles.None;
        fD9D.BackColor = Color.DarkGray;
        fD9D.BackgroundImageLayout = ImageLayout.Center;
        fD9D.Image = (Image)componentResourceManager.GetObject(Class13.ipwm);
        fD9D.Location = new Point(Class13.epw0, Class13.vpwI);
        fD9D.Name = Class13.spwR;
        fD9D.Size = new Size(Class13.tpwC, Class13.wpwK);
        fD9D.SizeMode = PictureBoxSizeMode.StretchImage;
        fD9D.TabIndex = Class13.ypwU;
        fD9D.TabStop = false;
        uD9X.Anchor = AnchorStyles.None;
        uD9X.BackColor = Color.DarkGray;
        uD9X.BackgroundImageLayout = ImageLayout.Center;
        uD9X.Image = (Image)componentResourceManager.GetObject(Class13.npwT);
        uD9X.Location = new Point(Class13.apw1, Class13.lpwW);
        uD9X.Name = Class13.Cpww;
        uD9X.Size = new Size(Class13.PpwN, Class13.gpwY);
        uD9X.SizeMode = PictureBoxSizeMode.StretchImage;
        uD9X.TabIndex = 8;
        uD9X.TabStop = false;
        DD9p.Anchor = AnchorStyles.None;
        DD9p.BackColor = Color.DarkGray;
        DD9p.BackgroundImageLayout = ImageLayout.Center;
        DD9p.Image = (Image)componentResourceManager.GetObject(Class13.SpwB);
        DD9p.Location = new Point(Class13.epwA, Class13.apwf);
        DD9p.Name = Class13.ypw6;
        DD9p.Size = new Size(Class13.Tpwx, Class13.Wpw9);
        DD9p.SizeMode = PictureBoxSizeMode.StretchImage;
        DD9p.TabIndex = 7;
        DD9p.TabStop = false;
        RD9S.Anchor = AnchorStyles.None;
        RD9S.BackColor = Color.DarkGray;
        RD9S.BackgroundImageLayout = ImageLayout.Center;
        RD9S.Image = (Image)componentResourceManager.GetObject(Class13.Ppwc);
        RD9S.Location = new Point(Class13.npwy, Class13.tpwr);
        RD9S.Name = Class13.Gpwq;
        RD9S.Size = new Size(Class13.hpwk, Class13.apwM);
        RD9S.SizeMode = PictureBoxSizeMode.StretchImage;
        RD9S.TabIndex = 6;
        RD9S.TabStop = false;
        LD9h.Anchor = AnchorStyles.None;
        LD9h.BackColor = Color.DarkGray;
        LD9h.BackgroundImageLayout = ImageLayout.Center;
        LD9h.Image = (Image)componentResourceManager.GetObject(Class13.Ypwu);
        LD9h.Location = new Point(Class13.Xpwg, Class13.Vpw2);
        LD9h.Name = Class13.zpw3;
        LD9h.Size = new Size(Class13.mpwd, Class13.PpwH);
        LD9h.SizeMode = PictureBoxSizeMode.StretchImage;
        LD9h.TabIndex = 5;
        LD9h.TabStop = false;
        LD9l.Anchor = AnchorStyles.None;
        LD9l.BackColor = Color.DarkGray;
        LD9l.BackgroundImageLayout = ImageLayout.Center;
        LD9l.Image = (Image)componentResourceManager.GetObject(Class13.Spw4);
        LD9l.Location = new Point(Class13.apw5, Class13.Npws);
        LD9l.Name = Class13.IpwZ;
        LD9l.Size = new Size(Class13.Opwa, Class13.Opwj);
        LD9l.SizeMode = PictureBoxSizeMode.StretchImage;
        LD9l.TabIndex = 4;
        LD9l.TabStop = false;
        cD9G.Anchor = AnchorStyles.None;
        cD9G.BackColor = Color.DarkGray;
        cD9G.BackgroundImageLayout = ImageLayout.Center;
        cD9G.Image = (Image)componentResourceManager.GetObject(Class13.Hpwz);
        cD9G.Location = new Point(Class13.hpNE, Class13.hpND);
        cD9G.Name = Class13.NpNX;
        cD9G.Size = new Size(Class13.FpNp, Class13.WpNS);
        cD9G.SizeMode = PictureBoxSizeMode.StretchImage;
        cD9G.TabIndex = 3;
        cD9G.TabStop = false;
        xD9b.Location = new Point(Class13.dpNh, Class13.apNl);
        xD9b.Name = Class13.cpNG;
        xD9b.Size = new Size(Class13.mpNb, Class13.BpNv);
        xD9b.TabIndex = 1;
        xD9b.TabStop = false;
        SD9v.AutoSize = true;
        SD9v.Location = new Point(6, Class13.ypNo);
        SD9v.Name = Class13.wpNt;
        SD9v.Size = new Size(Class13.xpNV, Class13.FpNO);
        SD9v.TabIndex = 0;
        JD9o.AutoSize = true;
        JD9o.Location = new Point(6, Class13.UpNe);
        JD9o.Name = Class13.qpN8;
        JD9o.Size = new Size(Class13.GpNn, Class13.PpNQ);
        JD9o.TabIndex = 1;
        wD9t.AutoSize = true;
        wD9t.Location = new Point(6, Class13.rpNF);
        wD9t.Name = Class13.qpNL;
        wD9t.Size = new Size(Class13.opNJ, Class13.lpN7);
        wD9t.TabIndex = 6;
        GD9V.Location = new Point(Class13.KpNP, Class13.TpNi);
        GD9V.Name = Class13.ypNm;
        GD9V.Size = new Size(Class13.WpN0, Class13.cpNI);
        GD9V.TabIndex = Class13.cpNR;
        GD9V.Text = Class13.cpNC;
        GD9V.UseVisualStyleBackColor = true;
        GD9V.Click += wDKC;
        gD9O.Location = new Point(Class13.rpNK, Class13.mpNU);
        gD9O.Name = Class13.IpNT;
        gD9O.Size = new Size(Class13.bpN1, Class13.YpNW);
        gD9O.TabIndex = Class13.ipNw;
        gD9O.Text = Class13.bpNN;
        gD9O.UseVisualStyleBackColor = true;
        gD9O.Click += DDKK;
        kD9e.Location = new Point(Class13.bpNY, Class13.EpNB);
        kD9e.Name = Class13.cpNA;
        kD9e.Size = new Size(Class13.TpNf, Class13.GpN6);
        kD9e.TabIndex = 2;
        kD9e.TabStop = false;
        qD98.AutoSize = true;
        qD98.Location = new Point(6, Class13.xpNx);
        qD98.Name = Class13.NpN9;
        qD98.Size = new Size(Class13.YpNc, Class13.ApNy);
        qD98.TabIndex = 0;
        ND9n.AutoSize = true;
        ND9n.Location = new Point(6, Class13.ppNr);
        ND9n.Name = Class13.JpNq;
        ND9n.Size = new Size(Class13.ApNk, Class13.qpNM);
        ND9n.TabIndex = 1;
        CD9Q.AutoSize = true;
        CD9Q.Location = new Point(6, Class13.RpNu);
        CD9Q.Name = Class13.zpNg;
        CD9Q.Size = new Size(Class13.HpN2, Class13.PpN3);
        CD9Q.TabIndex = 2;
        KD9F.AutoSize = true;
        KD9F.Location = new Point(8, Class13.ppNd);
        KD9F.Name = Class13.FpNH;
        KD9F.Size = new Size(Class13.GpN4, Class13.tpN5);
        KD9F.TabIndex = 3;
        vD9L.Location = new Point(Class13.ppNs, Class13.opNZ);
        vD9L.Name = Class13.bpNa;
        vD9L.Size = new Size(Class13.KpNj, Class13.jpNz);
        vD9L.TabIndex = 3;
        vD9L.TabStop = false;
        lD9J.AutoSize = true;
        lD9J.Location = new Point(Class13.RpYE, Class13.bpYD);
        lD9J.Name = Class13.ApYX;
        lD9J.Size = new Size(Class13.npYp, Class13.UpYS);
        lD9J.TabIndex = 0;
        TD97.AutoSize = true;
        TD97.Location = new Point(Class13.zpYh, Class13.opYl);
        TD97.Name = Class13.ypYG;
        TD97.Size = new Size(Class13.ipYb, Class13.TpYv);
        TD97.TabIndex = 1;
        KD9P.AutoSize = true;
        KD9P.Location = new Point(Class13.mpYo, Class13.JpYt);
        KD9P.Name = Class13.LpYV;
        KD9P.Size = new Size(Class13.xpYO, Class13.NpYe);
        KD9P.TabIndex = 2;
        QD9i.AutoSize = true;
        QD9i.Location = new Point(Class13.npY8, Class13.OpYn);
        QD9i.Name = Class13.qpYQ;
        QD9i.Size = new Size(Class13.XpYF, Class13.SpYL);
        QD9i.TabIndex = 3;
        AD9m.AutoSize = true;
        AD9m.Location = new Point(Class13.ApYJ, Class13.spY7);
        AD9m.Name = Class13.fpYP;
        AD9m.Size = new Size(Class13.wpYi, Class13.mpYm);
        AD9m.TabIndex = 4;
        HD90.AutoSize = true;
        HD90.Location = new Point(Class13.fpY0, Class13.MpYI);
        HD90.Name = Class13.CpYR;
        HD90.Size = new Size(Class13.kpYC, Class13.ApYK);
        HD90.TabIndex = 5;
        hD9I.AutoSize = true;
        hD9I.Location = new Point(Class13.BpYU, Class13.QpYT);
        hD9I.Name = Class13.WpY1;
        hD9I.Size = new Size(Class13.NpYW, Class13.upYw);
        hD9I.TabIndex = 6;
        zD9R.AutoSize = true;
        zD9R.Location = new Point(Class13.KpYN, Class13.wpYY);
        zD9R.Name = Class13.qpYB;
        zD9R.Size = new Size(Class13.apYA, Class13.dpYf);
        zD9R.TabIndex = 7;
        jD9C.AutoSize = true;
        jD9C.Location = new Point(Class13.RpY6, Class13.PpYx);
        jD9C.Name = Class13.upY9;
        jD9C.Size = new Size(Class13.kpYc, Class13.opYy);
        jD9C.TabIndex = 8;
        gD9K.AutoSize = true;
        gD9K.Location = new Point(Class13.GpYr, Class13.NpYq);
        gD9K.Name = Class13.FpYk;
        gD9K.Size = new Size(Class13.wpYM, Class13.XpYu);
        gD9K.TabIndex = Class13.WpYg;
        SD9U.Location = new Point(Class13.RpY2, Class13.SpY3);
        SD9U.Name = Class13.apYd;
        SD9U.Size = new Size(Class13.DpYH, Class13.XpY4);
        SD9U.TabIndex = 4;
        SD9U.TabStop = false;
        OD9T.AutoSize = true;
        OD9T.Location = new Point(6, Class13.EpY5);
        OD9T.Name = Class13.rpYs;
        OD9T.Size = new Size(Class13.bpYZ, Class13.FpYa);
        OD9T.TabIndex = 2;
        lD91.AutoSize = true;
        lD91.Location = new Point(6, Class13.TpYj);
        lD91.Name = Class13.opYz;
        lD91.Size = new Size(Class13.SpBE, Class13.EpBD);
        lD91.TabIndex = 3;
        OD9W.AutoSize = true;
        OD9W.Location = new Point(6, Class13.RpBX);
        OD9W.Name = Class13.zpBp;
        OD9W.Size = new Size(Class13.fpBS, Class13.qpBh);
        OD9W.TabIndex = 4;
        XD9w.AutoSize = true;
        XD9w.Location = new Point(6, Class13.vpBl);
        XD9w.Name = Class13.hpBG;
        XD9w.Size = new Size(Class13.vpBb, Class13.epBv);
        XD9w.TabIndex = 5;
        gD9N.AutoSize = true;
        gD9N.Location = new Point(Class13.GpBo, Class13.wpBt);
        gD9N.Name = Class13.hpBV;
        gD9N.Size = new Size(Class13.GpBO, Class13.CpBe);
        gD9N.TabIndex = Class13.HpB8;
        JD9Y.AutoSize = true;
        JD9Y.Location = new Point(Class13.ApBn, Class13.QpBQ);
        JD9Y.Name = Class13.rpBF;
        JD9Y.Size = new Size(Class13.LpBL, Class13.npBJ);
        JD9Y.TabIndex = Class13.DpB7;
        eD9B.Anchor = AnchorStyles.None;
        eD9B.ColumnCount = 4;
        eD9B.ColumnStyles.Add(new ColumnStyle());
        eD9B.ColumnStyles.Add(new ColumnStyle());
        eD9B.ColumnStyles.Add(new ColumnStyle());
        eD9B.ColumnStyles.Add(new ColumnStyle());
        eD9B.Location = new Point(6, Class13.FpBP);
        eD9B.Name = Class13.gpBi;
        eD9B.RowCount = 8;
        eD9B.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.ApBm));
        eD9B.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.dpB0));
        eD9B.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.gpBI));
        eD9B.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.DpBR));
        eD9B.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.wpBC));
        eD9B.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.XpBK));
        eD9B.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.QpBU));
        eD9B.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.ypBT));
        eD9B.Size = new Size(Class13.OpB1, Class13.OpBW);
        eD9B.TabIndex = Class13.MpBw;
        wD9A.Anchor = AnchorStyles.None;
        wD9A.AutoSize = true;
        wD9A.Enabled = false;
        wD9A.Location = new Point(Class13.ipBN, Class13.UpBY);
        wD9A.Name = Class13.spBB;
        wD9A.Size = new Size(Class13.WpBA, Class13.XpBf);
        wD9A.TabIndex = Class13.mpB6;
        wD9A.UseVisualStyleBackColor = true;
        rD9f.Anchor = AnchorStyles.None;
        rD9f.AutoSize = true;
        rD9f.Enabled = false;
        rD9f.Location = new Point(Class13.WpBx, Class13.apB9);
        rD9f.Name = Class13.ypBc;
        rD9f.Size = new Size(Class13.CpBy, Class13.vpBr);
        rD9f.TabIndex = Class13.hpBq;
        rD9f.UseVisualStyleBackColor = true;
        dD96.Anchor = AnchorStyles.None;
        dD96.AutoSize = true;
        dD96.Enabled = false;
        dD96.Location = new Point(Class13.ipBk, Class13.bpBM);
        dD96.Name = Class13.SpBu;
        dD96.Size = new Size(Class13.dpBg, Class13.ypB2);
        dD96.TabIndex = Class13.tpB3;
        dD96.UseVisualStyleBackColor = true;
        ED9x.Anchor = AnchorStyles.None;
        ED9x.AutoSize = true;
        ED9x.Enabled = false;
        ED9x.Location = new Point(Class13.hpBd, Class13.KpBH);
        ED9x.Name = Class13.MpB4;
        ED9x.Size = new Size(Class13.HpB5, Class13.xpBs);
        ED9x.TabIndex = Class13.NpBZ;
        ED9x.UseVisualStyleBackColor = true;
        rD99.Anchor = AnchorStyles.None;
        rD99.AutoSize = true;
        rD99.Enabled = false;
        rD99.Location = new Point(Class13.kpBa, Class13.upBj);
        rD99.Name = Class13.spBz;
        rD99.Size = new Size(Class13.bpAE, Class13.FpAD);
        rD99.TabIndex = Class13.vpAX;
        rD99.UseVisualStyleBackColor = true;
        MD9c.Anchor = AnchorStyles.None;
        MD9c.AutoSize = true;
        MD9c.Enabled = false;
        MD9c.Location = new Point(Class13.xpAp, 3);
        MD9c.Name = Class13.qpAS;
        MD9c.Size = new Size(Class13.ypAh, Class13.TpAl);
        MD9c.TabIndex = Class13.qpAG;
        MD9c.UseVisualStyleBackColor = true;
        wD9y.Anchor = AnchorStyles.None;
        wD9y.AutoSize = true;
        wD9y.Enabled = false;
        wD9y.Location = new Point(Class13.rpAb, Class13.GpAv);
        wD9y.Name = Class13.OpAo;
        wD9y.Size = new Size(Class13.ipAt, Class13.TpAV);
        wD9y.TabIndex = Class13.mpAO;
        wD9y.UseVisualStyleBackColor = true;
        yD9r.Anchor = AnchorStyles.None;
        yD9r.AutoSize = true;
        yD9r.Location = new Point(Class13.DpAe, Class13.FpA8);
        yD9r.Name = Class13.kpAn;
        yD9r.Size = new Size(Class13.JpAQ, Class13.BpAF);
        yD9r.TabIndex = Class13.DpAL;
        xD9q.Anchor = AnchorStyles.None;
        xD9q.AutoSize = true;
        xD9q.Location = new Point(Class13.NpAJ, 1);
        xD9q.Name = Class13.opA7;
        xD9q.Size = new Size(Class13.SpAP, Class13.jpAi);
        xD9q.TabIndex = 2;
        YD9k.Anchor = AnchorStyles.None;
        YD9k.AutoSize = true;
        YD9k.Enabled = false;
        YD9k.Location = new Point(Class13.VpAm, Class13.ipA0);
        YD9k.Name = Class13.jpAI;
        YD9k.Size = new Size(Class13.JpAR, Class13.npAC);
        YD9k.TabIndex = Class13.JpAK;
        YD9k.UseVisualStyleBackColor = true;
        cD9M.Anchor = AnchorStyles.None;
        cD9M.AutoSize = true;
        cD9M.Location = new Point(3, Class13.XpAU);
        cD9M.Name = Class13.tpAT;
        cD9M.Size = new Size(Class13.mpA1, Class13.xpAW);
        cD9M.TabIndex = 7;
        KD9u.Anchor = AnchorStyles.None;
        KD9u.AutoSize = true;
        KD9u.Enabled = false;
        KD9u.Location = new Point(Class13.KpAw, Class13.YpAN);
        KD9u.Name = Class13.ipAY;
        KD9u.Size = new Size(Class13.npAB, Class13.GpAA);
        KD9u.TabIndex = Class13.LpAf;
        KD9u.UseVisualStyleBackColor = true;
        hD9g.Anchor = AnchorStyles.None;
        hD9g.AutoSize = true;
        hD9g.Location = new Point(Class13.kpA6, Class13.TpAx);
        hD9g.Name = Class13.OpA9;
        hD9g.Size = new Size(Class13.SpAc, Class13.MpAy);
        hD9g.TabIndex = Class13.WpAr;
        RD92.Anchor = AnchorStyles.None;
        RD92.AutoSize = true;
        RD92.Location = new Point(Class13.cpAq, Class13.jpAk);
        RD92.Name = Class13.apAM;
        RD92.Size = new Size(Class13.TpAu, Class13.SpAg);
        RD92.TabIndex = 6;
        SD93.Anchor = AnchorStyles.None;
        SD93.AutoSize = true;
        SD93.Location = new Point(Class13.FpA2, Class13.upA3);
        SD93.Name = Class13.CpAd;
        SD93.Size = new Size(Class13.SpAH, Class13.SpA4);
        SD93.TabIndex = Class13.vpA5;
        fD9d.Anchor = AnchorStyles.None;
        fD9d.AutoSize = true;
        fD9d.Location = new Point(Class13.NpAs, Class13.cpAZ);
        fD9d.Name = Class13.hpAa;
        fD9d.Size = new Size(Class13.bpAj, Class13.SpAz);
        fD9d.TabIndex = 4;
        PD9H.Anchor = AnchorStyles.None;
        PD9H.AutoSize = true;
        PD9H.Enabled = false;
        PD9H.Location = new Point(Class13.dpfE, Class13.HpfD);
        PD9H.Name = Class13.ApfX;
        PD9H.Size = new Size(Class13.fpfp, Class13.jpfS);
        PD9H.TabIndex = Class13.Mpfh;
        PD9H.UseVisualStyleBackColor = true;
        tD94.Anchor = AnchorStyles.None;
        tD94.AutoSize = true;
        tD94.Location = new Point(Class13.dpfl, Class13.vpfG);
        tD94.Name = Class13.Ppfb;
        tD94.Size = new Size(Class13.hpfv, Class13.lpfo);
        tD94.TabIndex = Class13.epft;
        CD95.Anchor = AnchorStyles.None;
        CD95.AutoSize = true;
        CD95.Location = new Point(8, Class13.IpfV);
        CD95.Name = Class13.PpfO;
        CD95.Size = new Size(Class13.Cpfe, Class13.npf8);
        CD95.TabIndex = 0;
        vD9s.Anchor = AnchorStyles.None;
        vD9s.AutoSize = true;
        vD9s.Location = new Point(Class13.Rpfn, Class13.vpfQ);
        vD9s.Name = Class13.KpfF;
        vD9s.Size = new Size(Class13.epfL, Class13.bpfJ);
        vD9s.TabIndex = Class13.rpf7;
        tD9Z.Anchor = AnchorStyles.None;
        tD9Z.AutoSize = true;
        tD9Z.Enabled = false;
        tD9Z.Location = new Point(Class13.IpfP, 3);
        tD9Z.Name = Class13.Wpfi;
        tD9Z.Size = new Size(Class13.kpfm, Class13.lpf0);
        tD9Z.TabIndex = Class13.KpfI;
        tD9Z.UseVisualStyleBackColor = true;
        PD9a.Anchor = AnchorStyles.None;
        PD9a.AutoSize = true;
        PD9a.Location = new Point(Class13.GpfR, Class13.XpfC);
        PD9a.Name = Class13.qpfK;
        PD9a.Size = new Size(Class13.VpfU, Class13.XpfT);
        PD9a.TabIndex = 8;
        DD9j.Anchor = AnchorStyles.None;
        DD9j.AutoSize = true;
        DD9j.Location = new Point(Class13.Ppf1, Class13.EpfW);
        DD9j.Name = Class13.opfw;
        DD9j.Size = new Size(Class13.qpfN, Class13.vpfY);
        DD9j.TabIndex = 1;
        BD9z.Anchor = AnchorStyles.None;
        BD9z.AutoSize = true;
        BD9z.Enabled = false;
        BD9z.Location = new Point(Class13.LpfB, Class13.fpfA);
        BD9z.Name = Class13.rpff;
        BD9z.Size = new Size(Class13.spf6, Class13.Upfx);
        BD9z.TabIndex = Class13.Wpf9;
        BD9z.UseVisualStyleBackColor = true;
        NDcE.Anchor = AnchorStyles.None;
        NDcE.AutoSize = true;
        NDcE.Location = new Point(Class13.Mpfc, Class13.Spfy);
        NDcE.Name = Class13.xpfr;
        NDcE.Size = new Size(Class13.dpfq, Class13.wpfk);
        NDcE.TabIndex = 3;
        TDcD.Anchor = AnchorStyles.None;
        TDcD.AutoSize = true;
        TDcD.Location = new Point(Class13.ipfM, Class13.Fpfu);
        TDcD.Name = Class13.Lpfg;
        TDcD.Size = new Size(Class13.Vpf2, Class13.Mpf3);
        TDcD.TabIndex = Class13.Qpfd;
        xDcX.Anchor = AnchorStyles.None;
        xDcX.AutoSize = true;
        xDcX.Location = new Point(Class13.XpfH, Class13.ppf4);
        xDcX.Name = Class13.qpf5;
        xDcX.Size = new Size(Class13.fpfs, Class13.cpfZ);
        xDcX.TabIndex = Class13.Rpfa;
        VDcp.Anchor = AnchorStyles.None;
        VDcp.AutoSize = true;
        VDcp.Location = new Point(Class13.Wpfj, 1);
        VDcp.Name = Class13.lpfz;
        VDcp.Size = new Size(Class13.Vp6E, Class13.wp6D);
        VDcp.TabIndex = 5;
        MDcS.AutoSize = true;
        MDcS.Location = new Point(Class13.bp6X, Class13.Np6p);
        MDcS.Name = Class13.ip6S;
        MDcS.Size = new Size(Class13.kp6h, Class13.xp6l);
        MDcS.TabIndex = Class13.lp6G;
        iDch.AutoSize = true;
        iDch.Location = new Point(Class13.vp6b, Class13.Rp6v);
        iDch.Name = Class13.Vp6o;
        iDch.Size = new Size(Class13.Gp6t, Class13.op6V);
        iDch.TabIndex = Class13.Gp6O;
        XDcl.Anchor = AnchorStyles.None;
        XDcl.ColumnCount = 4;
        XDcl.ColumnStyles.Add(new ColumnStyle());
        XDcl.ColumnStyles.Add(new ColumnStyle());
        XDcl.ColumnStyles.Add(new ColumnStyle());
        XDcl.ColumnStyles.Add(new ColumnStyle());
        XDcl.Location = new Point(Class13.Dp6e, Class13.Yp68);
        XDcl.Name = Class13.sp6n;
        XDcl.RowCount = 8;
        XDcl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Ap6Q));
        XDcl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.yp6F));
        XDcl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.ep6L));
        XDcl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Np6J));
        XDcl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Ip67));
        XDcl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Jp6P));
        XDcl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Kp6i));
        XDcl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Dp6m));
        XDcl.Size = new Size(Class13.bp60, Class13.Xp6I);
        XDcl.TabIndex = Class13.Xp6R;
        dDcG.Anchor = AnchorStyles.None;
        dDcG.AutoSize = true;
        dDcG.Enabled = false;
        dDcG.Location = new Point(Class13.kp6C, Class13.ip6K);
        dDcG.Name = Class13.dp6U;
        dDcG.Size = new Size(Class13.Xp6T, Class13.Tp61);
        dDcG.TabIndex = Class13.mp6W;
        dDcG.UseVisualStyleBackColor = true;
        yDcb.Anchor = AnchorStyles.None;
        yDcb.AutoSize = true;
        yDcb.Enabled = false;
        yDcb.Location = new Point(Class13.Qp6w, Class13.Lp6N);
        yDcb.Name = Class13.Ip6Y;
        yDcb.Size = new Size(Class13.pp6B, Class13.Up6A);
        yDcb.TabIndex = Class13.yp6f;
        yDcb.UseVisualStyleBackColor = true;
        cDcv.Anchor = AnchorStyles.None;
        cDcv.AutoSize = true;
        cDcv.Enabled = false;
        cDcv.Location = new Point(Class13.dp66, Class13.Qp6x);
        cDcv.Name = Class13.up69;
        cDcv.Size = new Size(Class13.lp6c, Class13.dp6y);
        cDcv.TabIndex = Class13.Cp6r;
        cDcv.UseVisualStyleBackColor = true;
        jDco.Anchor = AnchorStyles.None;
        jDco.AutoSize = true;
        jDco.Enabled = false;
        jDco.Location = new Point(Class13.jp6q, Class13.Kp6k);
        jDco.Name = Class13.Kp6M;
        jDco.Size = new Size(Class13.yp6u, Class13.xp6g);
        jDco.TabIndex = Class13.dp62;
        jDco.UseVisualStyleBackColor = true;
        sDct.Anchor = AnchorStyles.None;
        sDct.AutoSize = true;
        sDct.Enabled = false;
        sDct.Location = new Point(Class13.Cp63, Class13.tp6d);
        sDct.Name = Class13.ap6H;
        sDct.Size = new Size(Class13.lp64, Class13.jp65);
        sDct.TabIndex = Class13.bp6s;
        sDct.UseVisualStyleBackColor = true;
        vDcV.Anchor = AnchorStyles.None;
        vDcV.AutoSize = true;
        vDcV.Enabled = false;
        vDcV.Location = new Point(Class13.Dp6Z, 3);
        vDcV.Name = Class13.np6a;
        vDcV.Size = new Size(Class13.Gp6j, Class13.Fp6z);
        vDcV.TabIndex = Class13.ipxE;
        vDcV.UseVisualStyleBackColor = true;
        IDcO.Anchor = AnchorStyles.None;
        IDcO.AutoSize = true;
        IDcO.Enabled = false;
        IDcO.Location = new Point(Class13.UpxD, Class13.tpxX);
        IDcO.Name = Class13.epxp;
        IDcO.Size = new Size(Class13.GpxS, Class13.vpxh);
        IDcO.TabIndex = Class13.spxl;
        IDcO.UseVisualStyleBackColor = true;
        JDce.Anchor = AnchorStyles.None;
        JDce.AutoSize = true;
        JDce.Location = new Point(Class13.EpxG, Class13.Apxb);
        JDce.Name = Class13.ppxv;
        JDce.Size = new Size(Class13.rpxo, Class13.Opxt);
        JDce.TabIndex = Class13.bpxV;
        UDc8.Anchor = AnchorStyles.None;
        UDc8.AutoSize = true;
        UDc8.Location = new Point(Class13.XpxO, 1);
        UDc8.Name = Class13.Fpxe;
        UDc8.Size = new Size(Class13.Fpx8, Class13.Fpxn);
        UDc8.TabIndex = 2;
        aDcn.Anchor = AnchorStyles.None;
        aDcn.AutoSize = true;
        aDcn.Enabled = false;
        aDcn.Location = new Point(Class13.apxQ, Class13.CpxF);
        aDcn.Name = Class13.VpxL;
        aDcn.Size = new Size(Class13.tpxJ, Class13.Tpx7);
        aDcn.TabIndex = Class13.gpxP;
        aDcn.UseVisualStyleBackColor = true;
        bDcQ.Anchor = AnchorStyles.None;
        bDcQ.AutoSize = true;
        bDcQ.Location = new Point(3, Class13.bpxi);
        bDcQ.Name = Class13.apxm;
        bDcQ.Size = new Size(Class13.Epx0, Class13.epxI);
        bDcQ.TabIndex = 7;
        ADcF.Anchor = AnchorStyles.None;
        ADcF.AutoSize = true;
        ADcF.Enabled = false;
        ADcF.Location = new Point(Class13.IpxR, Class13.apxC);
        ADcF.Name = Class13.hpxK;
        ADcF.Size = new Size(Class13.vpxU, Class13.ApxT);
        ADcF.TabIndex = Class13.Opx1;
        ADcF.UseVisualStyleBackColor = true;
        mDcL.Anchor = AnchorStyles.None;
        mDcL.AutoSize = true;
        mDcL.Location = new Point(Class13.wpxW, Class13.xpxw);
        mDcL.Name = Class13.dpxN;
        mDcL.Size = new Size(Class13.qpxY, Class13.QpxB);
        mDcL.TabIndex = Class13.fpxA;
        nDcJ.Anchor = AnchorStyles.None;
        nDcJ.AutoSize = true;
        nDcJ.Location = new Point(Class13.Ipxf, Class13.cpx6);
        nDcJ.Name = Class13.Dpxx;
        nDcJ.Size = new Size(Class13.hpx9, Class13.Epxc);
        nDcJ.TabIndex = 6;
        GDc7.Anchor = AnchorStyles.None;
        GDc7.AutoSize = true;
        GDc7.Location = new Point(Class13.apxy, Class13.Epxr);
        GDc7.Name = Class13.Mpxq;
        GDc7.Size = new Size(Class13.dpxk, Class13.WpxM);
        GDc7.TabIndex = Class13.Tpxu;
        QDcP.Anchor = AnchorStyles.None;
        QDcP.AutoSize = true;
        QDcP.Location = new Point(Class13.rpxg, Class13.Opx2);
        QDcP.Name = Class13.dpx3;
        QDcP.Size = new Size(Class13.hpxd, Class13.fpxH);
        QDcP.TabIndex = 4;
        WDci.Anchor = AnchorStyles.None;
        WDci.AutoSize = true;
        WDci.Enabled = false;
        WDci.Location = new Point(Class13.dpx4, Class13.apx5);
        WDci.Name = Class13.rpxs;
        WDci.Size = new Size(Class13.zpxZ, Class13.epxa);
        WDci.TabIndex = Class13.hpxj;
        WDci.UseVisualStyleBackColor = true;
        qDcm.Anchor = AnchorStyles.None;
        qDcm.AutoSize = true;
        qDcm.Location = new Point(Class13.Npxz, Class13.Tp9E);
        qDcm.Name = Class13.np9D;
        qDcm.Size = new Size(Class13.kp9X, Class13.Ep9p);
        qDcm.TabIndex = Class13.dp9S;
        BDc0.Anchor = AnchorStyles.None;
        BDc0.AutoSize = true;
        BDc0.Location = new Point(8, Class13.Ip9h);
        BDc0.Name = Class13.Vp9l;
        BDc0.Size = new Size(Class13.yp9G, Class13.hp9b);
        BDc0.TabIndex = 0;
        sDcI.Anchor = AnchorStyles.None;
        sDcI.AutoSize = true;
        sDcI.Location = new Point(Class13.Yp9v, Class13.Vp9o);
        sDcI.Name = Class13.up9t;
        sDcI.Size = new Size(Class13.Qp9V, Class13.Hp9O);
        sDcI.TabIndex = Class13.Wp9e;
        lDcR.Anchor = AnchorStyles.None;
        lDcR.AutoSize = true;
        lDcR.Enabled = false;
        lDcR.Location = new Point(Class13.ap98, 3);
        lDcR.Name = Class13.ap9n;
        lDcR.Size = new Size(Class13.Kp9Q, Class13.dp9F);
        lDcR.TabIndex = Class13.Ap9L;
        lDcR.UseVisualStyleBackColor = true;
        gDcC.Anchor = AnchorStyles.None;
        gDcC.AutoSize = true;
        gDcC.Location = new Point(Class13.hp9J, Class13.Xp97);
        gDcC.Name = Class13.Ep9P;
        gDcC.Size = new Size(Class13.ap9i, Class13.Ip9m);
        gDcC.TabIndex = 8;
        WDcK.Anchor = AnchorStyles.None;
        WDcK.AutoSize = true;
        WDcK.Location = new Point(Class13.op90, Class13.Op9I);
        WDcK.Name = Class13.Ep9R;
        WDcK.Size = new Size(Class13.up9C, Class13.rp9K);
        WDcK.TabIndex = 1;
        RDcU.Anchor = AnchorStyles.None;
        RDcU.AutoSize = true;
        RDcU.Enabled = false;
        RDcU.Location = new Point(Class13.Gp9U, Class13.ap9T);
        RDcU.Name = Class13.lp91;
        RDcU.Size = new Size(Class13.Tp9W, Class13.Cp9w);
        RDcU.TabIndex = Class13.Pp9N;
        RDcU.UseVisualStyleBackColor = true;
        vDcT.Anchor = AnchorStyles.None;
        vDcT.AutoSize = true;
        vDcT.Location = new Point(Class13.Dp9Y, Class13.Qp9B);
        vDcT.Name = Class13.dp9A;
        vDcT.Size = new Size(Class13.Op9f, Class13.Xp96);
        vDcT.TabIndex = 3;
        WDc1.Anchor = AnchorStyles.None;
        WDc1.AutoSize = true;
        WDc1.Location = new Point(Class13.Tp9x, Class13.op99);
        WDc1.Name = Class13.wp9c;
        WDc1.Size = new Size(Class13.Np9y, Class13.sp9r);
        WDc1.TabIndex = Class13.Fp9q;
        ODcW.Anchor = AnchorStyles.None;
        ODcW.AutoSize = true;
        ODcW.Location = new Point(Class13.lp9k, Class13.zp9M);
        ODcW.Name = Class13.Ap9u;
        ODcW.Size = new Size(Class13.Pp9g, Class13.pp92);
        ODcW.TabIndex = Class13.Rp93;
        PDcw.Anchor = AnchorStyles.None;
        PDcw.AutoSize = true;
        PDcw.Location = new Point(Class13.Op9d, 1);
        PDcw.Name = Class13.jp9H;
        PDcw.Size = new Size(Class13.qp94, Class13.op95);
        PDcw.TabIndex = 5;
        yDcN.AutoSize = true;
        yDcN.Location = new Point(Class13.pp9s, Class13.gp9Z);
        yDcN.Name = Class13.Np9a;
        yDcN.Size = new Size(Class13.pp9j, Class13.vp9z);
        yDcN.TabIndex = Class13.vpcE;
        cDcY.AutoSize = true;
        cDcY.Location = new Point(Class13.xpcD, Class13.QpcX);
        cDcY.Name = Class13.Ypcp;
        cDcY.Size = new Size(Class13.HpcS, Class13.Opch);
        cDcY.TabIndex = Class13.Wpcl;
        BDcB.Anchor = AnchorStyles.None;
        BDcB.ColumnCount = 4;
        BDcB.ColumnStyles.Add(new ColumnStyle());
        BDcB.ColumnStyles.Add(new ColumnStyle());
        BDcB.ColumnStyles.Add(new ColumnStyle());
        BDcB.ColumnStyles.Add(new ColumnStyle());
        BDcB.Location = new Point(6, Class13.npcG);
        BDcB.Name = Class13.Fpcb;
        BDcB.RowCount = 8;
        BDcB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Hpcv));
        BDcB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Upco));
        BDcB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.dpct));
        BDcB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.gpcV));
        BDcB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.GpcO));
        BDcB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.opce));
        BDcB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Opc8));
        BDcB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Opcn));
        BDcB.Size = new Size(Class13.JpcQ, Class13.tpcF);
        BDcB.TabIndex = Class13.ppcL;
        SDcA.Anchor = AnchorStyles.None;
        SDcA.AutoSize = true;
        SDcA.Enabled = false;
        SDcA.Location = new Point(Class13.jpcJ, Class13.Fpc7);
        SDcA.Name = Class13.DpcP;
        SDcA.Size = new Size(Class13.hpci, Class13.kpcm);
        SDcA.TabIndex = Class13.upc0;
        SDcA.UseVisualStyleBackColor = true;
        iDcf.Anchor = AnchorStyles.None;
        iDcf.AutoSize = true;
        iDcf.Enabled = false;
        iDcf.Location = new Point(Class13.KpcI, Class13.ApcR);
        iDcf.Name = Class13.ppcC;
        iDcf.Size = new Size(Class13.XpcK, Class13.NpcU);
        iDcf.TabIndex = Class13.IpcT;
        iDcf.UseVisualStyleBackColor = true;
        HDc6.Anchor = AnchorStyles.None;
        HDc6.AutoSize = true;
        HDc6.Enabled = false;
        HDc6.Location = new Point(Class13.vpc1, Class13.hpcW);
        HDc6.Name = Class13.Ypcw;
        HDc6.Size = new Size(Class13.kpcN, Class13.apcY);
        HDc6.TabIndex = Class13.ypcB;
        HDc6.UseVisualStyleBackColor = true;
        gDcx.Anchor = AnchorStyles.None;
        gDcx.AutoSize = true;
        gDcx.Enabled = false;
        gDcx.Location = new Point(Class13.SpcA, Class13.jpcf);
        gDcx.Name = Class13.Upc6;
        gDcx.Size = new Size(Class13.Npcx, Class13.spc9);
        gDcx.TabIndex = Class13.Apcc;
        gDcx.UseVisualStyleBackColor = true;
        TDc9.Anchor = AnchorStyles.None;
        TDc9.AutoSize = true;
        TDc9.Enabled = false;
        TDc9.Location = new Point(Class13.ipcy, Class13.ppcr);
        TDc9.Name = Class13.Gpcq;
        TDc9.Size = new Size(Class13.qpck, Class13.XpcM);
        TDc9.TabIndex = Class13.vpcu;
        TDc9.UseVisualStyleBackColor = true;
        RDcc.Anchor = AnchorStyles.None;
        RDcc.AutoSize = true;
        RDcc.Enabled = false;
        RDcc.Location = new Point(Class13.Epcg, 3);
        RDcc.Name = Class13.npc2;
        RDcc.Size = new Size(Class13.npc3, Class13.Ppcd);
        RDcc.TabIndex = Class13.cpcH;
        RDcc.UseVisualStyleBackColor = true;
        YDcy.Anchor = AnchorStyles.None;
        YDcy.AutoSize = true;
        YDcy.Enabled = false;
        YDcy.Location = new Point(Class13.vpc4, Class13.Xpc5);
        YDcy.Name = Class13.lpcs;
        YDcy.Size = new Size(Class13.VpcZ, Class13.apca);
        YDcy.TabIndex = Class13.Tpcj;
        YDcy.UseVisualStyleBackColor = true;
        zDcr.Anchor = AnchorStyles.None;
        zDcr.AutoSize = true;
        zDcr.Location = new Point(Class13.Bpcz, Class13.fpyE);
        zDcr.Name = Class13.apyD;
        zDcr.Size = new Size(Class13.apyX, Class13.Dpyp);
        zDcr.TabIndex = Class13.wpyS;
        zDcq.Anchor = AnchorStyles.None;
        zDcq.AutoSize = true;
        zDcq.Location = new Point(Class13.fpyh, 1);
        zDcq.Name = Class13.Hpyl;
        zDcq.Size = new Size(Class13.UpyG, Class13.Tpyb);
        zDcq.TabIndex = 2;
        zDck.Anchor = AnchorStyles.None;
        zDck.AutoSize = true;
        zDck.Enabled = false;
        zDck.Location = new Point(Class13.jpyv, Class13.lpyo);
        zDck.Name = Class13.opyt;
        zDck.Size = new Size(Class13.UpyV, Class13.WpyO);
        zDck.TabIndex = Class13.epye;
        zDck.UseVisualStyleBackColor = true;
        EDcM.Anchor = AnchorStyles.None;
        EDcM.AutoSize = true;
        EDcM.Location = new Point(3, Class13.Gpy8);
        EDcM.Name = Class13.wpyn;
        EDcM.Size = new Size(Class13.DpyQ, Class13.hpyF);
        EDcM.TabIndex = 7;
        cDcu.Anchor = AnchorStyles.None;
        cDcu.AutoSize = true;
        cDcu.Enabled = false;
        cDcu.Location = new Point(Class13.GpyL, Class13.OpyJ);
        cDcu.Name = Class13.qpy7;
        cDcu.Size = new Size(Class13.RpyP, Class13.hpyi);
        cDcu.TabIndex = Class13.jpym;
        cDcu.UseVisualStyleBackColor = true;
        sDcg.Anchor = AnchorStyles.None;
        sDcg.AutoSize = true;
        sDcg.Location = new Point(Class13.Jpy0, Class13.rpyI);
        sDcg.Name = Class13.EpyR;
        sDcg.Size = new Size(Class13.lpyC, Class13.UpyK);
        sDcg.TabIndex = Class13.CpyU;
        XDc2.Anchor = AnchorStyles.None;
        XDc2.AutoSize = true;
        XDc2.Location = new Point(Class13.fpyT, Class13.opy1);
        XDc2.Name = Class13.apyW;
        XDc2.Size = new Size(Class13.Bpyw, Class13.HpyN);
        XDc2.TabIndex = 6;
        KDc3.Anchor = AnchorStyles.None;
        KDc3.AutoSize = true;
        KDc3.Location = new Point(Class13.ypyY, Class13.FpyB);
        KDc3.Name = Class13.BpyA;
        KDc3.Size = new Size(Class13.ypyf, Class13.Hpy6);
        KDc3.TabIndex = Class13.dpyx;
        fDcd.Anchor = AnchorStyles.None;
        fDcd.AutoSize = true;
        fDcd.Location = new Point(Class13.ipy9, Class13.Cpyc);
        fDcd.Name = Class13.Qpyy;
        fDcd.Size = new Size(Class13.Apyr, Class13.ipyq);
        fDcd.TabIndex = 4;
        CDcH.Anchor = AnchorStyles.None;
        CDcH.AutoSize = true;
        CDcH.Enabled = false;
        CDcH.Location = new Point(Class13.Dpyk, Class13.PpyM);
        CDcH.Name = Class13.Apyu;
        CDcH.Size = new Size(Class13.mpyg, Class13.wpy2);
        CDcH.TabIndex = Class13.Apy3;
        CDcH.UseVisualStyleBackColor = true;
        WDc4.Anchor = AnchorStyles.None;
        WDc4.AutoSize = true;
        WDc4.Location = new Point(Class13.Mpyd, Class13.hpyH);
        WDc4.Name = Class13.dpy4;
        WDc4.Size = new Size(Class13.zpy5, Class13.tpys);
        WDc4.TabIndex = Class13.NpyZ;
        mDc5.Anchor = AnchorStyles.None;
        mDc5.AutoSize = true;
        mDc5.Location = new Point(8, Class13.apya);
        mDc5.Name = Class13.jpyj;
        mDc5.Size = new Size(Class13.ipyz, Class13.vprE);
        mDc5.TabIndex = 0;
        sDcs.Anchor = AnchorStyles.None;
        sDcs.AutoSize = true;
        sDcs.Location = new Point(Class13.wprD, Class13.oprX);
        sDcs.Name = Class13.uprp;
        sDcs.Size = new Size(Class13.wprS, Class13.Pprh);
        sDcs.TabIndex = Class13.wprl;
        bDcZ.Anchor = AnchorStyles.None;
        bDcZ.AutoSize = true;
        bDcZ.Enabled = false;
        bDcZ.Location = new Point(Class13.cprG, 3);
        bDcZ.Name = Class13.xprb;
        bDcZ.Size = new Size(Class13.rprv, Class13.Vpro);
        bDcZ.TabIndex = Class13.Qprt;
        bDcZ.UseVisualStyleBackColor = true;
        qDca.Anchor = AnchorStyles.None;
        qDca.AutoSize = true;
        qDca.Location = new Point(Class13.EprV, Class13.BprO);
        qDca.Name = Class13.fpre;
        qDca.Size = new Size(Class13.qpr8, Class13.Tprn);
        qDca.TabIndex = 8;
        WDcj.Anchor = AnchorStyles.None;
        WDcj.AutoSize = true;
        WDcj.Location = new Point(Class13.DprQ, Class13.HprF);
        WDcj.Name = Class13.nprL;
        WDcj.Size = new Size(Class13.kprJ, Class13.opr7);
        WDcj.TabIndex = 1;
        jDcz.Anchor = AnchorStyles.None;
        jDcz.AutoSize = true;
        jDcz.Enabled = false;
        jDcz.Location = new Point(Class13.FprP, Class13.Xpri);
        jDcz.Name = Class13.Pprm;
        jDcz.Size = new Size(Class13.dpr0, Class13.hprI);
        jDcz.TabIndex = Class13.KprR;
        jDcz.UseVisualStyleBackColor = true;
        WDyE.Anchor = AnchorStyles.None;
        WDyE.AutoSize = true;
        WDyE.Location = new Point(Class13.NprC, Class13.LprK);
        WDyE.Name = Class13.XprU;
        WDyE.Size = new Size(Class13.rprT, Class13.hpr1);
        WDyE.TabIndex = 3;
        YDyD.Anchor = AnchorStyles.None;
        YDyD.AutoSize = true;
        YDyD.Location = new Point(Class13.lprW, Class13.Sprw);
        YDyD.Name = Class13.PprN;
        YDyD.Size = new Size(Class13.dprY, Class13.tprB);
        YDyD.TabIndex = Class13.MprA;
        QDyX.Anchor = AnchorStyles.None;
        QDyX.AutoSize = true;
        QDyX.Location = new Point(Class13.Nprf, Class13.Epr6);
        QDyX.Name = Class13.Uprx;
        QDyX.Size = new Size(Class13.zpr9, Class13.Lprc);
        QDyX.TabIndex = Class13.vpry;
        PDyp.Anchor = AnchorStyles.None;
        PDyp.AutoSize = true;
        PDyp.Location = new Point(Class13.hprr, 1);
        PDyp.Name = Class13.Xprq;
        PDyp.Size = new Size(Class13.oprk, Class13.CprM);
        PDyp.TabIndex = 5;
        LDyS.AutoSize = true;
        LDyS.Location = new Point(Class13.Bpru, Class13.rprg);
        LDyS.Name = Class13.Vpr2;
        LDyS.Size = new Size(Class13.Apr3, Class13.Pprd);
        LDyS.TabIndex = Class13.iprH;
        WDyh.AutoSize = true;
        WDyh.Location = new Point(Class13.Lpr4, Class13.Tpr5);
        WDyh.Name = Class13.gprs;
        WDyh.Size = new Size(Class13.pprZ, Class13.Tpra);
        WDyh.TabIndex = Class13.kprj;
        PDyl.Anchor = AnchorStyles.None;
        PDyl.ColumnCount = 4;
        PDyl.ColumnStyles.Add(new ColumnStyle());
        PDyl.ColumnStyles.Add(new ColumnStyle());
        PDyl.ColumnStyles.Add(new ColumnStyle());
        PDyl.ColumnStyles.Add(new ColumnStyle());
        PDyl.Location = new Point(6, Class13.Aprz);
        PDyl.Name = Class13.XpqE;
        PDyl.RowCount = 8;
        PDyl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.WpqD));
        PDyl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.mpqX));
        PDyl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Opqp));
        PDyl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.VpqS));
        PDyl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Apqh));
        PDyl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Cpql));
        PDyl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.QpqG));
        PDyl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.bpqb));
        PDyl.Size = new Size(Class13.Npqv, Class13.Jpqo);
        PDyl.TabIndex = Class13.vpqt;
        bDyG.Anchor = AnchorStyles.None;
        bDyG.AutoSize = true;
        bDyG.Enabled = false;
        bDyG.Location = new Point(Class13.FpqV, Class13.qpqO);
        bDyG.Name = Class13.Dpqe;
        bDyG.Size = new Size(Class13.epq8, Class13.Ppqn);
        bDyG.TabIndex = Class13.UpqQ;
        bDyG.UseVisualStyleBackColor = true;
        sDyb.Anchor = AnchorStyles.None;
        sDyb.AutoSize = true;
        sDyb.Enabled = false;
        sDyb.Location = new Point(Class13.PpqF, Class13.fpqL);
        sDyb.Name = Class13.zpqJ;
        sDyb.Size = new Size(Class13.Apq7, Class13.apqP);
        sDyb.TabIndex = Class13.Opqi;
        sDyb.UseVisualStyleBackColor = true;
        XDyv.Anchor = AnchorStyles.None;
        XDyv.AutoSize = true;
        XDyv.Enabled = false;
        XDyv.Location = new Point(Class13.qpqm, Class13.Kpq0);
        XDyv.Name = Class13.fpqI;
        XDyv.Size = new Size(Class13.vpqR, Class13.TpqC);
        XDyv.TabIndex = Class13.HpqK;
        XDyv.UseVisualStyleBackColor = true;
        ODyo.Anchor = AnchorStyles.None;
        ODyo.AutoSize = true;
        ODyo.Enabled = false;
        ODyo.Location = new Point(Class13.mpqU, Class13.RpqT);
        ODyo.Name = Class13.Rpq1;
        ODyo.Size = new Size(Class13.IpqW, Class13.Gpqw);
        ODyo.TabIndex = Class13.dpqN;
        ODyo.UseVisualStyleBackColor = true;
        EDyt.Anchor = AnchorStyles.None;
        EDyt.AutoSize = true;
        EDyt.Enabled = false;
        EDyt.Location = new Point(Class13.epqY, Class13.MpqB);
        EDyt.Name = Class13.apqA;
        EDyt.Size = new Size(Class13.Upqf, Class13.Kpq6);
        EDyt.TabIndex = Class13.tpqx;
        EDyt.UseVisualStyleBackColor = true;
        eDyV.Anchor = AnchorStyles.None;
        eDyV.AutoSize = true;
        eDyV.Enabled = false;
        eDyV.Location = new Point(Class13.upq9, 3);
        eDyV.Name = Class13.wpqc;
        eDyV.Size = new Size(Class13.Jpqy, Class13.bpqr);
        eDyV.TabIndex = Class13.dpqq;
        eDyV.UseVisualStyleBackColor = true;
        JDyO.Anchor = AnchorStyles.None;
        JDyO.AutoSize = true;
        JDyO.Enabled = false;
        JDyO.Location = new Point(Class13.Spqk, Class13.QpqM);
        JDyO.Name = Class13.Opqu;
        JDyO.Size = new Size(Class13.Ypqg, Class13.jpq2);
        JDyO.TabIndex = Class13.Ipq3;
        JDyO.UseVisualStyleBackColor = true;
        DDye.Anchor = AnchorStyles.None;
        DDye.AutoSize = true;
        DDye.Location = new Point(Class13.cpqd, Class13.ApqH);
        DDye.Name = Class13.tpq4;
        DDye.Size = new Size(Class13.Dpq5, Class13.apqs);
        DDye.TabIndex = Class13.PpqZ;
        WDy8.Anchor = AnchorStyles.None;
        WDy8.AutoSize = true;
        WDy8.Location = new Point(Class13.lpqa, 1);
        WDy8.Name = Class13.Cpqj;
        WDy8.Size = new Size(Class13.Fpqz, Class13.VpkE);
        WDy8.TabIndex = 2;
        BDyn.Anchor = AnchorStyles.None;
        BDyn.AutoSize = true;
        BDyn.Enabled = false;
        BDyn.Location = new Point(Class13.epkD, Class13.jpkX);
        BDyn.Name = Class13.qpkp;
        BDyn.Size = new Size(Class13.MpkS, Class13.zpkh);
        BDyn.TabIndex = Class13.Bpkl;
        BDyn.UseVisualStyleBackColor = true;
        LDyQ.Anchor = AnchorStyles.None;
        LDyQ.AutoSize = true;
        LDyQ.Location = new Point(3, Class13.tpkG);
        LDyQ.Name = Class13.kpkb;
        LDyQ.Size = new Size(Class13.npkv, Class13.ppko);
        LDyQ.TabIndex = 7;
        UDyF.Anchor = AnchorStyles.None;
        UDyF.AutoSize = true;
        UDyF.Enabled = false;
        UDyF.Location = new Point(Class13.Vpkt, Class13.xpkV);
        UDyF.Name = Class13.GpkO;
        UDyF.Size = new Size(Class13.Lpke, Class13.opk8);
        UDyF.TabIndex = Class13.Bpkn;
        UDyF.UseVisualStyleBackColor = true;
        qDyL.Anchor = AnchorStyles.None;
        qDyL.AutoSize = true;
        qDyL.Location = new Point(Class13.XpkQ, Class13.fpkF);
        qDyL.Name = Class13.QpkL;
        qDyL.Size = new Size(Class13.ppkJ, Class13.ppk7);
        qDyL.TabIndex = Class13.OpkP;
        fDyJ.Anchor = AnchorStyles.None;
        fDyJ.AutoSize = true;
        fDyJ.Location = new Point(Class13.Epki, Class13.wpkm);
        fDyJ.Name = Class13.Qpk0;
        fDyJ.Size = new Size(Class13.LpkI, Class13.jpkR);
        fDyJ.TabIndex = 6;
        MDy7.Anchor = AnchorStyles.None;
        MDy7.AutoSize = true;
        MDy7.Location = new Point(Class13.VpkC, Class13.zpkK);
        MDy7.Name = Class13.JpkU;
        MDy7.Size = new Size(Class13.PpkT, Class13.rpk1);
        MDy7.TabIndex = Class13.spkW;
        NDyP.Anchor = AnchorStyles.None;
        NDyP.AutoSize = true;
        NDyP.Location = new Point(Class13.Xpkw, Class13.SpkN);
        NDyP.Name = Class13.wpkY;
        NDyP.Size = new Size(Class13.zpkB, Class13.CpkA);
        NDyP.TabIndex = 4;
        KDyi.Anchor = AnchorStyles.None;
        KDyi.AutoSize = true;
        KDyi.Enabled = false;
        KDyi.Location = new Point(Class13.upkf, Class13.Fpk6);
        KDyi.Name = Class13.Tpkx;
        KDyi.Size = new Size(Class13.Xpk9, Class13.Ypkc);
        KDyi.TabIndex = Class13.lpky;
        KDyi.UseVisualStyleBackColor = true;
        iDym.Anchor = AnchorStyles.None;
        iDym.AutoSize = true;
        iDym.Location = new Point(Class13.Kpkr, Class13.Kpkq);
        iDym.Name = Class13.Ppkk;
        iDym.Size = new Size(Class13.apkM, Class13.ypku);
        iDym.TabIndex = Class13.Opkg;
        jDy0.Anchor = AnchorStyles.None;
        jDy0.AutoSize = true;
        jDy0.Location = new Point(8, Class13.Wpk2);
        jDy0.Name = Class13.Fpk3;
        jDy0.Size = new Size(Class13.Wpkd, Class13.BpkH);
        jDy0.TabIndex = 0;
        MDyI.Anchor = AnchorStyles.None;
        MDyI.AutoSize = true;
        MDyI.Location = new Point(Class13.epk4, Class13.Lpk5);
        MDyI.Name = Class13.Qpks;
        MDyI.Size = new Size(Class13.zpkZ, Class13.dpka);
        MDyI.TabIndex = Class13.wpkj;
        NDyR.Anchor = AnchorStyles.None;
        NDyR.AutoSize = true;
        NDyR.Enabled = false;
        NDyR.Location = new Point(Class13.gpkz, 3);
        NDyR.Name = Class13.OpME;
        NDyR.Size = new Size(Class13.cpMD, Class13.MpMX);
        NDyR.TabIndex = Class13.qpMp;
        NDyR.UseVisualStyleBackColor = true;
        QDyC.Anchor = AnchorStyles.None;
        QDyC.AutoSize = true;
        QDyC.Location = new Point(Class13.BpMS, Class13.RpMh);
        QDyC.Name = Class13.GpMl;
        QDyC.Size = new Size(Class13.xpMG, Class13.EpMb);
        QDyC.TabIndex = 8;
        vDyK.Anchor = AnchorStyles.None;
        vDyK.AutoSize = true;
        vDyK.Location = new Point(Class13.xpMv, Class13.HpMo);
        vDyK.Name = Class13.UpMt;
        vDyK.Size = new Size(Class13.apMV, Class13.DpMO);
        vDyK.TabIndex = 1;
        ODyU.Anchor = AnchorStyles.None;
        ODyU.AutoSize = true;
        ODyU.Enabled = false;
        ODyU.Location = new Point(Class13.PpMe, Class13.ppM8);
        ODyU.Name = Class13.DpMn;
        ODyU.Size = new Size(Class13.KpMQ, Class13.kpMF);
        ODyU.TabIndex = Class13.EpML;
        ODyU.UseVisualStyleBackColor = true;
        xDyT.Anchor = AnchorStyles.None;
        xDyT.AutoSize = true;
        xDyT.Location = new Point(Class13.RpMJ, Class13.RpM7);
        xDyT.Name = Class13.bpMP;
        xDyT.Size = new Size(Class13.ppMi, Class13.LpMm);
        xDyT.TabIndex = 3;
        aDy1.Anchor = AnchorStyles.None;
        aDy1.AutoSize = true;
        aDy1.Location = new Point(Class13.bpM0, Class13.vpMI);
        aDy1.Name = Class13.dpMR;
        aDy1.Size = new Size(Class13.opMC, Class13.dpMK);
        aDy1.TabIndex = Class13.FpMU;
        BDyW.Anchor = AnchorStyles.None;
        BDyW.AutoSize = true;
        BDyW.Location = new Point(Class13.UpMT, Class13.KpM1);
        BDyW.Name = Class13.gpMW;
        BDyW.Size = new Size(Class13.KpMw, Class13.cpMN);
        BDyW.TabIndex = Class13.DpMY;
        IDyw.Anchor = AnchorStyles.None;
        IDyw.AutoSize = true;
        IDyw.Location = new Point(Class13.BpMB, 1);
        IDyw.Name = Class13.mpMA;
        IDyw.Size = new Size(Class13.tpMf, Class13.XpM6);
        IDyw.TabIndex = 5;
        NDyN.AutoSize = true;
        NDyN.Location = new Point(Class13.JpMx, Class13.xpM9);
        NDyN.Name = Class13.KpMc;
        NDyN.Size = new Size(Class13.zpMy, Class13.wpMr);
        NDyN.TabIndex = Class13.npMq;
        uDyY.AutoSize = true;
        uDyY.Location = new Point(Class13.IpMk, Class13.xpMM);
        uDyY.Name = Class13.cpMu;
        uDyY.Size = new Size(Class13.ipMg, Class13.ApM2);
        uDyY.TabIndex = Class13.hpM3;
        PDyB.Anchor = AnchorStyles.None;
        PDyB.ColumnCount = 4;
        PDyB.ColumnStyles.Add(new ColumnStyle());
        PDyB.ColumnStyles.Add(new ColumnStyle());
        PDyB.ColumnStyles.Add(new ColumnStyle());
        PDyB.ColumnStyles.Add(new ColumnStyle());
        PDyB.Location = new Point(6, Class13.NpMd);
        PDyB.Name = Class13.mpMH;
        PDyB.RowCount = 8;
        PDyB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.jpM4));
        PDyB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.IpM5));
        PDyB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.QpMs));
        PDyB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.QpMZ));
        PDyB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.NpMa));
        PDyB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.opMj));
        PDyB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.vpMz));
        PDyB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.IpuE));
        PDyB.Size = new Size(Class13.rpuD, Class13.PpuX);
        PDyB.TabIndex = Class13.Spup;
        NDyA.Anchor = AnchorStyles.None;
        NDyA.AutoSize = true;
        NDyA.Enabled = false;
        NDyA.Location = new Point(Class13.QpuS, Class13.Lpuh);
        NDyA.Name = Class13.npul;
        NDyA.Size = new Size(Class13.ypuG, Class13.Qpub);
        NDyA.TabIndex = Class13.ppuv;
        NDyA.UseVisualStyleBackColor = true;
        dDyf.Anchor = AnchorStyles.None;
        dDyf.AutoSize = true;
        dDyf.Enabled = false;
        dDyf.Location = new Point(Class13.Jpuo, Class13.xput);
        dDyf.Name = Class13.cpuV;
        dDyf.Size = new Size(Class13.mpuO, Class13.npue);
        dDyf.TabIndex = Class13.ypu8;
        dDyf.UseVisualStyleBackColor = true;
        ADy6.Anchor = AnchorStyles.None;
        ADy6.AutoSize = true;
        ADy6.Enabled = false;
        ADy6.Location = new Point(Class13.upun, Class13.IpuQ);
        ADy6.Name = Class13.gpuF;
        ADy6.Size = new Size(Class13.EpuL, Class13.LpuJ);
        ADy6.TabIndex = Class13.jpu7;
        ADy6.UseVisualStyleBackColor = true;
        YDyx.Anchor = AnchorStyles.None;
        YDyx.AutoSize = true;
        YDyx.Enabled = false;
        YDyx.Location = new Point(Class13.PpuP, Class13.Bpui);
        YDyx.Name = Class13.upum;
        YDyx.Size = new Size(Class13.Apu0, Class13.fpuI);
        YDyx.TabIndex = Class13.hpuR;
        YDyx.UseVisualStyleBackColor = true;
        IDy9.Anchor = AnchorStyles.None;
        IDy9.AutoSize = true;
        IDy9.Enabled = false;
        IDy9.Location = new Point(Class13.OpuC, Class13.OpuK);
        IDy9.Name = Class13.EpuU;
        IDy9.Size = new Size(Class13.tpuT, Class13.spu1);
        IDy9.TabIndex = Class13.wpuW;
        IDy9.UseVisualStyleBackColor = true;
        GDyc.Anchor = AnchorStyles.None;
        GDyc.AutoSize = true;
        GDyc.Enabled = false;
        GDyc.Location = new Point(Class13.Wpuw, 3);
        GDyc.Name = Class13.tpuN;
        GDyc.Size = new Size(Class13.WpuY, Class13.ppuB);
        GDyc.TabIndex = Class13.ppuA;
        GDyc.UseVisualStyleBackColor = true;
        hDyy.Anchor = AnchorStyles.None;
        hDyy.AutoSize = true;
        hDyy.Enabled = false;
        hDyy.Location = new Point(Class13.ypuf, Class13.Ypu6);
        hDyy.Name = Class13.Wpux;
        hDyy.Size = new Size(Class13.spu9, Class13.Upuc);
        hDyy.TabIndex = Class13.Fpuy;
        hDyy.UseVisualStyleBackColor = true;
        KDyr.Anchor = AnchorStyles.None;
        KDyr.AutoSize = true;
        KDyr.Location = new Point(Class13.zpur, Class13.qpuq);
        KDyr.Name = Class13.Rpuk;
        KDyr.Size = new Size(Class13.EpuM, Class13.Bpuu);
        KDyr.TabIndex = Class13.opug;
        FDyq.Anchor = AnchorStyles.None;
        FDyq.AutoSize = true;
        FDyq.Location = new Point(Class13.opu2, 1);
        FDyq.Name = Class13.hpu3;
        FDyq.Size = new Size(Class13.Cpud, Class13.xpuH);
        FDyq.TabIndex = 2;
        RDyk.Anchor = AnchorStyles.None;
        RDyk.AutoSize = true;
        RDyk.Enabled = false;
        RDyk.Location = new Point(Class13.wpu4, Class13.Cpu5);
        RDyk.Name = Class13.Cpus;
        RDyk.Size = new Size(Class13.spuZ, Class13.Ppua);
        RDyk.TabIndex = Class13.Gpuj;
        RDyk.UseVisualStyleBackColor = true;
        VDyM.Anchor = AnchorStyles.None;
        VDyM.AutoSize = true;
        VDyM.Location = new Point(3, Class13.dpuz);
        VDyM.Name = Class13.rpgE;
        VDyM.Size = new Size(Class13.bpgD, Class13.wpgX);
        VDyM.TabIndex = 7;
        oDyu.Anchor = AnchorStyles.None;
        oDyu.AutoSize = true;
        oDyu.Enabled = false;
        oDyu.Location = new Point(Class13.Ipgp, Class13.DpgS);
        oDyu.Name = Class13.jpgh;
        oDyu.Size = new Size(Class13.Npgl, Class13.XpgG);
        oDyu.TabIndex = Class13.Rpgb;
        oDyu.UseVisualStyleBackColor = true;
        JDyg.Anchor = AnchorStyles.None;
        JDyg.AutoSize = true;
        JDyg.Location = new Point(Class13.Npgv, Class13.Hpgo);
        JDyg.Name = Class13.ipgt;
        JDyg.Size = new Size(Class13.npgV, Class13.IpgO);
        JDyg.TabIndex = Class13.gpge;
        VDy2.Anchor = AnchorStyles.None;
        VDy2.AutoSize = true;
        VDy2.Location = new Point(Class13.Spg8, Class13.vpgn);
        VDy2.Name = Class13.HpgQ;
        VDy2.Size = new Size(Class13.FpgF, Class13.upgL);
        VDy2.TabIndex = 6;
        IDy3.Anchor = AnchorStyles.None;
        IDy3.AutoSize = true;
        IDy3.Location = new Point(Class13.ppgJ, Class13.Vpg7);
        IDy3.Name = Class13.mpgP;
        IDy3.Size = new Size(Class13.Rpgi, Class13.Opgm);
        IDy3.TabIndex = Class13.Epg0;
        eDyd.Anchor = AnchorStyles.None;
        eDyd.AutoSize = true;
        eDyd.Location = new Point(Class13.FpgI, Class13.MpgR);
        eDyd.Name = Class13.PpgC;
        eDyd.Size = new Size(Class13.epgK, Class13.ppgU);
        eDyd.TabIndex = 4;
        EDyH.Anchor = AnchorStyles.None;
        EDyH.AutoSize = true;
        EDyH.Enabled = false;
        EDyH.Location = new Point(Class13.QpgT, Class13.epg1);
        EDyH.Name = Class13.YpgW;
        EDyH.Size = new Size(Class13.qpgw, Class13.qpgN);
        EDyH.TabIndex = Class13.RpgY;
        EDyH.UseVisualStyleBackColor = true;
        VDy4.Anchor = AnchorStyles.None;
        VDy4.AutoSize = true;
        VDy4.Location = new Point(Class13.MpgB, Class13.VpgA);
        VDy4.Name = Class13.Gpgf;
        VDy4.Size = new Size(Class13.rpg6, Class13.Ipgx);
        VDy4.TabIndex = Class13.hpg9;
        RDy5.Anchor = AnchorStyles.None;
        RDy5.AutoSize = true;
        RDy5.Location = new Point(8, Class13.Fpgc);
        RDy5.Name = Class13.epgy;
        RDy5.Size = new Size(Class13.npgr, Class13.Qpgq);
        RDy5.TabIndex = 0;
        xDys.Anchor = AnchorStyles.None;
        xDys.AutoSize = true;
        xDys.Location = new Point(Class13.dpgk, Class13.MpgM);
        xDys.Name = Class13.mpgu;
        xDys.Size = new Size(Class13.mpgg, Class13.bpg2);
        xDys.TabIndex = Class13.spg3;
        cDyZ.Anchor = AnchorStyles.None;
        cDyZ.AutoSize = true;
        cDyZ.Enabled = false;
        cDyZ.Location = new Point(Class13.dpgd, 3);
        cDyZ.Name = Class13.PpgH;
        cDyZ.Size = new Size(Class13.Mpg4, Class13.fpg5);
        cDyZ.TabIndex = Class13.Dpgs;
        cDyZ.UseVisualStyleBackColor = true;
        zDya.Anchor = AnchorStyles.None;
        zDya.AutoSize = true;
        zDya.Location = new Point(Class13.FpgZ, Class13.Dpga);
        zDya.Name = Class13.tpgj;
        zDya.Size = new Size(Class13.Apgz, Class13.rp2E);
        zDya.TabIndex = 8;
        NDyj.Anchor = AnchorStyles.None;
        NDyj.AutoSize = true;
        NDyj.Location = new Point(Class13.Ep2D, Class13.ip2X);
        NDyj.Name = Class13.pp2p;
        NDyj.Size = new Size(Class13.ap2S, Class13.Vp2h);
        NDyj.TabIndex = 1;
        gDyz.Anchor = AnchorStyles.None;
        gDyz.AutoSize = true;
        gDyz.Enabled = false;
        gDyz.Location = new Point(Class13.Jp2l, Class13.Ip2G);
        gDyz.Name = Class13.Vp2b;
        gDyz.Size = new Size(Class13.hp2v, Class13.ep2o);
        gDyz.TabIndex = Class13.Qp2t;
        gDyz.UseVisualStyleBackColor = true;
        VDrE.Anchor = AnchorStyles.None;
        VDrE.AutoSize = true;
        VDrE.Location = new Point(Class13.dp2V, Class13.bp2O);
        VDrE.Name = Class13.cp2e;
        VDrE.Size = new Size(Class13.np28, Class13.vp2n);
        VDrE.TabIndex = 3;
        hDrD.Anchor = AnchorStyles.None;
        hDrD.AutoSize = true;
        hDrD.Location = new Point(Class13.dp2Q, Class13.Rp2F);
        hDrD.Name = Class13.qp2L;
        hDrD.Size = new Size(Class13.rp2J, Class13.ip27);
        hDrD.TabIndex = Class13.Up2P;
        UDrX.Anchor = AnchorStyles.None;
        UDrX.AutoSize = true;
        UDrX.Location = new Point(Class13.qp2i, Class13.pp2m);
        UDrX.Name = Class13.up20;
        UDrX.Size = new Size(Class13.Qp2I, Class13.Tp2R);
        UDrX.TabIndex = Class13.Ip2C;
        xDrp.Anchor = AnchorStyles.None;
        xDrp.AutoSize = true;
        xDrp.Location = new Point(Class13.op2K, 1);
        xDrp.Name = Class13.mp2U;
        xDrp.Size = new Size(Class13.fp2T, Class13.Mp21);
        xDrp.TabIndex = 5;
        SDrS.AutoSize = true;
        SDrS.Location = new Point(Class13.Ip2W, Class13.Jp2w);
        SDrS.Name = Class13.rp2N;
        SDrS.Size = new Size(Class13.jp2Y, Class13.ep2B);
        SDrS.TabIndex = Class13.vp2A;
        MDrh.AutoSize = true;
        MDrh.Location = new Point(Class13.op2f, Class13.Dp26);
        MDrh.Name = Class13.xp2x;
        MDrh.Size = new Size(Class13.up29, Class13.Bp2c);
        MDrh.TabIndex = Class13.up2y;
        uDrl.Anchor = AnchorStyles.None;
        uDrl.ColumnCount = 4;
        uDrl.ColumnStyles.Add(new ColumnStyle());
        uDrl.ColumnStyles.Add(new ColumnStyle());
        uDrl.ColumnStyles.Add(new ColumnStyle());
        uDrl.ColumnStyles.Add(new ColumnStyle());
        uDrl.Location = new Point(6, Class13.rp2r);
        uDrl.Name = Class13.Wp2q;
        uDrl.RowCount = 8;
        uDrl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.jp2k));
        uDrl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Up2M));
        uDrl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Hp2u));
        uDrl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Fp2g));
        uDrl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.xp22));
        uDrl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.dp23));
        uDrl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.qp2d));
        uDrl.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.Fp2H));
        uDrl.Size = new Size(Class13.gp24, Class13.Ap25);
        uDrl.TabIndex = Class13.rp2s;
        DDrG.Anchor = AnchorStyles.None;
        DDrG.AutoSize = true;
        DDrG.Enabled = false;
        DDrG.Location = new Point(Class13.gp2Z, Class13.mp2a);
        DDrG.Name = Class13.op2j;
        DDrG.Size = new Size(Class13.dp2z, Class13.Tp3E);
        DDrG.TabIndex = Class13.Ep3D;
        DDrG.UseVisualStyleBackColor = true;
        GDrb.Anchor = AnchorStyles.None;
        GDrb.AutoSize = true;
        GDrb.Enabled = false;
        GDrb.Location = new Point(Class13.Wp3X, Class13.ap3p);
        GDrb.Name = Class13.Jp3S;
        GDrb.Size = new Size(Class13.Sp3h, Class13.Cp3l);
        GDrb.TabIndex = Class13.xp3G;
        GDrb.UseVisualStyleBackColor = true;
        CDrv.Anchor = AnchorStyles.None;
        CDrv.AutoSize = true;
        CDrv.Enabled = false;
        CDrv.Location = new Point(Class13.cp3b, Class13.lp3v);
        CDrv.Name = Class13.jp3o;
        CDrv.Size = new Size(Class13.cp3t, Class13.Cp3V);
        CDrv.TabIndex = Class13.dp3O;
        CDrv.UseVisualStyleBackColor = true;
        hDro.Anchor = AnchorStyles.None;
        hDro.AutoSize = true;
        hDro.Enabled = false;
        hDro.Location = new Point(Class13.Jp3e, Class13.Ip38);
        hDro.Name = Class13.Gp3n;
        hDro.Size = new Size(Class13.pp3Q, Class13.Kp3F);
        hDro.TabIndex = Class13.Pp3L;
        hDro.UseVisualStyleBackColor = true;
        pDrt.Anchor = AnchorStyles.None;
        pDrt.AutoSize = true;
        pDrt.Enabled = false;
        pDrt.Location = new Point(Class13.op3J, Class13.Ep37);
        pDrt.Name = Class13.kp3P;
        pDrt.Size = new Size(Class13.vp3i, Class13.sp3m);
        pDrt.TabIndex = Class13.Dp30;
        pDrt.UseVisualStyleBackColor = true;
        QDrV.Anchor = AnchorStyles.None;
        QDrV.AutoSize = true;
        QDrV.Enabled = false;
        QDrV.Location = new Point(Class13.Fp3I, 3);
        QDrV.Name = Class13.Mp3R;
        QDrV.Size = new Size(Class13.Up3C, Class13.Ep3K);
        QDrV.TabIndex = Class13.fp3U;
        QDrV.UseVisualStyleBackColor = true;
        cDrO.Anchor = AnchorStyles.None;
        cDrO.AutoSize = true;
        cDrO.Enabled = false;
        cDrO.Location = new Point(Class13.Jp3T, Class13.pp31);
        cDrO.Name = Class13.ip3W;
        cDrO.Size = new Size(Class13.Np3w, Class13.rp3N);
        cDrO.TabIndex = Class13.vp3Y;
        cDrO.UseVisualStyleBackColor = true;
        NDre.Anchor = AnchorStyles.None;
        NDre.AutoSize = true;
        NDre.Location = new Point(Class13.Mp3B, Class13.yp3A);
        NDre.Name = Class13.Pp3f;
        NDre.Size = new Size(Class13.zp36, Class13.Op3x);
        NDre.TabIndex = Class13.yp39;
        hDr8.Anchor = AnchorStyles.None;
        hDr8.AutoSize = true;
        hDr8.Location = new Point(Class13.op3c, 1);
        hDr8.Name = Class13.cp3y;
        hDr8.Size = new Size(Class13.kp3r, Class13.ep3q);
        hDr8.TabIndex = 2;
        cDrn.Anchor = AnchorStyles.None;
        cDrn.AutoSize = true;
        cDrn.Enabled = false;
        cDrn.Location = new Point(Class13.Mp3k, Class13.vp3M);
        cDrn.Name = Class13.fp3u;
        cDrn.Size = new Size(Class13.qp3g, Class13.kp32);
        cDrn.TabIndex = Class13.Op33;
        cDrn.UseVisualStyleBackColor = true;
        iDrQ.Anchor = AnchorStyles.None;
        iDrQ.AutoSize = true;
        iDrQ.Location = new Point(3, Class13.Dp3d);
        iDrQ.Name = Class13.cp3H;
        iDrQ.Size = new Size(Class13.Qp34, Class13.Ip35);
        iDrQ.TabIndex = 7;
        oDrF.Anchor = AnchorStyles.None;
        oDrF.AutoSize = true;
        oDrF.Enabled = false;
        oDrF.Location = new Point(Class13.Np3s, Class13.tp3Z);
        oDrF.Name = Class13.Wp3a;
        oDrF.Size = new Size(Class13.lp3j, Class13.sp3z);
        oDrF.TabIndex = Class13.TpdE;
        oDrF.UseVisualStyleBackColor = true;
        zDrL.Anchor = AnchorStyles.None;
        zDrL.AutoSize = true;
        zDrL.Location = new Point(Class13.lpdD, Class13.jpdX);
        zDrL.Name = Class13.Fpdp;
        zDrL.Size = new Size(Class13.WpdS, Class13.rpdh);
        zDrL.TabIndex = Class13.Dpdl;
        SDrJ.Anchor = AnchorStyles.None;
        SDrJ.AutoSize = true;
        SDrJ.Location = new Point(Class13.YpdG, Class13.mpdb);
        SDrJ.Name = Class13.Mpdv;
        SDrJ.Size = new Size(Class13.Apdo, Class13.epdt);
        SDrJ.TabIndex = 6;
        IDr7.Anchor = AnchorStyles.None;
        IDr7.AutoSize = true;
        IDr7.Location = new Point(Class13.MpdV, Class13.GpdO);
        IDr7.Name = Class13.jpde;
        IDr7.Size = new Size(Class13.bpd8, Class13.ppdn);
        IDr7.TabIndex = Class13.ipdQ;
        yDrP.Anchor = AnchorStyles.None;
        yDrP.AutoSize = true;
        yDrP.Location = new Point(Class13.MpdF, Class13.CpdL);
        yDrP.Name = Class13.rpdJ;
        yDrP.Size = new Size(Class13.Vpd7, Class13.dpdP);
        yDrP.TabIndex = 4;
        bDri.Anchor = AnchorStyles.None;
        bDri.AutoSize = true;
        bDri.Enabled = false;
        bDri.Location = new Point(Class13.Gpdi, Class13.Wpdm);
        bDri.Name = Class13.bpd0;
        bDri.Size = new Size(Class13.gpdI, Class13.CpdR);
        bDri.TabIndex = Class13.fpdC;
        bDri.UseVisualStyleBackColor = true;
        lDrm.Anchor = AnchorStyles.None;
        lDrm.AutoSize = true;
        lDrm.Location = new Point(Class13.apdK, Class13.OpdU);
        lDrm.Name = Class13.vpdT;
        lDrm.Size = new Size(Class13.Ypd1, Class13.epdW);
        lDrm.TabIndex = Class13.opdw;
        XDr0.Anchor = AnchorStyles.None;
        XDr0.AutoSize = true;
        XDr0.Location = new Point(8, Class13.TpdN);
        XDr0.Name = Class13.UpdY;
        XDr0.Size = new Size(Class13.xpdB, Class13.ApdA);
        XDr0.TabIndex = 0;
        YDrI.Anchor = AnchorStyles.None;
        YDrI.AutoSize = true;
        YDrI.Location = new Point(Class13.qpdf, Class13.Lpd6);
        YDrI.Name = Class13.Opdx;
        YDrI.Size = new Size(Class13.Ypd9, Class13.Hpdc);
        YDrI.TabIndex = Class13.Dpdy;
        qDrR.Anchor = AnchorStyles.None;
        qDrR.AutoSize = true;
        qDrR.Enabled = false;
        qDrR.Location = new Point(Class13.Opdr, 3);
        qDrR.Name = Class13.Vpdq;
        qDrR.Size = new Size(Class13.Npdk, Class13.xpdM);
        qDrR.TabIndex = Class13.Fpdu;
        qDrR.UseVisualStyleBackColor = true;
        dDrC.Anchor = AnchorStyles.None;
        dDrC.AutoSize = true;
        dDrC.Location = new Point(Class13.gpdg, Class13.Xpd2);
        dDrC.Name = Class13.Xpd3;
        dDrC.Size = new Size(Class13.fpdd, Class13.QpdH);
        dDrC.TabIndex = 8;
        EDrK.Anchor = AnchorStyles.None;
        EDrK.AutoSize = true;
        EDrK.Location = new Point(Class13.Opd4, Class13.upd5);
        EDrK.Name = Class13.Fpds;
        EDrK.Size = new Size(Class13.npdZ, Class13.ipda);
        EDrK.TabIndex = 1;
        mDrU.Anchor = AnchorStyles.None;
        mDrU.AutoSize = true;
        mDrU.Enabled = false;
        mDrU.Location = new Point(Class13.dpdj, Class13.epdz);
        mDrU.Name = Class13.VpHE;
        mDrU.Size = new Size(Class13.hpHD, Class13.OpHX);
        mDrU.TabIndex = Class13.DpHp;
        mDrU.UseVisualStyleBackColor = true;
        eDrT.Anchor = AnchorStyles.None;
        eDrT.AutoSize = true;
        eDrT.Location = new Point(Class13.hpHS, Class13.OpHh);
        eDrT.Name = Class13.EpHl;
        eDrT.Size = new Size(Class13.ipHG, Class13.bpHb);
        eDrT.TabIndex = 3;
        NDr1.Anchor = AnchorStyles.None;
        NDr1.AutoSize = true;
        NDr1.Location = new Point(Class13.WpHv, Class13.apHo);
        NDr1.Name = Class13.GpHt;
        NDr1.Size = new Size(Class13.HpHV, Class13.npHO);
        NDr1.TabIndex = Class13.PpHe;
        KDrW.Anchor = AnchorStyles.None;
        KDrW.AutoSize = true;
        KDrW.Location = new Point(Class13.apH8, Class13.qpHn);
        KDrW.Name = Class13.TpHQ;
        KDrW.Size = new Size(Class13.upHF, Class13.jpHL);
        KDrW.TabIndex = Class13.LpHJ;
        zDrw.Anchor = AnchorStyles.None;
        zDrw.AutoSize = true;
        zDrw.Location = new Point(Class13.VpH7, 1);
        zDrw.Name = Class13.CpHP;
        zDrw.Size = new Size(Class13.GpHi, Class13.IpHm);
        zDrw.TabIndex = 5;
        iDrN.AutoSize = true;
        iDrN.Location = new Point(Class13.LpH0, Class13.lpHI);
        iDrN.Name = Class13.epHR;
        iDrN.Size = new Size(Class13.OpHC, Class13.IpHK);
        iDrN.TabIndex = Class13.opHU;
        mDrY.AutoSize = true;
        mDrY.Location = new Point(Class13.qpHT, Class13.npH1);
        mDrY.Name = Class13.PpHW;
        mDrY.Size = new Size(Class13.wpHw, Class13.OpHN);
        mDrY.TabIndex = Class13.JpHY;
        bDrB.Anchor = AnchorStyles.None;
        bDrB.ColumnCount = 4;
        bDrB.ColumnStyles.Add(new ColumnStyle());
        bDrB.ColumnStyles.Add(new ColumnStyle());
        bDrB.ColumnStyles.Add(new ColumnStyle());
        bDrB.ColumnStyles.Add(new ColumnStyle());
        bDrB.Location = new Point(6, Class13.vpHB);
        bDrB.Name = Class13.ypHA;
        bDrB.RowCount = 8;
        bDrB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.VpHf));
        bDrB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.gpH6));
        bDrB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.CpHx));
        bDrB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.npH9));
        bDrB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.cpHc));
        bDrB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.spHy));
        bDrB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.kpHr));
        bDrB.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.RpHq));
        bDrB.Size = new Size(Class13.mpHk, Class13.SpHM);
        bDrB.TabIndex = Class13.OpHu;
        vDrA.Anchor = AnchorStyles.None;
        vDrA.AutoSize = true;
        vDrA.Enabled = false;
        vDrA.Location = new Point(Class13.rpHg, Class13.opH2);
        vDrA.Name = Class13.apH3;
        vDrA.Size = new Size(Class13.ApHd, Class13.kpHH);
        vDrA.TabIndex = Class13.PpH4;
        vDrA.UseVisualStyleBackColor = true;
        BDrf.Anchor = AnchorStyles.None;
        BDrf.AutoSize = true;
        BDrf.Enabled = false;
        BDrf.Location = new Point(Class13.qpH5, Class13.IpHs);
        BDrf.Name = Class13.bpHZ;
        BDrf.Size = new Size(Class13.OpHa, Class13.QpHj);
        BDrf.TabIndex = Class13.apHz;
        BDrf.UseVisualStyleBackColor = true;
        PDr6.Anchor = AnchorStyles.None;
        PDr6.AutoSize = true;
        PDr6.Enabled = false;
        PDr6.Location = new Point(Class13.Ep4E, Class13.Fp4D);
        PDr6.Name = Class13.zp4X;
        PDr6.Size = new Size(Class13.Qp4p, Class13.hp4S);
        PDr6.TabIndex = Class13.Lp4h;
        PDr6.UseVisualStyleBackColor = true;
        GDrx.Anchor = AnchorStyles.None;
        GDrx.AutoSize = true;
        GDrx.Enabled = false;
        GDrx.Location = new Point(Class13.Ap4l, Class13.yp4G);
        GDrx.Name = Class13.Up4b;
        GDrx.Size = new Size(Class13.ap4v, Class13.op4o);
        GDrx.TabIndex = Class13.Kp4t;
        GDrx.UseVisualStyleBackColor = true;
        vDr9.Anchor = AnchorStyles.None;
        vDr9.AutoSize = true;
        vDr9.Enabled = false;
        vDr9.Location = new Point(Class13.gp4V, Class13.Dp4O);
        vDr9.Name = Class13.Wp4e;
        vDr9.Size = new Size(Class13.Kp48, Class13.ep4n);
        vDr9.TabIndex = Class13.Ap4Q;
        vDr9.UseVisualStyleBackColor = true;
        RDrc.Anchor = AnchorStyles.None;
        RDrc.AutoSize = true;
        RDrc.Enabled = false;
        RDrc.Location = new Point(Class13.tp4F, 3);
        RDrc.Name = Class13.Gp4L;
        RDrc.Size = new Size(Class13.cp4J, Class13.rp47);
        RDrc.TabIndex = Class13.ep4P;
        RDrc.UseVisualStyleBackColor = true;
        nDry.Anchor = AnchorStyles.None;
        nDry.AutoSize = true;
        nDry.Enabled = false;
        nDry.Location = new Point(Class13.Op4i, Class13.ap4m);
        nDry.Name = Class13.lp40;
        nDry.Size = new Size(Class13.lp4I, Class13.Pp4R);
        nDry.TabIndex = Class13.xp4C;
        nDry.UseVisualStyleBackColor = true;
        SDrr.Anchor = AnchorStyles.None;
        SDrr.AutoSize = true;
        SDrr.Location = new Point(Class13.Ep4K, Class13.Gp4U);
        SDrr.Name = Class13.Hp4T;
        SDrr.Size = new Size(Class13.Ap41, Class13.jp4W);
        SDrr.TabIndex = Class13.gp4w;
        jDrq.Anchor = AnchorStyles.None;
        jDrq.AutoSize = true;
        jDrq.Location = new Point(Class13.yp4N, 1);
        jDrq.Name = Class13.Cp4Y;
        jDrq.Size = new Size(Class13.kp4B, Class13.wp4A);
        jDrq.TabIndex = 2;
        DDrk.Anchor = AnchorStyles.None;
        DDrk.AutoSize = true;
        DDrk.Enabled = false;
        DDrk.Location = new Point(Class13.zp4f, Class13.kp46);
        DDrk.Name = Class13.lp4x;
        DDrk.Size = new Size(Class13.zp49, Class13.Rp4c);
        DDrk.TabIndex = Class13.Ip4y;
        DDrk.UseVisualStyleBackColor = true;
        WDrM.Anchor = AnchorStyles.None;
        WDrM.AutoSize = true;
        WDrM.Location = new Point(3, Class13.qp4r);
        WDrM.Name = Class13.qp4q;
        WDrM.Size = new Size(Class13.Lp4k, Class13.rp4M);
        WDrM.TabIndex = 7;
        kDru.Anchor = AnchorStyles.None;
        kDru.AutoSize = true;
        kDru.Enabled = false;
        kDru.Location = new Point(Class13.lp4u, Class13.wp4g);
        kDru.Name = Class13.Mp42;
        kDru.Size = new Size(Class13.cp43, Class13.Jp4d);
        kDru.TabIndex = Class13.hp4H;
        kDru.UseVisualStyleBackColor = true;
        GDrg.Anchor = AnchorStyles.None;
        GDrg.AutoSize = true;
        GDrg.Location = new Point(Class13.tp44, Class13.bp45);
        GDrg.Name = Class13.pp4s;
        GDrg.Size = new Size(Class13.Xp4Z, Class13.op4a);
        GDrg.TabIndex = Class13.rp4j;
        kDr2.Anchor = AnchorStyles.None;
        kDr2.AutoSize = true;
        kDr2.Location = new Point(Class13.hp4z, Class13.cp5E);
        kDr2.Name = Class13.op5D;
        kDr2.Size = new Size(Class13.Dp5X, Class13.vp5p);
        kDr2.TabIndex = 6;
        LDr3.Anchor = AnchorStyles.None;
        LDr3.AutoSize = true;
        LDr3.Location = new Point(Class13.Np5S, Class13.Wp5h);
        LDr3.Name = Class13.ip5l;
        LDr3.Size = new Size(Class13.Hp5G, Class13.Lp5b);
        LDr3.TabIndex = Class13.Mp5v;
        vDrd.Anchor = AnchorStyles.None;
        vDrd.AutoSize = true;
        vDrd.Location = new Point(Class13.Qp5o, Class13.Ap5t);
        vDrd.Name = Class13.Hp5V;
        vDrd.Size = new Size(Class13.Up5O, Class13.Mp5e);
        vDrd.TabIndex = 4;
        uDrH.Anchor = AnchorStyles.None;
        uDrH.AutoSize = true;
        uDrH.Enabled = false;
        uDrH.Location = new Point(Class13.kp58, Class13.qp5n);
        uDrH.Name = Class13.zp5Q;
        uDrH.Size = new Size(Class13.Bp5F, Class13.Gp5L);
        uDrH.TabIndex = Class13.Tp5J;
        uDrH.UseVisualStyleBackColor = true;
        mDr4.Anchor = AnchorStyles.None;
        mDr4.AutoSize = true;
        mDr4.Location = new Point(Class13.Xp57, Class13.op5P);
        mDr4.Name = Class13.Dp5i;
        mDr4.Size = new Size(Class13.Vp5m, Class13.Qp50);
        mDr4.TabIndex = Class13.ep5I;
        mDr5.Anchor = AnchorStyles.None;
        mDr5.AutoSize = true;
        mDr5.Location = new Point(8, Class13.Jp5R);
        mDr5.Name = Class13.qp5C;
        mDr5.Size = new Size(Class13.rp5K, Class13.Rp5U);
        mDr5.TabIndex = 0;
        XDrs.Anchor = AnchorStyles.None;
        XDrs.AutoSize = true;
        XDrs.Location = new Point(Class13.sp5T, Class13.jp51);
        XDrs.Name = Class13.sp5W;
        XDrs.Size = new Size(Class13.Up5w, Class13.fp5N);
        XDrs.TabIndex = Class13.Qp5Y;
        ODrZ.Anchor = AnchorStyles.None;
        ODrZ.AutoSize = true;
        ODrZ.Enabled = false;
        ODrZ.Location = new Point(Class13.Bp5B, 3);
        ODrZ.Name = Class13.sp5A;
        ODrZ.Size = new Size(Class13.Op5f, Class13.Bp56);
        ODrZ.TabIndex = Class13.Tp5x;
        ODrZ.UseVisualStyleBackColor = true;
        UDra.Anchor = AnchorStyles.None;
        UDra.AutoSize = true;
        UDra.Location = new Point(Class13.Sp59, Class13.vp5c);
        UDra.Name = Class13.Mp5y;
        UDra.Size = new Size(Class13.Gp5r, Class13.Tp5q);
        UDra.TabIndex = 8;
        uDrj.Anchor = AnchorStyles.None;
        uDrj.AutoSize = true;
        uDrj.Location = new Point(Class13.Qp5k, Class13.Op5M);
        uDrj.Name = Class13.Ap5u;
        uDrj.Size = new Size(Class13.Ep5g, Class13.Dp52);
        uDrj.TabIndex = 1;
        VDrz.Anchor = AnchorStyles.None;
        VDrz.AutoSize = true;
        VDrz.Enabled = false;
        VDrz.Location = new Point(Class13.xp53, Class13.wp5d);
        VDrz.Name = Class13.Kp5H;
        VDrz.Size = new Size(Class13.Rp54, Class13.Yp55);
        VDrz.TabIndex = Class13.Yp5s;
        VDrz.UseVisualStyleBackColor = true;
        BDqE.Anchor = AnchorStyles.None;
        BDqE.AutoSize = true;
        BDqE.Location = new Point(Class13.Fp5Z, Class13.Qp5a);
        BDqE.Name = Class13.op5j;
        BDqE.Size = new Size(Class13.fp5z, Class13.LpsE);
        BDqE.TabIndex = 3;
        RDqD.Anchor = AnchorStyles.None;
        RDqD.AutoSize = true;
        RDqD.Location = new Point(Class13.qpsD, Class13.YpsX);
        RDqD.Name = Class13.lpsp;
        RDqD.Size = new Size(Class13.vpsS, Class13.wpsh);
        RDqD.TabIndex = Class13.lpsl;
        NDqX.Anchor = AnchorStyles.None;
        NDqX.AutoSize = true;
        NDqX.Location = new Point(Class13.jpsG, Class13.fpsb);
        NDqX.Name = Class13.Npsv;
        NDqX.Size = new Size(Class13.Gpso, Class13.dpst);
        NDqX.TabIndex = Class13.KpsV;
        NDqp.Anchor = AnchorStyles.None;
        NDqp.AutoSize = true;
        NDqp.Location = new Point(Class13.IpsO, 1);
        NDqp.Name = Class13.ppse;
        NDqp.Size = new Size(Class13.Nps8, Class13.Epsn);
        NDqp.TabIndex = 5;
        iDqS.AutoSize = true;
        iDqS.Location = new Point(Class13.KpsQ, Class13.CpsF);
        iDqS.Name = Class13.upsL;
        iDqS.Size = new Size(Class13.TpsJ, Class13.ips7);
        iDqS.TabIndex = Class13.ypsP;
        pDqh.AutoSize = true;
        pDqh.Location = new Point(Class13.Upsi, Class13.epsm);
        pDqh.Name = Class13.yps0;
        pDqh.Size = new Size(Class13.kpsI, Class13.xpsR);
        pDqh.TabIndex = Class13.npsC;
        dDql.Anchor = AnchorStyles.None;
        dDql.ColumnCount = 4;
        dDql.ColumnStyles.Add(new ColumnStyle());
        dDql.ColumnStyles.Add(new ColumnStyle());
        dDql.ColumnStyles.Add(new ColumnStyle());
        dDql.ColumnStyles.Add(new ColumnStyle());
        dDql.Location = new Point(6, Class13.kpsK);
        dDql.Name = Class13.MpsU;
        dDql.RowCount = 8;
        dDql.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.LpsT));
        dDql.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.eps1));
        dDql.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.fpsW));
        dDql.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.lpsw));
        dDql.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.LpsN));
        dDql.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.npsY));
        dDql.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.GpsB));
        dDql.RowStyles.Add(new RowStyle(SizeType.Percent, Class13.ApsA));
        dDql.Size = new Size(Class13.npsf, Class13.Dps6);
        dDql.TabIndex = Class13.Cpsx;
        aDqG.Anchor = AnchorStyles.None;
        aDqG.AutoSize = true;
        aDqG.Enabled = false;
        aDqG.Location = new Point(Class13.vps9, Class13.Tpsc);
        aDqG.Name = Class13.Ppsy;
        aDqG.Size = new Size(Class13.Ipsr, Class13.lpsq);
        aDqG.TabIndex = Class13.fpsk;
        aDqG.UseVisualStyleBackColor = true;
        PDqb.Anchor = AnchorStyles.None;
        PDqb.AutoSize = true;
        PDqb.Enabled = false;
        PDqb.Location = new Point(Class13.zpsM, Class13.Bpsu);
        PDqb.Name = Class13.spsg;
        PDqb.Size = new Size(Class13.cps2, Class13.Mps3);
        PDqb.TabIndex = Class13.Kpsd;
        PDqb.UseVisualStyleBackColor = true;
        WDqv.Anchor = AnchorStyles.None;
        WDqv.AutoSize = true;
        WDqv.Enabled = false;
        WDqv.Location = new Point(Class13.cpsH, Class13.Tps4);
        WDqv.Name = Class13.Ops5;
        WDqv.Size = new Size(Class13.tpss, Class13.MpsZ);
        WDqv.TabIndex = Class13.vpsa;
        WDqv.UseVisualStyleBackColor = true;
        CDqo.Anchor = AnchorStyles.None;
        CDqo.AutoSize = true;
        CDqo.Enabled = false;
        CDqo.Location = new Point(Class13.Hpsj, Class13.jpsz);
        CDqo.Name = Class13.JpZE;
        CDqo.Size = new Size(Class13.fpZD, Class13.gpZX);
        CDqo.TabIndex = Class13.SpZp;
        CDqo.UseVisualStyleBackColor = true;
        UDqt.Anchor = AnchorStyles.None;
        UDqt.AutoSize = true;
        UDqt.Enabled = false;
        UDqt.Location = new Point(Class13.spZS, Class13.cpZh);
        UDqt.Name = Class13.JpZl;
        UDqt.Size = new Size(Class13.MpZG, Class13.YpZb);
        UDqt.TabIndex = Class13.NpZv;
        UDqt.UseVisualStyleBackColor = true;
        VDqV.Anchor = AnchorStyles.None;
        VDqV.AutoSize = true;
        VDqV.Enabled = false;
        VDqV.Location = new Point(Class13.NpZo, 3);
        VDqV.Name = Class13.ipZt;
        VDqV.Size = new Size(Class13.NpZV, Class13.epZO);
        VDqV.TabIndex = Class13.vpZe;
        VDqV.UseVisualStyleBackColor = true;
        YDqO.Anchor = AnchorStyles.None;
        YDqO.AutoSize = true;
        YDqO.Enabled = false;
        YDqO.Location = new Point(Class13.UpZ8, Class13.ppZn);
        YDqO.Name = Class13.qpZQ;
        YDqO.Size = new Size(Class13.LpZF, Class13.ypZL);
        YDqO.TabIndex = Class13.zpZJ;
        YDqO.UseVisualStyleBackColor = true;
        NDqe.Anchor = AnchorStyles.None;
        NDqe.AutoSize = true;
        NDqe.Location = new Point(Class13.LpZ7, Class13.HpZP);
        NDqe.Name = Class13.SpZi;
        NDqe.Size = new Size(Class13.ApZm, Class13.LpZ0);
        NDqe.TabIndex = Class13.LpZI;
        CDq8.Anchor = AnchorStyles.None;
        CDq8.AutoSize = true;
        CDq8.Location = new Point(Class13.rpZR, 1);
        CDq8.Name = Class13.epZC;
        CDq8.Size = new Size(Class13.opZK, Class13.LpZU);
        CDq8.TabIndex = 2;
        bDqn.Anchor = AnchorStyles.None;
        bDqn.AutoSize = true;
        bDqn.Enabled = false;
        bDqn.Location = new Point(Class13.qpZT, Class13.RpZ1);
        bDqn.Name = Class13.MpZW;
        bDqn.Size = new Size(Class13.upZw, Class13.vpZN);
        bDqn.TabIndex = Class13.mpZY;
        bDqn.UseVisualStyleBackColor = true;
        aDqQ.Anchor = AnchorStyles.None;
        aDqQ.AutoSize = true;
        aDqQ.Location = new Point(3, Class13.opZB);
        aDqQ.Name = Class13.JpZA;
        aDqQ.Size = new Size(Class13.BpZf, Class13.jpZ6);
        aDqQ.TabIndex = 7;
        XDqF.Anchor = AnchorStyles.None;
        XDqF.AutoSize = true;
        XDqF.Enabled = false;
        XDqF.Location = new Point(Class13.DpZx, Class13.lpZ9);
        XDqF.Name = Class13.ypZc;
        XDqF.Size = new Size(Class13.GpZy, Class13.mpZr);
        XDqF.TabIndex = Class13.jpZq;
        XDqF.UseVisualStyleBackColor = true;
        eDqL.Anchor = AnchorStyles.None;
        eDqL.AutoSize = true;
        eDqL.Location = new Point(Class13.ipZk, Class13.FpZM);
        eDqL.Name = Class13.WpZu;
        eDqL.Size = new Size(Class13.RpZg, Class13.upZ2);
        eDqL.TabIndex = Class13.CpZ3;
        oDqJ.Anchor = AnchorStyles.None;
        oDqJ.AutoSize = true;
        oDqJ.Location = new Point(Class13.KpZd, Class13.hpZH);
        oDqJ.Name = Class13.xpZ4;
        oDqJ.Size = new Size(Class13.UpZ5, Class13.YpZs);
        oDqJ.TabIndex = 6;
        eDq7.Anchor = AnchorStyles.None;
        eDq7.AutoSize = true;
        eDq7.Location = new Point(Class13.PpZZ, Class13.dpZa);
        eDq7.Name = Class13.PpZj;
        eDq7.Size = new Size(Class13.bpZz, Class13.YpaE);
        eDq7.TabIndex = Class13.UpaD;
        ADqP.Anchor = AnchorStyles.None;
        ADqP.AutoSize = true;
        ADqP.Location = new Point(Class13.JpaX, Class13.wpap);
        ADqP.Name = Class13.jpaS;
        ADqP.Size = new Size(Class13.Gpah, Class13.jpal);
        ADqP.TabIndex = 4;
        pDqi.Anchor = AnchorStyles.None;
        pDqi.AutoSize = true;
        pDqi.Enabled = false;
        pDqi.Location = new Point(Class13.xpaG, Class13.xpab);
        pDqi.Name = Class13.Hpav;
        pDqi.Size = new Size(Class13.rpao, Class13.Vpat);
        pDqi.TabIndex = Class13.qpaV;
        pDqi.UseVisualStyleBackColor = true;
        wDqm.Anchor = AnchorStyles.None;
        wDqm.AutoSize = true;
        wDqm.Location = new Point(Class13.EpaO, Class13.Epae);
        wDqm.Name = Class13.zpa8;
        wDqm.Size = new Size(Class13.zpan, Class13.upaQ);
        wDqm.TabIndex = Class13.PpaF;
        aDq0.Anchor = AnchorStyles.None;
        aDq0.AutoSize = true;
        aDq0.Location = new Point(8, Class13.HpaL);
        aDq0.Name = Class13.lpaJ;
        aDq0.Size = new Size(Class13.qpa7, Class13.QpaP);
        aDq0.TabIndex = 0;
        tDqI.Anchor = AnchorStyles.None;
        tDqI.AutoSize = true;
        tDqI.Location = new Point(Class13.cpai, Class13.opam);
        tDqI.Name = Class13.Xpa0;
        tDqI.Size = new Size(Class13.rpaI, Class13.dpaR);
        tDqI.TabIndex = Class13.vpaC;
        YDqR.Anchor = AnchorStyles.None;
        YDqR.AutoSize = true;
        YDqR.Enabled = false;
        YDqR.Location = new Point(Class13.rpaK, 3);
        YDqR.Name = Class13.spaU;
        YDqR.Size = new Size(Class13.zpaT, Class13.epa1);
        YDqR.TabIndex = Class13.ypaW;
        YDqR.UseVisualStyleBackColor = true;
        fDqC.Anchor = AnchorStyles.None;
        fDqC.AutoSize = true;
        fDqC.Location = new Point(Class13.mpaw, Class13.tpaN);
        fDqC.Name = Class13.ipaY;
        fDqC.Size = new Size(Class13.IpaB, Class13.xpaA);
        fDqC.TabIndex = 8;
        jDqK.Anchor = AnchorStyles.None;
        jDqK.AutoSize = true;
        jDqK.Location = new Point(Class13.mpaf, Class13.Npa6);
        jDqK.Name = Class13.xpax;
        jDqK.Size = new Size(Class13.Gpa9, Class13.Spac);
        jDqK.TabIndex = 1;
        kDqU.Anchor = AnchorStyles.None;
        kDqU.AutoSize = true;
        kDqU.Enabled = false;
        kDqU.Location = new Point(Class13.Qpay, Class13.Rpar);
        kDqU.Name = Class13.lpaq;
        kDqU.Size = new Size(Class13.zpak, Class13.spaM);
        kDqU.TabIndex = Class13.dpau;
        kDqU.UseVisualStyleBackColor = true;
        pDqT.Anchor = AnchorStyles.None;
        pDqT.AutoSize = true;
        pDqT.Location = new Point(Class13.jpag, Class13.wpa2);
        pDqT.Name = Class13.Mpa3;
        pDqT.Size = new Size(Class13.Opad, Class13.NpaH);
        pDqT.TabIndex = 3;
        ODq1.Anchor = AnchorStyles.None;
        ODq1.AutoSize = true;
        ODq1.Location = new Point(Class13.wpa4, Class13.Vpa5);
        ODq1.Name = Class13.ppas;
        ODq1.Size = new Size(Class13.GpaZ, Class13.Jpaa);
        ODq1.TabIndex = Class13.Npaj;
        tDqW.Anchor = AnchorStyles.None;
        tDqW.AutoSize = true;
        tDqW.Location = new Point(Class13.Mpaz, Class13.PpjE);
        tDqW.Name = Class13.TpjD;
        tDqW.Size = new Size(Class13.MpjX, Class13.Spjp);
        tDqW.TabIndex = Class13.tpjS;
        QDqw.Anchor = AnchorStyles.None;
        QDqw.AutoSize = true;
        QDqw.Location = new Point(Class13.Kpjh, 1);
        QDqw.Name = Class13.Npjl;
        QDqw.Size = new Size(Class13.DpjG, Class13.Ppjb);
        QDqw.TabIndex = 5;
        base.AutoScaleDimensions = new SizeF(Class13.cpjv, Class13.Upjo);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(Class13.opjt, Class13.hpjV);
        base.Controls.Add(YDTN);
        base.Controls.Add(qDTw);
        base.Controls.Add(fDTE);
        base.Controls.Add(QDTD);
        base.Controls.Add(YDTX);
        base.Controls.Add(RDTO);
        base.Controls.Add(yDTi);
        base.Controls.Add(wDTR);
        base.Controls.Add(sDTC);
        base.Controls.Add(QDTK);
        base.Controls.Add(GDwt);
        base.Controls.Add(cDTU);
        base.FormBorderStyle = FormBorderStyle.Fixed3D;
        base.Icon = (Icon)componentResourceManager.GetObject(Class13.HpjO);
        base.MaximizeBox = false;
        base.Name = Class13.xpje;
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = Class13.ypj8;
        YDTX.ResumeLayout(performLayout: false);
        YDTX.PerformLayout();
        RDTO.ResumeLayout(performLayout: false);
        RDTO.PerformLayout();
        yDTi.ResumeLayout(performLayout: false);
        cDTU.ResumeLayout(performLayout: false);
        cDTU.PerformLayout();
        qDTw.ResumeLayout(performLayout: false);
        qDTw.PerformLayout();
        YDTN.ResumeLayout(performLayout: false);
        YDTN.PerformLayout();
        jDTB.ResumeLayout(performLayout: false);
        MDTA.ResumeLayout(performLayout: false);
        wDT9.ResumeLayout(performLayout: false);
        QDTc.ResumeLayout(performLayout: false);
        NDTr.ResumeLayout(performLayout: false);
        BDTk.ResumeLayout(performLayout: false);
        oDBR.ResumeLayout(performLayout: false);
        IDBC.ResumeLayout(performLayout: false);
        tDBY.ResumeLayout(performLayout: false);
        kDwP.ResumeLayout(performLayout: false);
        lDwV.ResumeLayout(performLayout: false);
        YDTM.ResumeLayout(performLayout: false);
        xDTd.ResumeLayout(performLayout: false);
        xDTd.PerformLayout();
        lD1E.ResumeLayout(performLayout: false);
        LDA2.ResumeLayout(performLayout: false);
        pDA3.ResumeLayout(performLayout: false);
        DDAd.ResumeLayout(performLayout: false);
        JDfv.ResumeLayout(performLayout: false);
        cDfO.ResumeLayout(performLayout: false);
        TDAZ.ResumeLayout(performLayout: false);
        CD6L.ResumeLayout(performLayout: false);
        AD6J.ResumeLayout(performLayout: false);
        uD6Q.ResumeLayout(performLayout: false);
        kD6n.ResumeLayout(performLayout: false);
        GD68.ResumeLayout(performLayout: false);
        PD6e.ResumeLayout(performLayout: false);
        GD6O.ResumeLayout(performLayout: false);
        zD6V.ResumeLayout(performLayout: false);
        mDw1.ResumeLayout(performLayout: false);
        rDwk.ResumeLayout(performLayout: false);
        TDwM.ResumeLayout(performLayout: false);
        fDfY.ResumeLayout(performLayout: false);
        qDfr.ResumeLayout(performLayout: false);
        vDw4.ResumeLayout(performLayout: false);
        oDwu.ResumeLayout(performLayout: false);
        LDBt.ResumeLayout(performLayout: false);
        LDBh.ResumeLayout(performLayout: false);
        IDBD.ResumeLayout(performLayout: false);
        TDYa.ResumeLayout(performLayout: false);
        hDNd.ResumeLayout(performLayout: false);
        eDwj.ResumeLayout(performLayout: false);
        qDY5.ResumeLayout(performLayout: false);
        ((ISupportInitialize)LDYZ).EndInit();
        dDY3.ResumeLayout(performLayout: false);
        ((ISupportInitialize)xDY4).EndInit();
        qDYT.ResumeLayout(performLayout: false);
        ((ISupportInitialize)GDY1).EndInit();
        gDY0.ResumeLayout(performLayout: false);
        ((ISupportInitialize)kDYK).EndInit();
        QDY7.ResumeLayout(performLayout: false);
        ((ISupportInitialize)HDYi).EndInit();
        EDYV.ResumeLayout(performLayout: false);
        ((ISupportInitialize)SDYe).EndInit();
        FDYD.ResumeLayout(performLayout: false);
        ((ISupportInitialize)qDYl).EndInit();
        CDN4.ResumeLayout(performLayout: false);
        ((ISupportInitialize)IDN5).EndInit();
        qDwz.ResumeLayout(performLayout: false);
        wDBO.ResumeLayout(performLayout: false);
        aDNq.ResumeLayout(performLayout: false);
        FDN6.ResumeLayout(performLayout: false);
        ADNw.ResumeLayout(performLayout: false);
        NDNp.ResumeLayout(performLayout: false);
        IDAk.ResumeLayout(performLayout: false);
        OD6K.ResumeLayout(performLayout: false);
        PD6r.ResumeLayout(performLayout: false);
        WD6U.ResumeLayout(performLayout: false);
        WD6U.PerformLayout();
        oD18.ResumeLayout(performLayout: false);
        iD1n.ResumeLayout(performLayout: false);
        kD1Q.ResumeLayout(performLayout: false);
        kD1Q.PerformLayout();
        xDA0.ResumeLayout(performLayout: false);
        xDA0.PerformLayout();
        ((ISupportInitialize)BDAB).EndInit();
        MDAR.ResumeLayout(performLayout: false);
        MDAR.PerformLayout();
        ((ISupportInitialize)bDAK).EndInit();
        CDAi.ResumeLayout(performLayout: false);
        vDBk.ResumeLayout(performLayout: false);
        xDBM.ResumeLayout(performLayout: false);
        ((ISupportInitialize)oD1L).EndInit();
        ((ISupportInitialize)vD1J).EndInit();
        hD17.ResumeLayout(performLayout: false);
        hD17.PerformLayout();
        hD11.ResumeLayout(performLayout: false);
        oD1W.ResumeLayout(performLayout: false);
        hD1w.ResumeLayout(performLayout: false);
        kD1Y.ResumeLayout(performLayout: false);
        JD1A.ResumeLayout(performLayout: false);
        aD16.ResumeLayout(performLayout: false);
        tD19.ResumeLayout(performLayout: false);
        TD1y.ResumeLayout(performLayout: false);
        HD1q.ResumeLayout(performLayout: false);
        eD1M.ResumeLayout(performLayout: false);
        xD1g.ResumeLayout(performLayout: false);
        ED13.ResumeLayout(performLayout: false);
        LD1H.ResumeLayout(performLayout: false);
        aD15.ResumeLayout(performLayout: false);
        YD1Z.ResumeLayout(performLayout: false);
        BD1j.ResumeLayout(performLayout: false);
        tDWE.ResumeLayout(performLayout: false);
        aDWX.ResumeLayout(performLayout: false);
        TDBg.ResumeLayout(performLayout: false);
        sDB2.ResumeLayout(performLayout: false);
        bDB3.ResumeLayout(performLayout: false);
        aDBH.ResumeLayout(performLayout: false);
        hDB5.ResumeLayout(performLayout: false);
        tDBZ.ResumeLayout(performLayout: false);
        BDBj.ResumeLayout(performLayout: false);
        vDAE.ResumeLayout(performLayout: false);
        gDAX.ResumeLayout(performLayout: false);
        mDAS.ResumeLayout(performLayout: false);
        JDAl.ResumeLayout(performLayout: false);
        pDAb.ResumeLayout(performLayout: false);
        HDAo.ResumeLayout(performLayout: false);
        MDAV.ResumeLayout(performLayout: false);
        gDAe.ResumeLayout(performLayout: false);
        IDAn.ResumeLayout(performLayout: false);
        UDAF.ResumeLayout(performLayout: false);
        QDAJ.ResumeLayout(performLayout: false);
        mDWS.ResumeLayout(performLayout: false);
        aDWh.ResumeLayout(performLayout: false);
        iDWl.ResumeLayout(performLayout: false);
        QDNi.ResumeLayout(performLayout: false);
        PDNm.ResumeLayout(performLayout: false);
        jDN0.ResumeLayout(performLayout: false);
        yDNI.ResumeLayout(performLayout: false);
        kDNS.ResumeLayout(performLayout: false);
        kDNS.PerformLayout();
        ((ISupportInitialize)PDNT).EndInit();
        ((ISupportInitialize)dDN1).EndInit();
        ((ISupportInitialize)gDNW).EndInit();
        FDWG.ResumeLayout(performLayout: false);
        LDww.ResumeLayout(performLayout: false);
        LDww.PerformLayout();
        ((ISupportInitialize)UDw9).EndInit();
        EDWb.ResumeLayout(performLayout: false);
        iDWv.ResumeLayout(performLayout: false);
        iDWv.PerformLayout();
        DDWO.ResumeLayout(performLayout: false);
        aDWJ.ResumeLayout(performLayout: false);
        aDWJ.PerformLayout();
        DDWC.ResumeLayout(performLayout: false);
        DDWC.PerformLayout();
        ((ISupportInitialize)NDWU).EndInit();
        GDW9.ResumeLayout(performLayout: false);
        KDWq.ResumeLayout(performLayout: false);
        JDW2.ResumeLayout(performLayout: false);
        rDWH.ResumeLayout(performLayout: false);
        rDWH.PerformLayout();
        nDwE.ResumeLayout(performLayout: false);
        nDwE.PerformLayout();
        ((ISupportInitialize)UDwD).EndInit();
        ((ISupportInitialize)sDwl).EndInit();
        ((ISupportInitialize)EDwb).EndInit();
        ((ISupportInitialize)mDwo).EndInit();
        GDwt.ResumeLayout(performLayout: false);
        uDxp.ResumeLayout(performLayout: false);
        uDxp.PerformLayout();
        iD6Z.ResumeLayout(performLayout: false);
        ((ISupportInitialize)VDxJ).EndInit();
        ((ISupportInitialize)sDx7).EndInit();
        ((ISupportInitialize)WDxP).EndInit();
        ((ISupportInitialize)yDxi).EndInit();
        ((ISupportInitialize)jDxm).EndInit();
        ((ISupportInitialize)aDx0).EndInit();
        ((ISupportInitialize)TDxN).EndInit();
        ((ISupportInitialize)PDxY).EndInit();
        ((ISupportInitialize)zDxB).EndInit();
        ((ISupportInitialize)pDxA).EndInit();
        ((ISupportInitialize)JDxf).EndInit();
        ((ISupportInitialize)KDx6).EndInit();
        ((ISupportInitialize)LDxx).EndInit();
        ((ISupportInitialize)UDx9).EndInit();
        ((ISupportInitialize)DDxc).EndInit();
        ((ISupportInitialize)IDxy).EndInit();
        ((ISupportInitialize)GDxk).EndInit();
        ((ISupportInitialize)MDxM).EndInit();
        ((ISupportInitialize)jDxu).EndInit();
        ((ISupportInitialize)DDxg).EndInit();
        ((ISupportInitialize)CDxZ).EndInit();
        ((ISupportInitialize)BDxa).EndInit();
        ((ISupportInitialize)iDxj).EndInit();
        ((ISupportInitialize)YDxz).EndInit();
        ((ISupportInitialize)wD9E).EndInit();
        ((ISupportInitialize)fD9D).EndInit();
        ((ISupportInitialize)uD9X).EndInit();
        ((ISupportInitialize)DD9p).EndInit();
        ((ISupportInitialize)RD9S).EndInit();
        ((ISupportInitialize)LD9h).EndInit();
        ((ISupportInitialize)LD9l).EndInit();
        ((ISupportInitialize)cD9G).EndInit();
        ResumeLayout(performLayout: false);
        PerformLayout();
    }
}