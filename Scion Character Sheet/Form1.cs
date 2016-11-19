using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Scion_Character_Sheet
{
    public partial class Form1 : Form
    {
        int attributeStrength;
        int attributeEpicStrength;
        List<RadioButton> listStrength = new List<RadioButton>();
        List<CheckBox> listEpicStrength = new List<CheckBox>();

        int attributeDexterity;
        int attributeEpicDexterity;
        List<RadioButton> listDexterity = new List<RadioButton>();
        List<CheckBox> listEpicDexterity = new List<CheckBox>();

        int attributeStamina;
        int attributeEpicStamina;
        List<RadioButton> listStamina = new List<RadioButton>();
        List<CheckBox> listEpicStamina = new List<CheckBox>();

        int attributeCharisma;
        int attributeEpicCharisma;
        List<RadioButton> listCharisma = new List<RadioButton>();
        List<CheckBox> listEpicCharisma = new List<CheckBox>();

        int attributeManipulation;
        int attributeEpicManipulation;
        List<RadioButton> listManipulation = new List<RadioButton>();
        List<CheckBox> listEpicManipulation = new List<CheckBox>();

        int attributeAppearance;
        int attributeEpicAppearance;
        List<RadioButton> listAppearance = new List<RadioButton>();
        List<CheckBox> listEpicAppearance = new List<CheckBox>();

        int attributePerception;
        int attributeEpicPerception;
        List<RadioButton> listPerception = new List<RadioButton>();
        List<CheckBox> listEpicPerception = new List<CheckBox>();

        int attributeIntelligence;
        int attributeEpicIntelligence;
        List<RadioButton> listIntelligence = new List<RadioButton>();
        List<CheckBox> listEpicIntelligence = new List<CheckBox>();

        int attributeWits;
        int attributeEpicWits;
        List<RadioButton> listWits = new List<RadioButton>();
        List<CheckBox> listEpicWits = new List<CheckBox>();


        public class abilityInfo
        {
            public int rank { get; set; }
            public bool favored { get; set; }
            public List<RadioButton> radios { get; set; }
            public CheckBox favoredCheckbox { get; set; }

            public abilityInfo(int rank, bool favored, List<RadioButton> radios, ref CheckBox favoredCheckbox)
            {
                this.rank = rank;
                this.favored = favored;
                this.radios = radios;
                this.favoredCheckbox = favoredCheckbox;
            }

        }
        Dictionary<string, abilityInfo> abilityInformation = new Dictionary<string, abilityInfo>();
        Dictionary<string, string> abilityTags = new Dictionary<string, string>
        {
            {"art1",""},
            {"art2",""},
            {"control1",""},
            {"control2",""},
            {"craft1",""},
            {"craft2",""},
            {"craft3",""},
            {"science1",""},
            {"science2",""},
            {"science3",""},
        };

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listStrength.Add(radioStr01);
            listStrength.Add(radioStr02);
            listStrength.Add(radioStr03);
            listStrength.Add(radioStr04);
            listStrength.Add(radioStr05);
            listStrength.Add(radioStr06);
            listStrength.Add(radioStr07);
            listStrength.Add(radioStr08);
            listStrength.Add(radioStr09);
            listStrength.Add(radioStr10);
            listEpicStrength.Add(chkEst01);
            listEpicStrength.Add(chkEst02);
            listEpicStrength.Add(chkEst03);
            listEpicStrength.Add(chkEst04);
            listEpicStrength.Add(chkEst05);
            listEpicStrength.Add(chkEst06);
            listEpicStrength.Add(chkEst07);
            listEpicStrength.Add(chkEst08);
            listEpicStrength.Add(chkEst09);
            listEpicStrength.Add(chkEst10);

            listDexterity.Add(radioDex01);
            listDexterity.Add(radioDex02);
            listDexterity.Add(radioDex03);
            listDexterity.Add(radioDex04);
            listDexterity.Add(radioDex05);
            listDexterity.Add(radioDex06);
            listDexterity.Add(radioDex07);
            listDexterity.Add(radioDex08);
            listDexterity.Add(radioDex09);
            listDexterity.Add(radioDex10);
            listEpicDexterity.Add(chkEde01);
            listEpicDexterity.Add(chkEde02);
            listEpicDexterity.Add(chkEde03);
            listEpicDexterity.Add(chkEde04);
            listEpicDexterity.Add(chkEde05);
            listEpicDexterity.Add(chkEde06);
            listEpicDexterity.Add(chkEde07);
            listEpicDexterity.Add(chkEde08);
            listEpicDexterity.Add(chkEde09);
            listEpicDexterity.Add(chkEde10);

            listStamina.Add(radioSta01);
            listStamina.Add(radioSta02);
            listStamina.Add(radioSta03);
            listStamina.Add(radioSta04);
            listStamina.Add(radioSta05);
            listStamina.Add(radioSta06);
            listStamina.Add(radioSta07);
            listStamina.Add(radioSta08);
            listStamina.Add(radioSta09);
            listStamina.Add(radioSta10);
            listEpicStamina.Add(chkEsa01);
            listEpicStamina.Add(chkEsa02);
            listEpicStamina.Add(chkEsa03);
            listEpicStamina.Add(chkEsa04);
            listEpicStamina.Add(chkEsa05);
            listEpicStamina.Add(chkEsa06);
            listEpicStamina.Add(chkEsa07);
            listEpicStamina.Add(chkEsa08);
            listEpicStamina.Add(chkEsa09);
            listEpicStamina.Add(chkEsa10);

            listCharisma.Add(radioCha01);
            listCharisma.Add(radioCha02);
            listCharisma.Add(radioCha03);
            listCharisma.Add(radioCha04);
            listCharisma.Add(radioCha05);
            listCharisma.Add(radioCha06);
            listCharisma.Add(radioCha07);
            listCharisma.Add(radioCha08);
            listCharisma.Add(radioCha09);
            listCharisma.Add(radioCha10);
            listEpicCharisma.Add(chkECh01);
            listEpicCharisma.Add(chkECh02);
            listEpicCharisma.Add(chkECh03);
            listEpicCharisma.Add(chkECh04);
            listEpicCharisma.Add(chkECh05);
            listEpicCharisma.Add(chkECh06);
            listEpicCharisma.Add(chkECh07);
            listEpicCharisma.Add(chkECh08);
            listEpicCharisma.Add(chkECh09);
            listEpicCharisma.Add(chkECh10);

            listManipulation.Add(radioMan01);
            listManipulation.Add(radioMan02);
            listManipulation.Add(radioMan03);
            listManipulation.Add(radioMan04);
            listManipulation.Add(radioMan05);
            listManipulation.Add(radioMan06);
            listManipulation.Add(radioMan07);
            listManipulation.Add(radioMan08);
            listManipulation.Add(radioMan09);
            listManipulation.Add(radioMan10);
            listEpicManipulation.Add(chkEMa01);
            listEpicManipulation.Add(chkEMa02);
            listEpicManipulation.Add(chkEMa03);
            listEpicManipulation.Add(chkEMa04);
            listEpicManipulation.Add(chkEMa05);
            listEpicManipulation.Add(chkEMa06);
            listEpicManipulation.Add(chkEMa07);
            listEpicManipulation.Add(chkEMa08);
            listEpicManipulation.Add(chkEMa09);
            listEpicManipulation.Add(chkEMa10);

            listAppearance.Add(radioApp01);
            listAppearance.Add(radioApp02);
            listAppearance.Add(radioApp03);
            listAppearance.Add(radioApp04);
            listAppearance.Add(radioApp05);
            listAppearance.Add(radioApp06);
            listAppearance.Add(radioApp07);
            listAppearance.Add(radioApp08);
            listAppearance.Add(radioApp09);
            listAppearance.Add(radioApp10);
            listEpicAppearance.Add(chkEAp01);
            listEpicAppearance.Add(chkEAp02);
            listEpicAppearance.Add(chkEAp03);
            listEpicAppearance.Add(chkEAp04);
            listEpicAppearance.Add(chkEAp05);
            listEpicAppearance.Add(chkEAp06);
            listEpicAppearance.Add(chkEAp07);
            listEpicAppearance.Add(chkEAp08);
            listEpicAppearance.Add(chkEAp09);
            listEpicAppearance.Add(chkEAp10);

            listPerception.Add(radioPer01);
            listPerception.Add(radioPer02);
            listPerception.Add(radioPer03);
            listPerception.Add(radioPer04);
            listPerception.Add(radioPer05);
            listPerception.Add(radioPer06);
            listPerception.Add(radioPer07);
            listPerception.Add(radioPer08);
            listPerception.Add(radioPer09);
            listPerception.Add(radioPer10);
            listEpicPerception.Add(chkEpe01);
            listEpicPerception.Add(chkEpe02);
            listEpicPerception.Add(chkEpe03);
            listEpicPerception.Add(chkEpe04);
            listEpicPerception.Add(chkEpe05);
            listEpicPerception.Add(chkEpe06);
            listEpicPerception.Add(chkEpe07);
            listEpicPerception.Add(chkEpe08);
            listEpicPerception.Add(chkEpe09);
            listEpicPerception.Add(chkEpe10);

            listIntelligence.Add(radioInt01);
            listIntelligence.Add(radioInt02);
            listIntelligence.Add(radioInt03);
            listIntelligence.Add(radioInt04);
            listIntelligence.Add(radioInt05);
            listIntelligence.Add(radioInt06);
            listIntelligence.Add(radioInt07);
            listIntelligence.Add(radioInt08);
            listIntelligence.Add(radioInt09);
            listIntelligence.Add(radioInt10);
            listEpicIntelligence.Add(chkEin01);
            listEpicIntelligence.Add(chkEin02);
            listEpicIntelligence.Add(chkEin03);
            listEpicIntelligence.Add(chkEin04);
            listEpicIntelligence.Add(chkEin05);
            listEpicIntelligence.Add(chkEin06);
            listEpicIntelligence.Add(chkEin07);
            listEpicIntelligence.Add(chkEin08);
            listEpicIntelligence.Add(chkEin09);
            listEpicIntelligence.Add(chkEin10);

            listWits.Add(radioWit01);
            listWits.Add(radioWit02);
            listWits.Add(radioWit03);
            listWits.Add(radioWit04);
            listWits.Add(radioWit05);
            listWits.Add(radioWit06);
            listWits.Add(radioWit07);
            listWits.Add(radioWit08);
            listWits.Add(radioWit09);
            listWits.Add(radioWit10);
            listEpicWits.Add(chkEwi01);
            listEpicWits.Add(chkEwi02);
            listEpicWits.Add(chkEwi03);
            listEpicWits.Add(chkEwi04);
            listEpicWits.Add(chkEwi05);
            listEpicWits.Add(chkEwi06);
            listEpicWits.Add(chkEwi07);
            listEpicWits.Add(chkEwi08);
            listEpicWits.Add(chkEwi09);
            listEpicWits.Add(chkEwi10);

            abilityInformation.Add("academics", new abilityInfo(0, false, new List<RadioButton>() { radioAcademics1, radioAcademics2, radioAcademics3, radioAcademics4, radioAcademics5 }, ref chkAcademics));
            abilityInformation.Add("animalken", new abilityInfo(0, false, new List<RadioButton>() { radioAnimalKen1, radioAnimalKen2, radioAnimalKen3, radioAnimalKen4, radioAnimalKen5 }, ref chkAnimalKen));
            abilityInformation.Add("art1", new abilityInfo(0, false, new List<RadioButton>() { radioArt11, radioArt12, radioArt13, radioArt14, radioArt15 }, ref chkArt1));
            abilityInformation.Add("art2", new abilityInfo(0, false, new List<RadioButton>() { radioArt21, radioArt22, radioArt23, radioArt24, radioArt25 }, ref chkArt2));
            abilityInformation.Add("athletics", new abilityInfo(0, false, new List<RadioButton>() { radioAthletics1, radioAthletics2, radioAthletics3, radioAthletics4, radioAthletics5 }, ref chkAthletics));
            abilityInformation.Add("awareness", new abilityInfo(0, false, new List<RadioButton>() { radioAwareness1, radioAwareness2, radioAwareness3, radioAwareness4, radioAwareness5 }, ref chkAwareness));
            abilityInformation.Add("brawl", new abilityInfo(0, false, new List<RadioButton>() { radioBrawl1, radioBrawl2, radioBrawl3, radioBrawl4, radioBrawl5 }, ref chkBrawl));
            abilityInformation.Add("command", new abilityInfo(0, false, new List<RadioButton>() { radioCommand1, radioCommand2, radioCommand3, radioCommand4, radioCommand5 }, ref chkCommand));
            abilityInformation.Add("control1", new abilityInfo(0, false, new List<RadioButton>() { radioControl11, radioControl12, radioControl13, radioControl14, radioControl15 }, ref chkControl1));
            abilityInformation.Add("control2", new abilityInfo(0, false, new List<RadioButton>() { radioControl21, radioControl22, radioControl23, radioControl24, radioControl25 }, ref chkControl2));
            abilityInformation.Add("craft1", new abilityInfo(0, false, new List<RadioButton>() { radioCraft11, radioCraft12, radioCraft13, radioCraft14, radioCraft15 }, ref chkCraft1));
            abilityInformation.Add("craft2", new abilityInfo(0, false, new List<RadioButton>() { radioCraft21, radioCraft22, radioCraft23, radioCraft24, radioCraft25 }, ref chkCraft2));
            abilityInformation.Add("craft3", new abilityInfo(0, false, new List<RadioButton>() { radioCraft31, radioCraft32, radioCraft33, radioCraft34, radioCraft35 }, ref chkCraft3));
            abilityInformation.Add("empathy", new abilityInfo(0, false, new List<RadioButton>() { radioEmpathy1, radioEmpathy2, radioEmpathy3, radioEmpathy4, radioEmpathy5 }, ref chkEmpathy));
            abilityInformation.Add("fortitude", new abilityInfo(0, false, new List<RadioButton>() { radioFortitude1, radioFortitude2, radioFortitude3, radioFortitude4, radioFortitude5 }, ref chkFortitude));
            abilityInformation.Add("integrity", new abilityInfo(0, false, new List<RadioButton>() { radioIntegrity1, radioIntegrity2, radioIntegrity3, radioIntegrity4, radioIntegrity5 }, ref chkIntegrity));
            abilityInformation.Add("investigation", new abilityInfo(0, false, new List<RadioButton>() { radioInvestigation1, radioInvestigation2, radioInvestigation3, radioInvestigation4, radioInvestigation5 }, ref chkInvestigation));
            abilityInformation.Add("larceny", new abilityInfo(0, false, new List<RadioButton>() { radioLarceny1, radioLarceny2, radioLarceny3, radioLarceny4, radioLarceny5 }, ref chkLarceny));
            abilityInformation.Add("marksmanship", new abilityInfo(0, false, new List<RadioButton>() { radioMarksmanship1, radioMarksmanship2, radioMarksmanship3, radioMarksmanship4, radioMarksmanship5 }, ref chkMarksmanship));
            abilityInformation.Add("medicine", new abilityInfo(0, false, new List<RadioButton>() { radioMedicine1, radioMedicine2, radioMedicine3, radioMedicine4, radioMedicine5 }, ref chkMedicine));
            abilityInformation.Add("melee", new abilityInfo(0, false, new List<RadioButton>() { radioMelee1, radioMelee2, radioMelee3, radioMelee4, radioMelee5 }, ref chkMelee));
            abilityInformation.Add("occult", new abilityInfo(0, false, new List<RadioButton>() { radioOccult1, radioOccult2, radioOccult3, radioOccult4, radioOccult5 }, ref chkOccult));
            abilityInformation.Add("politics", new abilityInfo(0, false, new List<RadioButton>() { radioPolitics1, radioPolitics2, radioPolitics3, radioPolitics4, radioPolitics5 }, ref chkPolitics));
            abilityInformation.Add("presence", new abilityInfo(0, false, new List<RadioButton>() { radioPresence1, radioPresence2, radioPresence3, radioPresence4, radioPresence5 }, ref chkPresence));
            abilityInformation.Add("science1", new abilityInfo(0, false, new List<RadioButton>() { radioScience11, radioScience12, radioScience13, radioScience14, radioScience15 }, ref chkScience1));
            abilityInformation.Add("science2", new abilityInfo(0, false, new List<RadioButton>() { radioScience21, radioScience22, radioScience23, radioScience24, radioScience25 }, ref chkScience2));
            abilityInformation.Add("science3", new abilityInfo(0, false, new List<RadioButton>() { radioScience31, radioScience32, radioScience33, radioScience34, radioScience35 }, ref chkScience3));
            abilityInformation.Add("stealth", new abilityInfo(0, false, new List<RadioButton>() { radioStealth1, radioStealth2, radioStealth3, radioStealth4, radioStealth5 }, ref chkStealth));
            abilityInformation.Add("survival", new abilityInfo(0, false, new List<RadioButton>() { radioSurvival1, radioSurvival2, radioSurvival3, radioSurvival4, radioSurvival5 }, ref chkSurvival));
            abilityInformation.Add("thrown", new abilityInfo(0, false, new List<RadioButton>() { radioThrown1, radioThrown2, radioThrown3, radioThrown4, radioThrown5 }, ref chkThrown));
        }
        private void setAbilityRank(object sender, EventArgs e)
        {
            int value = 0;
            string identifier = "";
            int oldValue = 0;
            RadioButton val = (RadioButton)sender;
            Int32.TryParse(val.Name.Substring(val.Name.Length - 1), out value);
            identifier = val.Name.Substring(5, val.Name.Length - 6).ToLower();
            oldValue = abilityInformation[identifier].rank;
            if (oldValue == 1 & value == 1)
            {
                value = 0;
            }
            abilityInformation[identifier].rank = value;
            for (int i = 0; i < abilityInformation[identifier].radios.Count; i++)
            {
                abilityInformation[identifier].radios[i].Checked = (i + 1 <= abilityInformation[identifier].rank);
            }
        }

        private void setAbilityFavored(object sender, EventArgs e)
        {
            CheckBox val = (CheckBox)sender;
            string identifier = val.Name.Substring(3, val.Name.Length - 3).ToLower();
            abilityInformation[identifier].favored = val.Checked;
        }

        private void setAttribute(object sender, EventArgs e)
        {
            int value = 0;
            int oldEpic;
            string identifier = "";

            // Code determines if the object is a checkbox or radio button. This also is a decent hacky way to identify them as normal or epic stats
            if(sender is RadioButton)
            {
                RadioButton val = (RadioButton)sender;
                Int32.TryParse(val.Name.Substring(val.Name.Length-2),out value);
                identifier = val.Name.Substring(val.Name.Length - 5, 3);
            }
            else if (sender is CheckBox)
            {
                CheckBox val = (CheckBox)sender;
                Int32.TryParse(val.Name.Substring(val.Name.Length - 2), out value);
                identifier = val.Name.Substring(val.Name.Length - 5, 3);
            }
            // This was before I discovered I could simplify it to use dictionaries and custom classes for multideminsional array type objects
            switch (identifier.ToLower())
            {
                case "str":
                    attributeStrength = value;
                    setStandardAttribute(value, ref listStrength);
                    break;
                case "est":
                    oldEpic = attributeEpicStrength;
                    attributeEpicStrength = value;
                    if (value == 1 & oldEpic == 1)
                    {
                        value = 0;
                    }
                    setStandardAttribute(value, ref listEpicStrength, ref labelStrengthSuccesses);
                    break;
                case "dex":
                    attributeDexterity = value;
                    setStandardAttribute(value, ref listDexterity);
                    break;
                case "ede":
                    oldEpic = attributeEpicDexterity;
                    attributeEpicDexterity = value;
                    if (value == 1 & oldEpic == 1)
                    {
                        value = 0;
                    }
                    setStandardAttribute(value, ref listEpicDexterity, ref labelDexteritySuccesses);
                    break;
                case "sta":
                    attributeStamina = value;
                    setStandardAttribute(value, ref listStamina);
                    break;
                case "esa":
                    oldEpic = attributeEpicStamina;
                    attributeEpicStamina = value;
                    if (value == 1 & oldEpic == 1)
                    {
                        value = 0;
                    }
                    setStandardAttribute(value, ref listEpicStamina, ref labelStaminaSuccesses);
                    break;
                case "cha":
                    attributeCharisma = value;
                    setStandardAttribute(value, ref listCharisma);
                    break;
                case "ech":
                    oldEpic = attributeEpicCharisma;
                    attributeEpicCharisma = value;
                    if (value == 1 & oldEpic == 1)
                    {
                        value = 0;
                    }
                    attributeEpicCharisma = value;
                    setStandardAttribute(value, ref listEpicCharisma, ref labelCharismaSuccesses);
                    break;
                case "man":
                    attributeManipulation = value;
                    setStandardAttribute(value, ref listManipulation);
                    break;
                case "ema":
                    oldEpic = attributeEpicManipulation;
                    attributeEpicManipulation = value;
                    if (value == 1 & oldEpic == 1)
                    {
                        value = 0;
                    }
                    attributeEpicManipulation = value;
                    setStandardAttribute(value, ref listEpicManipulation, ref labelManipulationSuccesses);
                    break;
                case "app":
                    attributeAppearance = value;
                    setStandardAttribute(value, ref listAppearance);
                    break;
                case "eap":
                    oldEpic = attributeEpicAppearance;
                    attributeEpicAppearance = value;
                    if (value == 1 & oldEpic == 1)
                    {
                        value = 0;
                    }
                    attributeEpicAppearance = value;
                    setStandardAttribute(value, ref listEpicAppearance, ref labelAppearanceSuccesses);
                    break;
                case "per":
                    attributePerception = value;
                    setStandardAttribute(value, ref listPerception);
                    break;
                case "epe":
                    oldEpic = attributeEpicPerception;
                    attributeEpicPerception = value;
                    if (value == 1 & oldEpic == 1)
                    {
                        value = 0;
                    }
                    attributeEpicPerception = value;
                    setStandardAttribute(value, ref listEpicPerception, ref labelPerceptionSuccesses);
                    break;
                case "int":
                    attributeIntelligence = value;
                    setStandardAttribute(value, ref listIntelligence);
                    break;
                case "ein":
                    oldEpic = attributeEpicIntelligence;
                    attributeEpicIntelligence = value;
                    if (value == 1 & oldEpic == 1)
                    {
                        value = 0;
                    }
                    attributeEpicIntelligence = value;
                    setStandardAttribute(value, ref listEpicIntelligence, ref labelIntelligenceSuccesses);
                    break;
                case "wit":
                    attributeWits = value;
                    setStandardAttribute(value, ref listWits);
                    break;
                case "ewi":
                    oldEpic = attributeEpicWits;
                    attributeEpicWits = value;
                    if (value == 1 & oldEpic == 1)
                    {
                        value = 0;
                    }
                    attributeEpicWits = value;
                    setStandardAttribute(value, ref listEpicWits, ref labelWitsSuccesses);
                    break;
            } 
        }

        private void setStandardAttribute(int value, ref List<RadioButton> listAttribute)
        {
            for (int i = 0; i < listAttribute.Count; i++)
            {
                listAttribute[i].Checked = (i + 1 <= value);
            }
        }

        private void setStandardAttribute(int value, ref List<CheckBox> listAttribute, ref Label labelSuccesses)
        {
            for (int i = 0; i < listAttribute.Count; i++)
            {
                listAttribute[i].Checked = (i + 1 <= value);
            }
            if (value != 0)
            {
                labelSuccesses.Text = (.5 * Math.Pow(value, 2) - .5 * value + 1).ToString();
            }
            else
            {
                labelSuccesses.Text = "0";
            }
        }

        private void groupAbilities_Enter(object sender, EventArgs e)
        {

        }

        private void setAbilityTag(object sender, EventArgs e)
        {
            string identifier = "";
            TextBox val = (TextBox)sender;
            identifier = val.Name.Substring(7, val.Name.Length - 7).ToLower();
            abilityTags[identifier] = val.Text;

        }
    }
}
