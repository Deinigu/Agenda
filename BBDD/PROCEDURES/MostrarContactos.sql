CREATE PROCEDURE dbo.MostrarContactos
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        SELECT * FROM Agenda.dbo.Contactos;
        
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;

        -- Throw an error message
        THROW;
		END CATCH
END
