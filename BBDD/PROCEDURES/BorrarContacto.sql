CREATE PROCEDURE dbo.BorrarContacto
    @Id INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION; 

        DELETE FROM Agenda.dbo.Contactos
        WHERE Id = @Id;

        COMMIT; 
    END TRY
    BEGIN CATCH
        ROLLBACK;
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH;
END;
