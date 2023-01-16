class Aluno:
  def __init__(self, id, nome, matricula):
    self.id = id  # atributo da instância
    self.nome = nome
    self.matricula = matricula
    self.idTurma = 0
  def __str__(self):
    return f"{self.id}: {self.nome} {self.matricula} {self.idTurma}"

class Turma:
  def __init__(self, id, disciplina):
    self.id = id  # atributo da instância
    self.disciplina = disciplina

class NAluno:
  alunos = []  # atributo da classe
  @classmethod
  def inserir(cls, aluno):
    cls.alunos.append(aluno)
  @classmethod
  def listar(cls):
    return cls.alunos
  @classmethod
  def listarTurma(cls, turma):
    diario = []
    for aluno in cls.alunos:
      if aluno.idTurma == turma.id:
        diario.append(aluno)
    return diario    
  @classmethod
  def matricular(cls, aluno, turma):
    aluno.idTurma = turma.id

class NTurma:
  turmas = []  # atributo da classe
  @classmethod
  def inserir(cls, turma):
    cls.turmas.append(turma)
  @classmethod
  def listar(cls):
    return cls.turmas

if __name__ == '__main__':
  a = Aluno(1, "Gilbert", "1234")
  b = Aluno(2, "Arthur", "8888")
  NAluno.inserir(a)
  NAluno.inserir(b)
  t = Turma(1, "POO")
  NAluno.matricular(a, t)  
  for aluno in NAluno.listar():
    print(aluno)
  for aluno in NAluno.listarTurma(t):
    print(aluno)

