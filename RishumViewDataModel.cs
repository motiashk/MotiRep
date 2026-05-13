using System;
using System.Runtime.Serialization;

namespace MotiRep.DataModels
{
    [DataContract]
    public class RishumViewDataModel
    {
        [DataMember]
        [MappingColumnTo("moed_idkun_amit")]
        public virtual DateTime? moed_idkun_amit { get; set; }

        [DataMember]
        [MappingColumnTo("k_shnat_limud")]
        public virtual int k_shnat_limud { get; set; }

        [DataMember]
        [MappingColumnTo("ms_zehut")]
        public virtual int ms_zehut { get; set; }

        [DataMember]
        [MappingColumnTo("shem_mishpacha")]
        public virtual string shem_mishpacha { get; set; }

        [DataMember]
        [MappingColumnTo("shem_prati")]
        public virtual string shem_prati { get; set; }

        [DataMember]
        [MappingColumnTo("kita")]
        public virtual string kita { get; set; }

        [DataMember]
        [MappingColumnTo("teur_kita")]
        public virtual string teur_kita { get; set; }

        [DataMember]
        [MappingColumnTo("tr_leida")]
        public virtual string tr_leida { get; set; }

        [DataMember]
        [MappingColumnTo("k_min")]
        public virtual string k_min { get; set; }

        [DataMember]
        [MappingColumnTo("zehut_av")]
        public virtual string zehut_av { get; set; }

        [DataMember]
        [MappingColumnTo("shem_av")]
        public virtual string shem_av { get; set; }

        [DataMember]
        [MappingColumnTo("zehut_em")]
        public virtual string zehut_em { get; set; }

        [DataMember]
        [MappingColumnTo("shem_em")]
        public virtual string shem_em { get; set; }

        [DataMember]
        [MappingColumnTo("telefon_bait")]
        public virtual string telefon_bait { get; set; }

        [DataMember]
        [MappingColumnTo("telefon_nosaf")]
        public virtual string telefon_nosaf { get; set; }

        [DataMember]
        [MappingColumnTo("e_mail")]
        public virtual string e_mail { get; set; }

        [DataMember]
        [MappingColumnTo("ms_arnona")]
        public virtual string ms_arnona { get; set; }

        [DataMember]
        [MappingColumnTo("ms_cheshbon_choze")]
        public virtual string ms_cheshbon_choze { get; set; }

        [DataMember]
        [MappingColumnTo("semel_rechov")]
        public virtual string semel_rechov { get; set; }

        [DataMember]
        [MappingColumnTo("shem_rechov")]
        public virtual string shem_rechov { get; set; }

        [DataMember]
        [MappingColumnTo("ms_bayit")]
        public virtual string ms_bayit { get; set; }

        [DataMember]
        [MappingColumnTo("mikud")]
        public virtual string mikud { get; set; }

        [DataMember]
        [MappingColumnTo("k_yishuv")]
        public virtual string k_yishuv { get; set; }

        [DataMember]
        [MappingColumnTo("arnona_fektivit")]
        public virtual string arnona_fektivit { get; set; }

        [DataMember]
        [MappingColumnTo("k_maarechet")]
        public virtual string k_maarechet { get; set; }

        [DataMember]
        [MappingColumnTo("al_tnay_cm")]
        public virtual string al_tnay_cm { get; set; }

        [DataMember]
        [MappingColumnTo("deleted")]
        public virtual string deleted { get; set; }

        [DataMember]
        [MappingColumnTo("user_name")]
        public virtual string user_name { get; set; }

        [DataMember]
        [MappingColumnTo("moed_idkun")]
        public virtual string moed_idkun { get; set; }

        [DataMember]
        [MappingColumnTo("teur_shnat_limud_short")]
        public virtual string teur_shnat_limud_short { get; set; }

        [DataMember]
        [MappingColumnTo("rishum")]
        public virtual string rishum { get; set; }

