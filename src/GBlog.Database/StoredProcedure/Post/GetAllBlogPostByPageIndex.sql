CREATE PROC [dbo].[sp_GetAllPostByPageIndex](@PageIndex Int, @PageSize INT)
AS
BEGIN
	SELECT * FROM Post ORDER BY Id OFFSET((@PageIndex-1)*@PageSize) ROWS
	FETCH NEXT @PageSize ROWS ONLY;
END