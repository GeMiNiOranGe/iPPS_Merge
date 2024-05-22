USE [Pepro]
GO

CREATE OR ALTER FUNCTION dbo.CheckMACCAndMANVexists (
    @MANV VARCHAR(10),
    @MACC VARCHAR(10)
) RETURNS BIT
AS BEGIN
    DECLARE @Result BIT;

    IF EXISTS (
        SELECT 1
        FROM NHANVIEN
        WHERE MANV = @MANV
    ) BEGIN
        IF EXISTS (
            SELECT 1
            FROM BOPHANCHAMCONG
            WHERE MANV = @MANV AND MACC = @MACC
        ) BEGIN
            SET @Result = 1;
        -- MANV và MACC tồn tại
        END
        ELSE BEGIN
            SET @Result = 0;
        -- MANV tồn tại, nhưng MACC không tồn tại
        END
    END
    ELSE BEGIN
        SET @Result = 0;
    -- MANV không tồn tại
    END

    RETURN @Result;
END;
