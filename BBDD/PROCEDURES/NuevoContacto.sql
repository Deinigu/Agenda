CREATE PROCEDURE dbo.NuevoContacto
    @Nombre VARCHAR(100),
    @FechaNacimiento DATE,
    @Telefono VARCHAR(9),
    @Observaciones VARCHAR(500)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION; -- Start a transaction

        -- Your INSERT statement here
        INSERT INTO Contactos
        (
            Nombre,
            FechaNacimiento,
            Telefono,
            Observaciones
        )
        VALUES
        (
            @Nombre,
            @FechaNacimiento,
            @Telefono,
            @Observaciones
        );

        COMMIT; -- Commit the transaction if successful
    END TRY
    BEGIN CATCH
        ROLLBACK; -- Rollback the transaction if an error occurs
        -- Print the error message
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