        [DataMember]
        [MappingColumnTo("gan_1")]
        public virtual string gan_1 { get; set; }

        [DataMember]
        [MappingColumnTo("gan_1_shem_gan")]
        public virtual string gan_1_shem_gan { get; set; }

        [DataMember]
        [MappingColumnTo("gan_1_semel_mosad")]
        public virtual string gan_1_semel_mosad { get; set; }

        [DataMember]
        [MappingColumnTo("gan_1_ktovet")]
        public virtual string gan_1_ktovet { get; set; }

        [DataMember]
        [MappingColumnTo("gan_2")]
        public virtual string gan_2 { get; set; }

        [DataMember]
        [MappingColumnTo("gan_2_shem_gan")]
        public virtual string gan_2_shem_gan { get; set; }

        [DataMember]
        [MappingColumnTo("gan_2_semel_mosad")]
        public virtual string gan_2_semel_mosad { get; set; }

        [DataMember]
        [MappingColumnTo("gan_2_ktovet")]
        public virtual string gan_2_ktovet { get; set; }

        [DataMember]
        [MappingColumnTo("gan_yechudi")]
        public virtual string gan_yechudi { get; set; }

        [DataMember]
        [MappingColumnTo("gan_yechudi_shem_gan")]
        public virtual string gan_yechudi_shem_gan { get; set; }

        [DataMember]
        [MappingColumnTo("gan_yechudi_ktovet")]
        public virtual string gan_yechudi_ktovet { get; set; }

        [DataMember]
        [MappingColumnTo("shibutz")]
        public virtual string shibutz { get; set; }

        [DataMember]
        [MappingColumnTo("irr")]
        public virtual string irr { get; set; }

        [DataMember]
        [MappingColumnTo("irr_gan_1")]
        public virtual string irr_gan_1 { get; set; }

        [DataMember]
        [MappingColumnTo("irr_gan_2")]
        public virtual string irr_gan_2 { get; set; }

        [DataMember]
        [MappingColumnTo("irr_btn_txt")]
        public virtual string irr_btn_txt { get; set; }

        [DataMember]
        [MappingColumnTo("haavara")]
        public virtual string haavara { get; set; }

        [DataMember]
        [MappingColumnTo("haavara_meuheret")]
        public virtual string haavara_meuheret { get; set; }

        [DataMember]
        [MappingColumnTo("message_meacherRishum")]
        public virtual string message_meacherRishum { get; set; }

        [DataMember]
        [MappingColumnTo("tzaaron")]
        public virtual string tzaaron { get; set; }

        [DataMember]
        [MappingColumnTo("tzaaron_btn_txt")]
        public virtual string tzaaron_btn_txt { get; set; }

        [DataMember]
        [MappingColumnTo("isKeitanotExist")]
        public virtual string isKeitanotExist { get; set; }

        [DataMember]
        [MappingColumnTo("keitana_btn_txt")]
        public virtual string keitana_btn_txt { get; set; }

        [DataMember]
        [MappingColumnTo("tzaaronMsg")]
        public virtual string tzaaronMsg { get; set; }

        [DataMember]
        [MappingColumnTo("talan_btn")]
        public virtual string talan_btn { get; set; }

        [DataMember]
        [MappingColumnTo("talan")]
        public virtual string talan { get; set; }

        [DataMember]
        [MappingColumnTo("tr_talan_ad")]
        public virtual string tr_talan_ad { get; set; }

        [DataMember]
        [MappingColumnTo("yola")]
        public virtual string yola { get; set; }

        [DataMember]
        [MappingColumnTo("yola_btn")]
        public virtual string yola_btn { get; set; }

        [DataMember]
        [MappingColumnTo("tr_yom_aroch_ad")]
        public virtual string tr_yom_aroch_ad { get; set; }

        [DataMember]
        [MappingColumnTo("bakasht_rishum_btn")]
        public virtual string bakasht_rishum_btn { get; set; }

