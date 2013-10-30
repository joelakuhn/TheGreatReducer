//////////////////////////////////////////////////////////////////////////////
//
//       File Name: WindowDragEffect.cs
//
//       Copyright: Roche Diagnostics, 2013
//
//     Description: Helper class to allow forms to be dragged by their
//                  background and non-interactive controls.
//
//       $Revision: 6 $
//
//       Revisions: Aug 12, 2013    JLK     Created
//
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TheGreatReducer
{
    /// <summary>
    /// Helper class to allow forms to be dragged by their
    /// background and non-interactive controls.
    /// </summary>
    internal class WindowDragEffect
    {
        #region Fields

        /// <summary>
        /// field for saving the starting window position of a drag event
        /// </summary>
        private Point dragStartWindowLocation;

        /// <summary>
        /// field for saving the starting mouse location of a drag event
        /// </summary>
        private Point dragStartMouseLocation;

        /// <summary>
        /// control which is currently dragging the window
        /// </summary>
        private Control windowMover;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Form to be dragged
        /// </summary>
        public Form Target { get; private set; }

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Creates a new instance of the helper for a given form.
        /// </summary>
        /// <param name="target">form to add dragging to</param>
        public WindowDragEffect(Form target)
        {
            Target = target;
        }

        /// <summary>
        /// The control types which should not be allowed to drag the window.
        /// </summary>
        private readonly List<Type> ignoreTypes = new List<Type>();

        public void AddIgnoredType(Type typeToIgnore)
        {
            ignoreTypes.Add(typeToIgnore);
        }

        /// <summary>
        /// Add the events required for each control to be able to drag the window.
        /// </summary>
        /// <param name="controls"></param>
        public void ApplyDragging(params Control[] controls)
        {
            foreach (Control c in controls)
            {
                if (ignoreTypes.Contains(c.GetType()))
                    continue;

                c.MouseDown += DraggerMouseDownEvent;
                c.MouseUp += DraggerMouseUpEvent;
                c.MouseLeave += DraggerMouseLeaveEvent;

                foreach (Control inner in c.Controls)
                    ApplyDragging(inner);
            }
        }

        public delegate void DragEvent();

        public event DragEvent DragStart;

        public event DragEvent DragEnd;

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Initialize fields and bind events when beginning to drag the window
        /// </summary>
        /// <param name="mover">control which is dragging the window</param>
        private void StartWindowDrag(Control mover)
        {
            windowMover = mover;
            dragStartMouseLocation = Cursor.Position;
            dragStartWindowLocation = Target.Location;
            windowMover.MouseMove += DraggerMouseMoveEvent;

            if (DragStart != null)
            {
                DragStart();
            }
        }

        /// <summary>
        /// Unbind events when done dragging the window
        /// </summary>
        private void EndWindowDrag()
        {
            if (windowMover != null)
                windowMover.MouseMove -= DraggerMouseMoveEvent;

            if (DragEnd != null)
            {
                DragEnd();
            }
        }

        /// <summary>
        /// Move the window to a new mouse location
        /// </summary>
        private void MoveWindow()
        {
            Target.Location = new Point(
                dragStartWindowLocation.X + (Cursor.Position.X - dragStartMouseLocation.X),
                dragStartWindowLocation.Y + (Cursor.Position.Y - dragStartMouseLocation.Y));
        }

        #endregion Private Methods

        #region Event Handlers

        private void DraggerMouseMoveEvent(object sender, EventArgs e)
        {
            MoveWindow();
        }

        private void DraggerMouseDownEvent(object sender, MouseEventArgs e)
        {
            StartWindowDrag(sender as Control);
        }

        private void DraggerMouseUpEvent(object sender, MouseEventArgs e)
        {
            EndWindowDrag();
        }

        private void DraggerMouseLeaveEvent(object sender, EventArgs e)
        {
            EndWindowDrag();
        }

        #endregion Event Handlers
    }
}