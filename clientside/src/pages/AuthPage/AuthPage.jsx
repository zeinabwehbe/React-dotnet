import React from 'react';
import LoginForm from '../../components/LoginForm/LoginForm'; // Adjust the path as per your folder structure

const AuthPage = () => {
  const handleLogin = async (credentials) => {
    console.log('Logging in with:', credentials);

    // Example: Call your login API
    try {
      const response = await fetch('/api/auth/login', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(credentials),
      });

      if (!response.ok) {
        throw new Error('Login failed');
      }

      const data = await response.json();
      console.log('Login success:', data);

      // Redirect or perform post-login actions
    } catch (error) {
      console.error('Error:', error.message);
    }
  };

  return (
    <div>
      <h1>Login</h1>
      <LoginForm onLogin={handleLogin} />
    </div>
  );
};

export default AuthPage;
