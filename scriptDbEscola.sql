CREATE DATABASE escola;
CREATE TABLE escola.tb_aluno (
id_aluno int NOT NULL AUTO_INCREMENT,
matricula int NOT NULL,
nome_aluno varchar(100) NOT NULL,
email_aluno varchar(45) NOT NULL,
whatsapp_aluno varchar(20) DEFAULT NULL,
endereco_aluno varchar(100) DEFAULT NULL,
estado_aluno varchar(100) DEFAULT NULL,
PRIMARY KEY (id_aluno)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE escola.tb_curso (
id_curso int NOT NULL AUTO_INCREMENT,
nome_curso varchar(100) NOT NULL,
duracao int DEFAULT '4',
grade int DEFAULT '2023',
PRIMARY KEY (id_curso),
UNIQUE KEY id_curso_UNIQUE (id_curso)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE escola.tb_disciplina (
id_disciplina int NOT NULL AUTO_INCREMENT,
disciplina varchar(100) NOT NULL,
habilidades varchar(200) DEFAULT NULL,
PRIMARY KEY (id_disciplina)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE escola.tb_professor (
id_professor int NOT NULL AUTO_INCREMENT,
professor varchar(100) DEFAULT NULL,
titulacao varchar(100) DEFAULT NULL,
formacao varchar(100) DEFAULT NULL,
email_professor varchar(45) DEFAULT NULL,
PRIMARY KEY (id_professor),
UNIQUE KEY id_professor_UNIQUE (id_professor)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE escola.tb_aluno_curso (
id_aluno_curso int NOT NULL AUTO_INCREMENT,
id_aluno int DEFAULT '0',
id_curso int DEFAULT '0',
ind_status tinyint(1) DEFAULT '0',
PRIMARY KEY (id_aluno_curso),
KEY fk_id_aluno (id_curso),
KEY fk_id_curso2 (id_aluno),
CONSTRAINT fk_id_aluno FOREIGN KEY (id_curso) REFERENCES escola.tb_aluno (id_aluno),
CONSTRAINT fk_id_curso2 FOREIGN KEY (id_aluno) REFERENCES escola.tb_curso (id_curso)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE escola.tb_curso_disciplina (
id_curso_disciplina int NOT NULL AUTO_INCREMENT,
id_curso int DEFAULT '0',
id_disciplina int DEFAULT '0',
optativa tinyint(1) DEFAULT '0',
PRIMARY KEY (id_curso_disciplina),
KEY fk_id_curso (id_curso),
KEY fk_id_disciplina (id_disciplina),
CONSTRAINT fk_id_curso FOREIGN KEY (id_curso) REFERENCES escola.tb_curso (id_curso),
CONSTRAINT fk_id_disciplina FOREIGN KEY (id_disciplina) REFERENCES escola.tb_disciplina (id_disciplina)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE escola.tb_disciplina_professor (
id_disciplina_professor int NOT NULL AUTO_INCREMENT,
id_disciplina int DEFAULT '0',
id_professor int DEFAULT '0',
PRIMARY KEY (id_disciplina_professor),
KEY fk_id_professor (id_professor),
KEY fk_id_disciplina2 (id_disciplina),
CONSTRAINT fk_id_disciplina2 FOREIGN KEY (id_disciplina) REFERENCES escola.tb_disciplina (id_disciplina),
CONSTRAINT fk_id_professor FOREIGN KEY (id_professor) REFERENCES escola.tb_professor (id_professor)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;