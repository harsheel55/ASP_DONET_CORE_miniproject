using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    /// <summary>
    /// ViewModel for user login.
    /// </summary>
    public class LoginViewModel
    {
        /// <summary>
        /// Gets or sets the user's email address.
        /// </summary>
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? Email { get; set; } // Nullable for better flexibility

        /// <summary>
        /// Gets or sets the user's password.
        /// </summary>
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; } // Nullable for better flexibility

        /// <summary>
        /// Gets or sets a value indicating whether the user wants to be remembered.
        /// </summary>
        public bool RememberMe { get; set; }

        /// <summary>
        /// Default constructor for LoginViewModel.
        /// </summary>
        public LoginViewModel()
        {
            // Initialize properties if needed
        }
    }
}
