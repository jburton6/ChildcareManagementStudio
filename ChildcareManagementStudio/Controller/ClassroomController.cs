﻿using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for managing classrooms.
    /// </summary>
    public class ClassroomController
    {
        private readonly ClassroomDAL classroomDAL;

        /// <summary>
        /// Constructor for the ClassroomController class.
        /// </summary>
        public ClassroomController()
        {
            classroomDAL = new ClassroomDAL();
        }

        /// <summary>
        /// Method that returns a Classroom object representing the requested classroom.
        /// </summary>
        /// <param name="classroomId">Unique ID of the classroom being requested.</param>
        /// <returns>A Classroom object representing the requested classroom.</returns>
        public Classroom GetClassroom(int classroomId)
        {
            return classroomDAL.GetClassroom(classroomId);
        }

        /// <summary>
        /// Method that returns Classroom objects for all of the classrooms in the database.
        /// </summary>
        /// <returns>A list of Classroom objects for all of the classrooms in the database.</returns>
        public List<Classroom> GetAllClassrooms()
        {
            return classroomDAL.GetAllClassrooms();
        }

        /// <summary>
        /// Adds the new Classroom to the DB
        /// </summary>
        /// <param name="theClassroom">Classroom object to be added to DB</param>
        public void CreateNewClassroom(Classroom theClassroom)
        {
            if (theClassroom == null)
            {
                throw new ArgumentNullException("theClassroom", "The classroom cannot be null.");
            }
            this.classroomDAL.CreateNewClassroom(theClassroom);
        }

        /// <summary>
        /// Edits a current classroom in the DB
        /// </summary>
        /// <param name="originalClassroom"></param>
        /// <param name="revisedClassroom"></param>
        public void EditClassroom(Classroom originalClassroom, Classroom revisedClassroom)
        {
            if (originalClassroom == null) 
            {
                throw new ArgumentNullException("originalClassroom", "The original classroom cannot be null.");
            }
            if (revisedClassroom == null)
            {
                throw new ArgumentNullException("revisedClassroom", "The revised classroom cannot be null.");
            }
            this.classroomDAL.EditClassroom(originalClassroom, revisedClassroom);
        }
    }
}