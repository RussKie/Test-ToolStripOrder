using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GitUI.CommandsDialogs
{
    public sealed partial class FormBrowse : Form 
    {
        [Flags]
        private enum UpdateTargets
        {
            None = 1,
            DiffList = 2,
            FileTree = 4,
            CommitInfo = 8
        }

        public FormBrowse()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // ReSharper disable ConstantConditionalAccessQualifier - these can be null if run from under the TranslatioApp

                components?.Dispose();

                // ReSharper restore ConstantConditionalAccessQualifier
            }

            base.Dispose(disposing);
        }

        #region IBrowseRepo

        #endregion

        #region Working directory combo box

        private void WorkingDirClick(object sender, EventArgs e)
        {
            _NO_TRANSLATE_WorkingDir.ShowDropDown();
        }

        private void _NO_TRANSLATE_WorkingDir_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                OpenToolStripMenuItemClick(sender, e);
            }
        }

        #endregion

        private void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        private void CloneToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        private void CommitToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        private void InitNewRepositoryToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        private void PushToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        private void RefreshToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Broadcast RepoChanged in case repo was changed outside of GE
        }

        private void RefreshDashboardToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        private void userShell_Click(object sender, EventArgs e)
        {
        }

        private void CheckoutBranchToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        private void CurrentBranchClick(object sender, EventArgs e)
        {
            branchSelect.ShowDropDown();
        }

        private void OnShowSettingsClick(object sender, EventArgs e)
        {
        }

        private static void SaveApplicationSettings()
        {
        }

        private void ToolStripButtonPushClick(object sender, EventArgs e)
        {
            PushToolStripMenuItemClick(sender, e);
        }

        private void ToolStripSplitStashButtonClick(object sender, EventArgs e)
        {
        }

        private void StashChangesToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        private void StashPopToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        private void ManageStashesToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        private void CreateStashToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiFavouriteRepositories_DropDownOpening(object sender, EventArgs e)
        {
            tsmiFavouriteRepositories.DropDownItems.Clear();
            PopulateFavouriteRepositoriesMenu(tsmiFavouriteRepositories);
        }

        private void tsmiRecentRepositories_DropDownOpening(object sender, EventArgs e)
        {
            tsmiRecentRepositories.DropDownItems.Clear();
            if (tsmiRecentRepositories.DropDownItems.Count < 1)
            {
                return;
            }

            tsmiRecentRepositories.DropDownItems.Add(clearRecentRepositoriesListToolStripMenuItem);
            tsmiRecentRepositories.DropDownItems.Add(tsmiRecentRepositoriesClear);
        }

        private void tsmiRecentRepositoriesClear_Click(object sender, EventArgs e)
        {
        }

        private void PopulateFavouriteRepositoriesMenu(ToolStripDropDownItem container)
        {
        }

        private void CurrentBranchDropDownOpening(object sender, EventArgs e)
        {
            branchSelect.DropDownItems.Clear();

            branchSelect.DropDownItems.Add(new ToolStripSeparator());
            AddBranchesMenuItems();

            PreventToolStripSplitButtonClosing(sender as ToolStripSplitButton);

            void AddBranchesMenuItems()
            {
            }
        }

        #region Hotkey commands

        public static readonly string HotkeySettingsName = "Browse";

        internal enum Command
        {
            GitBash = 0,
            GitGui = 1,
            GitGitK = 2,
            FocusRevisionGrid = 3,
            FocusCommitInfo = 4,
            FocusDiff = 5,
            FocusFileTree = 6,
            Commit = 7,
            AddNotes = 8,
            FindFileInSelectedCommit = 9,
            CheckoutBranch = 10,
            QuickFetch = 11,
            QuickPull = 12,
            QuickPush = 13,

            /* deprecated: RotateApplicationIcon = 14, */
            CloseRepository = 15,
            Stash = 16,
            StashPop = 17,
            FocusFilter = 18,
            OpenWithDifftool = 19,
            OpenSettings = 20,
            ToggleBranchTreePanel = 21,
            EditFile = 22,
            OpenAsTempFile = 23,
            OpenAsTempFileWith = 24,
            FocusBranchTree = 25,
            FocusGpgInfo = 26,
            GoToSuperproject = 27,
            GoToSubmodule = 28,
            FocusGitConsole = 29,
            FocusBuildServerStatus = 30,
            FocusNextTab = 31,
            FocusPrevTab = 32,
            OpenWithDifftoolFirstToLocal = 33,
            OpenWithDifftoolSelectedToLocal = 34,
            OpenCommitsWithDifftool = 35,
            ToggleBetweenArtificialAndHeadCommits = 36,
            GoToChild = 37,
            GoToParent = 38
        }

        #endregion

        private void pullToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void rebaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void fetchToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void fetchAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void fetchPruneAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void branchSelect_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CheckoutBranchToolStripMenuItemClick(sender, e);
            }
        }

        private void PreventToolStripSplitButtonClosing(ToolStripSplitButton control)
        {
        }

        private void toolStripButtonLevelUp_DropDownOpening(object sender, EventArgs e)
        {
            PreventToolStripSplitButtonClosing(sender as ToolStripSplitButton);
        }

        private void toolStripButtonLevelUp_ButtonClick(object sender, EventArgs e)
        {
        }

        private void toolStripButtonPull_DropDownOpened(object sender, EventArgs e)
        {
            PreventToolStripSplitButtonClosing(sender as ToolStripSplitButton);
        }

        #region Layout management

        private void toggleSplitViewLayout_Click(object sender, EventArgs e)
        {
        }

        private void toggleBranchTreePanel_Click(object sender, EventArgs e)
        {
        }

        private void CommitInfoPositionClick(object sender, EventArgs e)
        {
        }

        private void LayoutRevisionInfo()
        {
        }

        #endregion

        private void toolStripSplitStash_DropDownOpened(object sender, EventArgs e)
        {
            PreventToolStripSplitButtonClosing(sender as ToolStripSplitButton);
        }

        private void toolStripBranchFilterComboBox_Click(object sender, EventArgs e)
        {
            if (toolStripBranchFilterComboBox.Items.Count == 0)
            {
                return;
            }

            toolStripBranchFilterComboBox.DroppedDown = true;
        }

        internal TestAccessor GetTestAccessor()
            => new TestAccessor(this);

        internal readonly struct TestAccessor
        {
            private readonly FormBrowse _form;

            public TestAccessor(FormBrowse form)
            {
                _form = form;
            }
        }

        private void FormBrowse_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void FormBrowse_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)
                || e.Data.GetDataPresent(DataFormats.Text)
                || e.Data.GetDataPresent(DataFormats.UnicodeText))
            {
                e.Effect = DragDropEffects.Move;
            }
        }
    }
}
