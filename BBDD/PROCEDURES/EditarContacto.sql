CREATE PROCEDURE dbo.EditarContacto
    @Id INT,
    @Nombre VARCHAR(100),
    @FechaNacimiento DATE,
    @Telefono VARCHAR(9),
    @Observaciones VARCHAR(500)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE Agenda.dbo.Contactos
        SET 
            Nombre = @Nombre,
            FechaNacimiento = @FechaNacimiento,
            Telefono = @Telefono,
            Observaciones = @Observaciones
        WHERE Id = @Id;

        COMMIT; -- Confirmar la transacción si es exitosa
    END TRY
    BEGIN CATCH
        ROLLBACK; -- Revertir la transacción si ocurre un error

        -- Imprimir el mensaje de error
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
