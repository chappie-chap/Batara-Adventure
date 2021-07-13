using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level{
    private List<Quest> questList;
    public List<Quest> questLevel1()
    {
        questList = new List<Quest>();
        questList.Add(new Quest("/Tarian/1", "Tari saman adalah tarian yang berasal dari daerah …", "Aceh", "Jawa Tengah", "Kalimantan Selatan", "Jawa Timur", "btnA", false));
        questList.Add(new Quest(null, "Rumah gadang berasal dari daerah …", "Sulawesi Barat", "Sumatera Barat", "Jawa Timur", "Kalimantan Barat", "btnB", false));
        questList.Add(new Quest("/Rumah/34", "Rumah adat Honai berasal dari daerah…", "Jawa Barat", "Sulawesi Selatan", "Papua Barat", "Papua", "btnD", false));
        questList.Add(new Quest(null, "Pesa’an merupakan pakaian adat yang berasal dari provinsi …", "Jawa Timur", "Jawa Barat", "Jawa Tengah", "D.I Yogyakarta", "btnA", false));
        questList.Add(new Quest(null, "Rumah joglo berasal dari daerah …", "Jambi", "Sulawesi Utara", "Jawa Timur", "Aceh", "btnC", false));
        questList.Add(new Quest(null, "Pakaian adat Provinsi DKI Jakarta disebut…", "Pakaian adat Betawi", "Pakaian adat Melayu", "Kebaya", "Teluk Belanga", "btnA", false));
        questList.Add(new Quest(null, "Tari payung berasal dari daerah …", "Jambi", "Sumatera Barat", "Sulawesi", "Gorontalo", "btnB", false));
        questList.Add(new Quest(null, "Tari serimpi berasal dari daerah …", "Kalimantan Selatan", "Papua", "D.I Yogyakarta", "DKI Jakarta", "btnC", false));
        questList.Add(new Quest("/Tarian/10", "Tari remo berasal dari daerah…", "Jawa Timur", "Jawa Barat", "Jawa Tengah", "Gorontalo", "btnA", false));
        questList.Add(new Quest(null, "Rumah adat Provinsi Papua Barat adalah …", "Rumah Joglo", "Rumah Limas", "Rumah panggung", "Rumah kaki seribu", "btnD", false));
        return questList;
    }

    public List<Quest> questLevel2()
    {
        questList = new List<Quest>();
        questList.Add(new Quest("/Rumah/8", "Rumah adat Limas berasal dari daerah …", "Jambi", "Sumatera Selatan", "Kalimantan Selatan", "Sulawesi Selatan", "btnB", false));
        questList.Add(new Quest(null, "Rumah adat DKI Jakarta adalah...", "Rumah Kebaya", "Rumah Joglo", "Rumah Betang", "Rumah Panjang", "btnA", false));
        questList.Add(new Quest(null, "Tari kecak berasal dari daerah...", "Bali", "Kalimantan", "Jawa", "Sumatera", "btnA", false));
        questList.Add(new Quest(null, "Pakaian adat dari provinsi Sumatera Utara disebut...", "Ulee Balang", "Ulos", "Aesan Gede", "Kebaya", "btnB", false));
        questList.Add(new Quest(null, "Rumah Balai Batak Toba berasal dari daerah", "Aceh", "Maluku", "Sumatera Utara", "Sulawesi Barat", "btnC", false));
        questList.Add(new Quest("/Tarian/2", "Tari Serampang dua belas merupakan tarian yang berasal dari daerah...", "Kalimantan Selatan", "Sumatera Barat", "Sumatera Utara", "Bali", "btnC", false));
        questList.Add(new Quest(null, "Pakaian adat provinsi Kalimantan Timur adalah...", "Pakaian adat Kusti", "Pakaian adat Pesa'an", "Pakaian adat Lombok", "Pakaian adat Kebaya", "btnA", false)); //Perlu Revisi
        questList.Add(new Quest("/Tarian/34", "Tari selamat datang berasal dari provinsi...", "Kalimantan Timur", "Maluku", "Kalimantan Selatan", "Papua Barat", "btnD", false));
        questList.Add(new Quest("/Tarian/22", "Tari kecak berasal dari provinsi...", "Bali", "kalimantan", "Jawa", "Aceh", "btnA", false));
        questList.Add(new Quest("/Baju/1", "Pakaian adat disamping merupakan pakaian adat yang berasal dari provinsi...", "Sumatera Barat", "Jawa Barat", "Nanggroe Aceh Darussalam", "Bali", "btnC", false));
        return questList;
    }
    public List<Quest> questLevel3()
    {
        questList = new List<Quest>();
        questList.Add(new Quest(null, "Pakaian adat ulos merupakan pakaian adat yang berasal dari provinsi…", "Sumatera Utara", "NTT", "Sumatera Barat", "NTB", "btnA", false));
        questList.Add(new Quest("/Baju/14", "Pakaian adat yang berasal dari D.I Yogyakarta disebut pakaian adat…", "Ulos", "Ngaju", "Paksian", "Paes Agung", "btnD", false));
        questList.Add(new Quest(null, "Pakaian adat yang berasal dari provinsi Bali disebut pakaian adat…", "Payas Agung", "Kusti", "Begajah Gamuling Baular Lutut", "Ta'a", "btnA", false));
        questList.Add(new Quest("/Tarian/15", "Tari topeng betawi berasal dari provinsi…", "Jawa Barat", "DKI Jakarta", "Maluku", "Gorontalo", "btnB", false));
        questList.Add(new Quest(null, "Rumah adat Baduy berasal dari provinsi…", "Banten", "Riau", "Jambi", "Maluku", "btnA", false));
        questList.Add(new Quest("/Rumah/22", "Gapura candi bentar merupakan rumah adat provinsi…", "Sulawesi Selatan", "Kalimantan Utara", "Jawa", "Bali", "btnD", false));
        questList.Add(new Quest(null, "Rumah Gadang berasal dari daerah …", "Jambi", "Bangka Belitung", "Sumatera barat", "D.I Yogyakarta", "btnC", false));
        questList.Add(new Quest("/Tarian/13", "Tari tandak merupakan tarian yang berasal dari provinsi…", "Kepulauan Riau", "Jambi", "Gorontalo", "NTT", "btnA", false));
        questList.Add(new Quest(null, "Tari gong merupakan tarian yang berasal dari provinsi…", "Kalimantan Selatan", "Kalimantan Utara", "Kalimantan Timur", "Kalimantan Barat", "btnC", false));
        questList.Add(new Quest("/Tarian/11", "Tari Jaipong merupakan tarian yang berasal dari provinsi…", "Jawa Barat", "Jawa Tengah", "DKI Jakarta", "Bali", "btnA", false));
        return questList;
    }
    public List<Quest> questLevel4()
    {
        questList = new List<Quest>();
        questList.Add(new Quest("/Rumah/4", "Rumah Salaso Jatuh Kembar merupakan rumah adat yang berasal dari provinsi…", "Kepulauan Riau", "Riau", "Bengkulu", "Sulawesi", "btnB", false));
        questList.Add(new Quest(null, "Tarian yang berasal dari Gorontalo disebut...", "Tari Remo", "Tari Pendet", "Tari Sarode", "Tari Kecak", "btnC", false));// Revisi
        questList.Add(new Quest(null, "Tari Kipas Pakarena adalah tarian yang berasal dari provinsi…", "Jambi", "Aceh", "Sulawesi Selatan", "Sulawesi Barat", "btnC", false));
        questList.Add(new Quest(null, "Ulos, Kebaya, dan Aesan Gede adalah contoh nama-nama … di Indonesia.", "Makanan khas", "Pakaian adat", "Tarian daerah", "Rumah adat", "btnB", false));
        questList.Add(new Quest("/Baju/18", "Pakaian adat dari provinsi NTT disebut pakaian adat…", "Rote", "Kebaya", "Pesa'an", "Kain tipis", "btnA", false));
        questList.Add(new Quest("/Tarian/12", "Tari Bedhaya Ketawang adalah tarian yang berasal dari provinsi…", "Jawa Timur", "D.I Yogyakarta", "Jawa Tengah", "Jawa Barat", "btnC", false));
        questList.Add(new Quest(null, "Rumah Adat Provinsi Sulawesi Selatan disebut rumah adat…", "Nuwou Sesat", "Joglo", "Honaj", "Tongkonan", "btnD", false));
        questList.Add(new Quest("/Tarian/24", "Tari perang adalah tarian yang berasal dari provinsi…", "Jawa Timur", "D.I Yogyakarta", "Jawa Tengah", "Jawa Barat Yogyakarta", "btnA", false));
        questList.Add(new Quest(null, "Salah satu kegunaan pakaian adat di Indonesia adalah, kecuali…", "Menunjukkan ciri khas daerah", "Memperkenalkan budaya daerah", "Tradisi upacara daerah", "Untuk bergaya", "btnD", false));
        questList.Add(new Quest(null, "Pakaian adat toraja berasal dari provinsi… ", "Sulawesi Selatan", "Sulawesi Tenggara", "Jawa Tengah", "Jambi", "btnA", false));
        return questList;
    }
    public List<Quest> questLevel5()
    {
        questList = new List<Quest>();
        questList.Add(new Quest("/Tarian/18", "Tari baksa kembang adalah tarian yang berasal dari provinsi…", "Kalimantan Timur", "Kalimantan Barat", "Kalimantan Selatan", "Sulawesi Tenggara", "btnC", false));
        questList.Add(new Quest(null, "Rumah adat sasandu berasal dari provinsi…", "Maluku Barat", "Papua Barat", "Papua", "Gorontalo", "btnA", false));
        questList.Add(new Quest(null, "Rumah Dalam Loka Samawa adalah rumah adat provinsi…", "NTT", "NTB", "Bali", "Aceh", "btnB", false));
        questList.Add(new Quest(null, "Tarian daerah Provinsi Sulawesi Utara adalah…", "Tari Remo", "Tari Kecak", "Tari Maengket", "Tari Pakarena", "btnC", false));
        questList.Add(new Quest(null, "Pakaian adat provinsi lampung disebut …", "Pakaian adat Tapis", "Pakaian adat Ta'a", "Pakaian adat Cele", "Pakaian adat Minahasa", "btnA", false));
        questList.Add(new Quest(null, "Pakaian adat koteka merupakan pakaian adat yang berasal dari provinsi …", "Sulawesi Tengah", "NTB", "Papua", "D.I Yogyakarta", "btnC", false));
        questList.Add(new Quest("/Tarian/9", "Tari campak adalah tarian daerah yang berasal dari provinsi…", "Bali", "Banten", "Riau", "Bangka Belitung", "btnD", false));
        questList.Add(new Quest(null, "Rumah adat Provinsi Kalimantan Selatan disebut…", "Rumah adat Banjar", "Rumah adat Joglo", "Rumah adat Doloupa", "Rumah adat Beton", "btnA", false));
        questList.Add(new Quest(null, "Tari pendet berasal dari daerah…", "Jawa", "Bali", "Kalimantan", "Papua", "btnB", false));
        questList.Add(new Quest(null, "Pakaian adat Jawi jangkep adalah pakaian adat provinsi…", "Kalimantan Timur", "Jawa Tengah", "Kalimantan Selatan", "Kalimantan Tengah", "btnB", false));
        return questList;
    }
}