        [DataMember]
        [MappingColumnTo("idkun_rishum_btn")]
        public virtual string idkun_rishum_btn { get; set; }

        [DataMember]
        [MappingColumnTo("ishur_rishum_btn")]
        public virtual string ishur_rishum_btn { get; set; }

        [DataMember]
        [MappingColumnTo("idkun_tashlum_btn")]
        public virtual string idkun_tashlum_btn { get; set; }

        [DataMember]
        [MappingColumnTo("tzaaron_btn")]
        public virtual string tzaaron_btn { get; set; }

        [DataMember]
        [MappingColumnTo("tr_tzaaron_ad_button")]
        public virtual string tr_tzaaron_ad_button { get; set; }

        [DataMember]
        [MappingColumnTo("irr_btn")]
        public virtual string irr_btn { get; set; }

        [DataMember]
        [MappingColumnTo("irr_docs_btn")]
        public virtual string irr_docs_btn { get; set; }

        [DataMember]
        [MappingColumnTo("hasaa")]
        public virtual string hasaa { get; set; }

        [DataMember]
        [MappingColumnTo("hasaa_btn")]
        public virtual string hasaa_btn { get; set; }

        [DataMember]
        [MappingColumnTo("tr_hasa_ad")]
        public virtual string tr_hasa_ad { get; set; }

        [DataMember]
        [MappingColumnTo("atzarat_Briut_btn")]
        public virtual string atzarat_Briut_btn { get; set; }

        [DataMember]
        [MappingColumnTo("ochlim_yachad_btn")]
        public virtual string ochlim_yachad_btn { get; set; }

        [DataMember]
        [MappingColumnTo("ochlim_yachad_btn_txt")]
        public virtual string ochlim_yachad_btn_txt { get; set; }

        [DataMember]
        [MappingColumnTo("tr_ochlim_yachad_ad")]
        public virtual string tr_ochlim_yachad_ad { get; set; }

        [DataMember]
        [MappingColumnTo("is_LastShibutzCM")]
        public virtual string is_LastShibutzCM { get; set; }

        [DataMember]
        [MappingColumnTo("bitul_rishum_btn")]
        public virtual string bitul_rishum_btn { get; set; }

        [DataMember]
        [MappingColumnTo("existsBakashaBitul")]
        public virtual string existsBakashaBitul { get; set; }

        [DataMember]
        [MappingColumnTo("hearaFamilyPage1")]
        public virtual string hearaFamilyPage1 { get; set; }

        [DataMember]
        [MappingColumnTo("hearaFamilyPage2")]
        public virtual string hearaFamilyPage2 { get; set; }

        [DataMember]
        [MappingColumnTo("hearaFamilyPage3")]
        public virtual string hearaFamilyPage3 { get; set; }

        [DataMember]
        [MappingColumnTo("hearaFamilyPage4")]
        public virtual string hearaFamilyPage4 { get; set; }

        [DataMember]
        [MappingColumnTo("tr_rishum_ad")]
        public virtual string tr_rishum_ad { get; set; }

        [DataMember]
        [MappingColumnTo("irr_kod_achlata_exists")]
        public virtual string irr_kod_achlata_exists { get; set; }

        [DataMember]
        [MappingColumnTo("irr_bakasha_1_kod_achlata")]
        public virtual string irr_bakasha_1_kod_achlata { get; set; }

        [DataMember]
        [MappingColumnTo("irr_bakasha_2_kod_achlata")]
        public virtual string irr_bakasha_2_kod_achlata { get; set; }

        [DataMember]
        [MappingColumnTo("irr_kod_achlata5")]
        public virtual string irr_kod_achlata5 { get; set; }

        [DataMember]
        [MappingColumnTo("tr_tshuva_irr")]
        public virtual string tr_tshuva_irr { get; set; }

