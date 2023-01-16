using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using Modelo;

namespace Negocio {

  class NAluno { // negócio - operações
    private static List<Aluno> alunos;
    public static void Inserir(Aluno a) {  // Create
      AbrirArquivo();
      int id = alunos.Max(x => x.Id);
      id++;
      a.Id = id;
      alunos.Add(a);
      SalvarArquivo();
    }
    public static List<Aluno> Listar() {   // Read
      AbrirArquivo();
      return alunos;
    }
    public static Aluno Listar(int id) {   
      //foreach (Aluno a in alunos) if (a.Id == id) return a;
      //return null;
      return alunos.Where(a => a.Id == id).SingleOrDefault();
    }
    public static void Atualizar(Aluno a) {  // Update
      AbrirArquivo();
      Aluno obj = Listar(a.Id);
      if (obj == null)
        throw new ArgumentOutOfRangeException("Id não existe");
      if (obj != null) {
        obj.Nome = a.Nome;
        obj.Matricula = a.Matricula;
        obj.Nascimento = a.Nascimento;
        SalvarArquivo();
      }
    }
    public static void Excluir(Aluno a) {  // Delete
      AbrirArquivo();
      Aluno obj = Listar(a.Id);
      if (obj == null)
        throw new ArgumentOutOfRangeException("Id não existe");
      if (obj != null) {
        alunos.Remove(obj);
        SalvarArquivo();
      }  
    }
    public static void AbrirArquivo() {
      XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
      StreamReader stream = null;
      try {
        stream = new StreamReader("./alunos.xml");
        alunos = (List<Aluno>) xml.Deserialize(stream);
      }
      catch (FileNotFoundException) {
        alunos = new List<Aluno>();
      }
      if (stream != null) stream.Close();
    }
    public static void SalvarArquivo() {
      // Classe que transforma (serialização) um objeto em xml
      // https://learn.microsoft.com/pt-br/dotnet/api/system.xml.serialization.xmlserializer?view=net-7.0
      XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
      // Classe que manipula um arquivo - para gravar
      // https://learn.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-7.0
      StreamWriter stream = new StreamWriter("./alunos.xml", false);
      // https://learn.microsoft.com/pt-br/dotnet/api/system.xml.serialization.xmlserializer.serialize?view=net-7.0#system-xml-serialization-xmlserializer-serialize(system-io-stream-system-object)
      xml.Serialize(stream, alunos);
      stream.Close();
    }
  }

}