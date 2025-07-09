# Teste Técnico – SQL: Colaboradores e Departamentos

Este repositório contém a resolução de um problema SQL, onde foi necessário identificar o colaborador com o maior salário em cada departamento, a partir de um conjunto de dados simples.

## 📋 Estrutura das Tabelas

```sql
CREATE TABLE public.departamento (
    id serial NOT NULL,
    nome character varying NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE public.colaboradores (
    id serial NOT NULL,
    nome character varying NOT NULL,
    salario double precision NOT NULL,
    departamento_id integer NOT NULL,
    CONSTRAINT colaboradores_pk PRIMARY KEY (id),
    CONSTRAINT colaboradores_departamento_id_fk FOREIGN KEY (departamento_id)
        REFERENCES public.departamento (id)
);

-- Inserção dos departamentos
INSERT INTO public.departamento (nome)
VALUES 
    ('TI'),
    ('Vendas');

-- Inserção dos colaboradores
INSERT INTO public.colaboradores (nome, salario, departamento_id)
VALUES 
    ('Joe', 70000, 1),
    ('Henry', 80000, 2),
    ('Sam', 60000, 2),
    ('Max', 90000, 1);

-- Consulta SQL para obter o colaborador com mario salário de cada departamento
SELECT d.nome AS Departamento, c.nome AS Pessoa, c.salario AS Salario
FROM public.colaboradores c
JOIN public.departamento d ON c.departamento_id = d.id
WHERE (c.salario, c.departamento_id) IN (
    SELECT MAX(salario), departamento_id
    FROM public.colaboradores
    GROUP BY departamento_id
);