        [DataMember]
        [MappingColumnTo("irrCm_btn")]
        public virtual string irrCm_btn { get; set; }

        [DataMember]
        [MappingColumnTo("irrCm")]
        public virtual string irrCm { get; set; }

        [DataMember]
        [MappingColumnTo("showTofesDhiya")]
        public virtual string showTofesDhiya { get; set; }

        [DataMember]
        [MappingColumnTo("shibutz_shem_mosad")]
        public virtual string shibutz_shem_mosad { get; set; }

        [DataMember]
        [MappingColumnTo("shibutz_tr_tzfia_me")]
        public virtual string shibutz_tr_tzfia_me { get; set; }

        [DataMember]
        [MappingColumnTo("shibutz_mosad_shem_rehov")]
        public virtual string shibutz_mosad_shem_rehov { get; set; }

        [DataMember]
        [MappingColumnTo("shibutz_mosad_telephone")]
        public virtual string shibutz_mosad_telephone { get; set; }

        [DataMember]
        [MappingColumnTo("shibutz_menael_fullName")]
        public virtual string shibutz_menael_fullName { get; set; }

        [DataMember]
        [MappingColumnTo("shibutz_mosad_kvotzot")]
        public virtual string shibutz_mosad_kvotzot { get; set; }

        [DataMember]
        [MappingColumnTo("shibutz_mosad_website")]
        public virtual string shibutz_mosad_website { get; set; }

        [DataMember]
        [MappingColumnTo("shibutz_mosad_email")]
        public virtual string shibutz_mosad_email { get; set; }

        [DataMember]
        [MappingColumnTo("shibutz_semel_mosad")]
        public virtual string shibutz_semel_mosad { get; set; }

        [DataMember]
        [MappingColumnTo("hazanat_boker_btn")]
        public virtual string hazanat_boker_btn { get; set; }

        [DataMember]
        [MappingColumnTo("hazanat_boker_btn_txt")]
        public virtual string hazanat_boker_btn_txt { get; set; }

        [DataMember]
        [MappingColumnTo("hazanat_boker_txt")]
        public virtual string hazanat_boker_txt { get; set; }

        [DataMember]
        [MappingColumnTo("shibutz_tr_tzfia")]
        public virtual string shibutz_tr_tzfia { get; set; }

        [DataMember]
        [MappingColumnTo("isCm")]
        public virtual string isCm { get; set; }

        [DataMember]
        [MappingColumnTo("tr_hazanat_boker_ad")]
        public virtual string tr_hazanat_boker_ad { get; set; }

        [DataMember]
        [MappingColumnTo("tashlumim_meratzon")]
        public virtual string tashlumim_meratzon { get; set; }

        [DataMember]
        [MappingColumnTo("tashlumim_meratzon_m_txt")]
        public virtual string tashlumim_meratzon_m_txt { get; set; }

        [DataMember]
        [MappingColumnTo("tashlumim_meratzon_t_txt")]
        public virtual string tashlumim_meratzon_t_txt { get; set; }

        [DataMember]
        [MappingColumnTo("tashlumim_meratzon_btn")]
        public virtual string tashlumim_meratzon_btn { get; set; }

        [DataMember]
        [MappingColumnTo("tr_tashlumim_miratzon_ad")]
        public virtual string tr_tashlumim_miratzon_ad { get; set; }

        [DataMember]
        [MappingColumnTo("sal_tarbut")]
        public virtual string sal_tarbut { get; set; }

        [DataMember]
        [MappingColumnTo("sal_tarbut_txt")]
        public virtual string sal_tarbut_txt { get; set; }

        [DataMember]
        [MappingColumnTo("sal_tarbut_btn")]
        public virtual string sal_tarbut_btn { get; set; }

        [DataMember]
        [MappingColumnTo("tr_sal_tarbut_ad")]
        public virtual string tr_sal_tarbut_ad { get; set; }

        [DataMember]
        [MappingColumnTo("mesibat_siyum")]
        public virtual string mesibat_siyum { get; set; }

