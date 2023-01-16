using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using Modelo;

namespace Negocio {

  class NAluno { // negócio - operações
    private static List<Aluno> alunos;
    public static void Inserir(Aluno a) {  // Create
      alunos.Add(a);
    }
    public static List<Aluno> Listar() {   // Read
      return alunos;
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