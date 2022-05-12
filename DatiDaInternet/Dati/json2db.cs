using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Data.Sqlite;

namespace DatiDaInternet.Dati
{
    public class Json2db
    {
        private Archivio archivio;
        private String percorso;

        /// <summary>
        /// ricevendo un archivio, costruisce una banca dati
        /// </summary>
        public Json2db(Archivio compilato, string percorsoDB)
        {
            archivio = compilato;
            percorso = percorsoDB;
            if (!File.Exists(percorsoDB))
            {
                SqliteConnection dbcon = new SqliteConnection("Data Source=" + percorsoDB + "");
                dbcon.Open();
                if(dbcon.State == System.Data.ConnectionState.Open)
                {
                    // creazione della tabella degli autori
                    string SQL = "CREATE TABLE autori (" +
                                    "idautore INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                    "autore TEXT" +
                                    ")";
                    SqliteCommand dbexe = new SqliteCommand(SQL, dbcon);
                    dbexe.ExecuteNonQuery(); //dbexe.ExecuteReader
                    // creazione della tabella delle collane
                    SQL = "CREATE TABLE collane (idcollana INTEGER PRIMARY KEY AUTOINCREMENT, collana TEXT)";
                    dbexe = new SqliteCommand(SQL, dbcon);
                    dbexe.ExecuteNonQuery();
                    // creazione della tabella scrittoDa
                    SQL = "CREATE TABLE scrittoDa (idLibro INTEGER, idAutore INTEGER)";
                    dbexe = new SqliteCommand(SQL, dbcon);
                    dbexe.ExecuteNonQuery();
                    // creazione della tabella libri
                    SQL = "CREATE TABLE libri(" +
                        "idLibro INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "isbn DOUBLE," +
                        "titolo TEXT," +
                        "pagine INT," +
                        "prezzo DOUBLE," +
                        "idCollana INT)";
                    dbexe = new SqliteCommand(SQL, dbcon);
                    dbexe.ExecuteNonQuery();
                }
                dbcon.Close();
            }
        }

        public void importa()
        {
            SqliteConnection dbcon = new SqliteConnection("Data Source=" + percorso);
            dbcon.Open();
            if(dbcon.State == System.Data.ConnectionState.Open)
            {
                // importo tutti gli autori
                foreach(Autore singolo in archivio.autori)
                {
                    // costruire un comando
                    SqliteCommand dbexe = new SqliteCommand("INSERT INTO autori (idautore, autore) VALUES (@idautore, @nome)", dbcon);
                    dbexe.Parameters.Add(   new SqliteParameter("@idautore", singolo.idAutore)   );
                    dbexe.Parameters.Add(   new SqliteParameter("@nome", singolo.nome)    );
                    try
                    {
                        dbexe.ExecuteNonQuery();
                    } catch (Exception messaggio)
                    {
                        Console.WriteLine("Errore : " + messaggio.Message);
                    }
                    
                }


                foreach(Collana singola in archivio.collane)
                {
                    SqliteCommand dbexe = new SqliteCommand("INSERT INTO collane (idcollana, collana) VALUES (@idcollana, @nome)", dbcon);
                    dbexe.Parameters.Add(   new SqliteParameter("@idcollana", singola.idCollana)   );
                    dbexe.Parameters.Add(   new SqliteParameter("@nome", singola.nome)   );
                    try
                    {
                        dbexe.ExecuteNonQuery();
                    }
                    catch (Exception er)
                    {

                    }
                    
                }

                foreach(ScrittoDa singolo in archivio.abbinamenti)
                {
                    SqliteCommand dbexe = new SqliteCommand("INSERT INTO scrittoDa (idlibro, idautore) VALUES (@idlibro, @idautore)", dbcon);
                    dbexe.Parameters.Add( new SqliteParameter("@idlibro", singolo.idLibro) );
                    dbexe.Parameters.Add( new SqliteParameter("@idautore", singolo.idAutore) );
                    try
                    {
                        dbexe.ExecuteNonQuery();
                    } catch (Exception er)
                    {

                    }
                }

                foreach (Libro singolo in archivio.libri)
                {
                    string SQL = "INSERT INTO libri (idlibro, isbn, titolo, pagine, prezzo, idcollana)" +
                                    "VALUES (@idlibro, @isbn, @titolo, @pagine, @prezzo, @idcollana)";
                    SqliteCommand dbexe = new SqliteCommand(SQL, dbcon);

                    dbexe.Parameters.Add( new SqliteParameter("@idlibro", singolo.idLibro) );
                    dbexe.Parameters.Add( new SqliteParameter("@isbn", singolo.ISBN) );
                    dbexe.Parameters.Add( new SqliteParameter("@titolo", singolo.Titolo) );
                    dbexe.Parameters.Add( new SqliteParameter("@pagine", singolo.Pagine) );
                    dbexe.Parameters.Add( new SqliteParameter("@prezzo", singolo.Prezzo) );
                    dbexe.Parameters.Add( new SqliteParameter("@idcollana", singolo.idCollana) );

                    try
                    {
                        dbexe.ExecuteNonQuery();
                    } catch (Exception ex)
                    {

                    }
                }
            }
            dbcon.Close();
        }

    }
}
