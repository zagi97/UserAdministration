// zadatak_1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <vector>

using namespace std;

struct Artikl
{
	// Konstruktor strukture
	int nSifra;
	string sNaziv;
	string sOpis;
	float dCijena;

	Artikl(int s, string n, string o, float c)
	{
		nSifra = s;
		sNaziv = n;
		sOpis = o;
		dCijena = c;
	}

};

void IspisiArtikle(vector<Artikl> vArtikli);
void PretraziArtikle(vector <Artikl> vArtikli, string sNaziv);

int main()
{
	//deklaracija vektora artikli
	vector<Artikl> vArtikli;

	//popunjavanje objekata
	Artikl a1(100, "Olovka", "HB", 2.5);
	Artikl a2(200, "Blok", "A3", 5);
	Artikl a3(300, "Marker", "Zuti", 15);
	Artikl a4(400, "Gumica", "Mala", 2);
	Artikl a5(500, "Papir", "A4", 20);
	
	// spremanje u vektor
	vArtikli.push_back(a1);
	vArtikli.push_back(a2);
	vArtikli.push_back(a3);
	vArtikli.push_back(a4);
	vArtikli.push_back(a5);

	// ispis vektora (\t = Tab)
	cout << "Sifra" << "\t\t" << "Naziv" <<
		"\t\t" << "Opis" << "\t\t" << "Cijena" << "\t\t"<< endl;
	cout << "---------------------------------------------------------" << endl;
	
	for (int i = 0; i < vArtikli.size(); i++)
	{
		cout << vArtikli[i].nSifra << "\t\t" << vArtikli[i].sNaziv << "\t\t" << vArtikli[i].sOpis << "\t\t" << vArtikli[i].dCijena << "\t\t" << endl;

	}

	IspisiArtikle(vArtikli);
	PretraziArtikle(vArtikli, "Papir");

	system("pause");
    return 0;
}

void IspisiArtikle(vector<Artikl>vArtikli)
{
	//ispis vektora
	cout << "Sifra" << "\t\t" << "Naziv" << "\t\t" << "Opis" << "\t\t" << "Cijena" << "\t\t" << endl;
	cout << "-----------------------------------------------------------------------------" << endl;
	for (int i = 0; i < vArtikli.size(); i++)
	{
		cout << vArtikli[i].nSifra << "\t\t" << vArtikli[i].sNaziv << "\t\t" << vArtikli[i].sOpis << "\t\t" << vArtikli[i].dCijena << endl;
	}
}

void PretraziArtikle(vector <Artikl> vArtikli, string sNaziv)
{
	for (int i = 0; i < vArtikli.size(); i++)
	{
		if (vArtikli[i].sNaziv == sNaziv)
		{
			cout << vArtikli[i].nSifra << "\t\t" << vArtikli[i].sNaziv << "\t\t" << vArtikli[i].sOpis << "\t\t" << vArtikli[i].dCijena << endl;
		}
	}
}