        [DataMember]
        [MappingColumnTo("mesibat_siyum_txt")]
        public virtual string mesibat_siyum_txt { get; set; }

        [DataMember]
        [MappingColumnTo("tr_mesibat_siyum_ad")]
        public virtual string tr_mesibat_siyum_ad { get; set; }

        [DataMember]
        [MappingColumnTo("ezor_shem_mosad1")]
        public virtual string ezor_shem_mosad1 { get; set; }

        [DataMember]
        [MappingColumnTo("ezor_shem_mosad2")]
        public virtual string ezor_shem_mosad2 { get; set; }

        [DataMember]
        [MappingColumnTo("ezor_shem_mosad3")]
        public virtual string ezor_shem_mosad3 { get; set; }

        [DataMember]
        [MappingColumnTo("ezor_shem_mosad4")]
        public virtual string ezor_shem_mosad4 { get; set; }

        [DataMember]
        [MappingColumnTo("ezor_shem_mosad5")]
        public virtual string ezor_shem_mosad5 { get; set; }

        [DataMember]
        [MappingColumnTo("teur_shnat_limud_minus_1_short")]
        public virtual string teur_shnat_limud_minus_1_short { get; set; }

        [DataMember]
        [MappingColumnTo("tzaaron_shana_minus_1_btn_txt")]
        public virtual string tzaaron_shana_minus_1_btn_txt { get; set; }

        [DataMember]
        [MappingColumnTo("tzaaron_minus_1_txt")]
        public virtual string tzaaron_minus_1_txt { get; set; }

        [DataMember]
        [MappingColumnTo("isKeitanot_minus1_Exist")]
        public virtual string isKeitanot_minus1_Exist { get; set; }

        [DataMember]
        [MappingColumnTo("keitana_shana_minus_1_btn_txt")]
        public virtual string keitana_shana_minus_1_btn_txt { get; set; }

        [DataMember]
        [MappingColumnTo("talan_shana_minus_1_btn")]
        public virtual string talan_shana_minus_1_btn { get; set; }

        [DataMember]
        [MappingColumnTo("talan_shana_minus_1_txt")]
        public virtual string talan_shana_minus_1_txt { get; set; }

        [DataMember]
        [MappingColumnTo("tr_talan_ad_minus1_button")]
        public virtual string tr_talan_ad_minus1_button { get; set; }

        [DataMember]
        [MappingColumnTo("yola_minus_1_txt")]
        public virtual string yola_minus_1_txt { get; set; }

        [DataMember]
        [MappingColumnTo("yom_aroch_shana_minus_1_btn")]
        public virtual string yom_aroch_shana_minus_1_btn { get; set; }

        [DataMember]
        [MappingColumnTo("tr_yom_aroch_ad_shana_minus1_button")]
        public virtual string tr_yom_aroch_ad_shana_minus1_button { get; set; }

        [DataMember]
        [MappingColumnTo("tzaaron_shana_minus_1_btn")]
        public virtual string tzaaron_shana_minus_1_btn { get; set; }

        [DataMember]
        [MappingColumnTo("tr_tzaaron_ad_shana_minus1_button")]
        public virtual string tr_tzaaron_ad_shana_minus1_button { get; set; }

        [DataMember]
        [MappingColumnTo("hasaa_minus_1_btn")]
        public virtual string hasaa_minus_1_btn { get; set; }

        [DataMember]
        [MappingColumnTo("hasaa_minus_1_btn_txt")]
        public virtual string hasaa_minus_1_btn_txt { get; set; }

        [DataMember]
        [MappingColumnTo("hasaa_minus_1_txt")]
        public virtual string hasaa_minus_1_txt { get; set; }

        [DataMember]
        [MappingColumnTo("tr_hasa_ad_shana_minus1_button")]
        public virtual string tr_hasa_ad_shana_minus1_button { get; set; }

