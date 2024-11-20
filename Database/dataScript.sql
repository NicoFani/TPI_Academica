USE [academia_grupo6]
GO
SET IDENTITY_INSERT [dbo].[especialidades] ON 
GO
INSERT [dbo].[especialidades] ([id_especialidad], [desc_especialidad]) VALUES (1, N'Ingenieria en Sistemas')
GO
INSERT [dbo].[especialidades] ([id_especialidad], [desc_especialidad]) VALUES (2, N'Medicina')
GO
INSERT [dbo].[especialidades] ([id_especialidad], [desc_especialidad]) VALUES (3, N'Arquitectura')
GO
SET IDENTITY_INSERT [dbo].[especialidades] OFF
GO
SET IDENTITY_INSERT [dbo].[planes] ON 
GO
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad]) VALUES (1, N'2022', 1)
GO
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad]) VALUES (2, N'2009', 1)
GO
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad]) VALUES (3, N'1995', 1)
GO
SET IDENTITY_INSERT [dbo].[planes] OFF
GO
SET IDENTITY_INSERT [dbo].[comisiones] ON 
GO
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (1, N'k1', 1, 1)
GO
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (2, N'k2', 1, 1)
GO
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (3, N'k1', 2, 1)
GO
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (4, N'k2', 2, 1)
GO
SET IDENTITY_INSERT [dbo].[comisiones] OFF
GO
SET IDENTITY_INSERT [dbo].[personas] ON 
GO
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan], [nombre_usuario], [clave]) VALUES (6, N'Juan', N'Pérez', N'Calle Falsa 123', N'juan.perez@example.com', N'555-1234', CAST(N'1985-05-12T00:00:00.000' AS DateTime), 12345, N'Alumno', 1, N'juanp', N'clave123')
GO
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan], [nombre_usuario], [clave]) VALUES (7, N'María', N'González', N'Av. Siempre Viva 456', N'maria.gonzalez@example.com', N'555-5678', CAST(N'1990-07-23T00:00:00.000' AS DateTime), 12346, N'Alumno', 2, N'mariag', N'clave456')
GO
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan], [nombre_usuario], [clave]) VALUES (8, N'Carlos', N'Rodríguez', N'Calle Sol 789', N'carlos.rodriguez@example.com', N'555-9876', CAST(N'1980-11-15T00:00:00.000' AS DateTime), 12347, N'Profesor', 3, N'profesor', N'profesor')
GO
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan], [nombre_usuario], [clave]) VALUES (9, N'Lucía', N'Martínez', N'Av. Luna 321', N'lucia.martinez@example.com', N'555-4321', CAST(N'1995-02-28T00:00:00.000' AS DateTime), 12348, N'Admin', 3, N'admin', N'admin')
GO
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan], [nombre_usuario], [clave]) VALUES (14, N'Franco', N'Sanchez', NULL, NULL, NULL, CAST(N'2024-11-01T22:09:47.793' AS DateTime), 49738, N'Alumno', 1, N'alumno', N'alumno')
GO
SET IDENTITY_INSERT [dbo].[personas] OFF
GO
SET IDENTITY_INSERT [dbo].[materias] ON 
GO
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (1, N'Matematica 1', 6, 192, 1)
GO
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (2, N'Matematica 2', 6, 192, 1)
GO
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (3, N'Matematica 3', 6, 192, 1)
GO
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (4, N'Ingles 1', 3, 96, 1)
GO
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (5, N'Ingles 2', 3, 96, 1)
GO
SET IDENTITY_INSERT [dbo].[materias] OFF
GO
SET IDENTITY_INSERT [dbo].[cursos] ON 
GO
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (1, 1, 1, 2022, 50)
GO
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (2, 1, 2, 2022, 50)
GO
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (3, 2, 3, 2022, 50)
GO
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (4, 2, 4, 2022, 60)
GO
SET IDENTITY_INSERT [dbo].[cursos] OFF
GO
SET IDENTITY_INSERT [dbo].[alumnos_inscripciones] ON 
GO
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (1, 14, 1, N'Cursando', NULL)
GO
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (2, 14, 2, N'Cursando', NULL)
GO
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (3, 14, 3, N'Cursando', NULL)
GO
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (4, 14, 4, N'Cursando', NULL)
GO
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (5, 6, 4, N'Cursando', NULL)
GO
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (6, 6, 3, N'Cursando', NULL)
GO
SET IDENTITY_INSERT [dbo].[alumnos_inscripciones] OFF
GO
SET IDENTITY_INSERT [dbo].[docentes_cursos] ON 
GO
INSERT [dbo].[docentes_cursos] ([id_dictado], [id_curso], [id_docente], [cargo]) VALUES (1, 3, 8, N'Profesor')
GO
INSERT [dbo].[docentes_cursos] ([id_dictado], [id_curso], [id_docente], [cargo]) VALUES (2, 1, 8, N'Profesor')
GO
INSERT [dbo].[docentes_cursos] ([id_dictado], [id_curso], [id_docente], [cargo]) VALUES (3, 2, 8, N'Profesor')
GO
INSERT [dbo].[docentes_cursos] ([id_dictado], [id_curso], [id_docente], [cargo]) VALUES (4, 4, 8, N'Profesor')
GO
SET IDENTITY_INSERT [dbo].[docentes_cursos] OFF
GO
