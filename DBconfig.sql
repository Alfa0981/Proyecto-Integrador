create stored procedure
begin

CREATE TABLE Rol (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50) NOT NULL
);

create table Usuario (

	id INT PRIMARY KEY IDENTITY(1,1),
    dni VARCHAR(20) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    usuario VARCHAR(50) NOT NULL,
    pass VARCHAR(255) NOT NULL,
    rol_id INT NOT NULL,
    email VARCHAR(100),
    bloqueo BIT DEFAULT 0,
    activo BIT DEFAULT 1,
    FOREIGN KEY (rol_id) REFERENCES Rol(id)
);


end;