INSERT INTO [SYSCONTUNEMI].[dbo].[SEG_ROLES] 
    ([SEGROL_DESCRIPCION], [SEGROL_OBSERVACIONES], [SEGROL_ESTADO],
     [Aud_Usuario_Ingreso], [Aud_Fecha_Ingreso], [Aud_PC_Ingreso],
     [Aud_Usuario_Modifica], [Aud_Fecha_Modifica], [Aud_PC_Modifica])
VALUES
    ('Programador', 'OMEGA', 1,
     'UsuarioIngreso1', GETDATE(), 'PCIngreso1',
     'UsuarioModifica1', GETDATE(), 'PCModifica1'),
     
    ('Profesor', 'Administrador', 1,
     'UsuarioIngreso2', GETDATE(), 'PCIngreso2',
     'UsuarioModifica2', GETDATE(), 'PCModifica2'),

    ('Estudiante 1er Sem', 'Analista contable', 1,
     'UsuarioIngreso3', GETDATE(), 'PCIngreso3',
     'UsuarioModifica3', GETDATE(), 'PCModifica3'),

    ('Estudiante 4to Sem', 'Auditor', 1,
     'UsuarioIngreso4', GETDATE(), 'PCIngreso4',
     'UsuarioModifica4', GETDATE(), 'PCModifica4'),

    ('Estudiante PRE', 'Pasante', 1,
     'UsuarioIngreso5', GETDATE(), 'PCIngreso5',
     'UsuarioModifica5', GETDATE(), 'PCModifica5');
