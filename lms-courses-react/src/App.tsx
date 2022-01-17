import { BrowserRouter, Route, Routes, NavLink } from 'react-router-dom';
import './App.css';
import { Home } from './Home';
import { Courses } from './Courses';
import { User } from './User';

const App: React.FC = () => {
  return <div>
    <BrowserRouter>
      <div className="App container">
        <h3 className="d-flex justify-content-center m-3">LMS Courses</h3>

        <nav className='navbar navbar-expand-sm bg-light navbar-dark'>
          <ul className='navbar-nav'>
            <li className='nav-item- m-1'>
              <NavLink className="btn btn-ligh btn-outline-primary" to="/home">Home</NavLink>
            </li>
            <li className='nav-item- m-1'>
              <NavLink className="btn btn-ligh btn-outline-primary" to="/courses">Courses</NavLink>
            </li>
            <li className='nav-item- m-1'>
              <NavLink className="btn btn-ligh btn-outline-primary" to="/user">User</NavLink>
            </li>
          </ul>
        </nav>

        <Routes>
          <Route path="/home" element={<Home />} />
          <Route path="/courses" element={<Courses />} />
          <Route path="/user" element={<User />} />
        </Routes>
      </div>
    </BrowserRouter>
  </div>
}

export default App;
