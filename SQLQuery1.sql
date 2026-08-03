DELETE FROM AspNetUserRoles
WHERE UserId = 'd73522f3-d59c-4b89-bdc6-31ffdcef61fb'
AND RoleId = (SELECT Id FROM AspNetRoles WHERE Name = 'Viewer');

INSERT INTO AspNetUserRoles (UserId, RoleId)
VALUES ('d73522f3-d59c-4b89-bdc6-31ffdcef61fb', (SELECT Id FROM AspNetRoles WHERE Name = 'RRHH'));