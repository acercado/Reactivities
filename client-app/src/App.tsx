import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import Axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
  const [activities, setActivities] = useState([]);

  useEffect(() => {
    Axios.get('http://localhost:5000/api/activities')
    .then(response=> {
      console.log(response);
      setActivities(response.data);
    })
  }, [])

  return (
    <div className="App">
      <Header as='h2' icon='users' content='WISAR Activities' />
      <List>
          {activities.map((activity: any)=> (
            <li key={activity.id}>
              {activity.title}
            </li>
          ))}
      </List>

      <header className="App-header">
        <ul>

        </ul>
      </header>
    </div>
  );
}

export default App;