        [DataMember]
        [MappingColumnTo("ochlim_yachad_shana_minus1_btn")]
        public virtual string ochlim_yachad_shana_minus1_btn { get; set; }

        [DataMember]
        [MappingColumnTo("ochlim_yachad_shana_minus1_btn_txt")]
        public virtual string ochlim_yachad_shana_minus1_btn_txt { get; set; }

        [DataMember]
        [MappingColumnTo("tr_ochlim_yachad_ad_shana_minus1_button")]
        public virtual string tr_ochlim_yachad_ad_shana_minus1_button { get; set; }

        [DataMember]
        [MappingColumnTo("bitul_rishum_btn_txt")]
        public virtual string bitul_rishum_btn_txt { get; set; }

        [DataMember]
        [MappingColumnTo("hazanat_boker_minus1_btn")]
        public virtual string hazanat_boker_minus1_btn { get; set; }

        [DataMember]
        [MappingColumnTo("hazanat_boker_minus1_btn_txt")]
        public virtual string hazanat_boker_minus1_btn_txt { get; set; }

        [DataMember]
        [MappingColumnTo("hazanat_boker_minus_1_txt")]
        public virtual string hazanat_boker_minus_1_txt { get; set; }

        [DataMember]
        [MappingColumnTo("tr_hazanat_boker_ad_minus1_button")]
        public virtual string tr_hazanat_boker_ad_minus1_button { get; set; }

        [DataMember]
        [MappingColumnTo("tashlumim_meratzon_minus1")]
        public virtual string tashlumim_meratzon_minus1 { get; set; }

        [DataMember]
        [MappingColumnTo("tashlumim_meratzon_m_minus_1_txt")]
        public virtual string tashlumim_meratzon_m_minus_1_txt { get; set; }

        [DataMember]
        [MappingColumnTo("tashlumim_meratzon_t_minus_1_txt")]
        public virtual string tashlumim_meratzon_t_minus_1_txt { get; set; }

        [DataMember]
        [MappingColumnTo("tashlumim_meratzon_shana_minus_1_btn")]
        public virtual string tashlumim_meratzon_shana_minus_1_btn { get; set; }

        [DataMember]
        [MappingColumnTo("tr_tashlumim_miratzon_ad_minus1_button")]
        public virtual string tr_tashlumim_miratzon_ad_minus1_button { get; set; }

        [DataMember]
        [MappingColumnTo("sal_tarbut_minus1")]
        public virtual string sal_tarbut_minus1 { get; set; }

        [DataMember]
        [MappingColumnTo("sal_tarbut_minus_1_txt")]
        public virtual string sal_tarbut_minus_1_txt { get; set; }

        [DataMember]
        [MappingColumnTo("sal_tarbut_shana_minus_1_btn")]
        public virtual string sal_tarbut_shana_minus_1_btn { get; set; }

        [DataMember]
        [MappingColumnTo("tr_sal_tarbut_ad_minus1_button")]
        public virtual string tr_sal_tarbut_ad_minus1_button { get; set; }

        [DataMember]
        [MappingColumnTo("mesibat_siyum_minus1")]
        public virtual string mesibat_siyum_minus1 { get; set; }

        [DataMember]
        [MappingColumnTo("mesibat_siyum_minus_1_txt")]
        public virtual string mesibat_siyum_minus_1_txt { get; set; }

        [DataMember]
        [MappingColumnTo("mesibat_siyum_btn")]
        public virtual string mesibat_siyum_btn { get; set; }

        [DataMember]
        [MappingColumnTo("mesibat_siyum_shana_minus_1_btn")]
        public virtual string mesibat_siyum_shana_minus_1_btn { get; set; }

        [DataMember]
        [MappingColumnTo("tr_mesibat_siyum_ad_minus1_button")]
        public virtual string tr_mesibat_siyum_ad_minus1_button { get; set; }

    }
}
