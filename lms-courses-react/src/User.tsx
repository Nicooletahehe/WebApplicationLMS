import React, { useState, useEffect} from "react";
import {api} from './API';
import { UserList } from "./models/UserModel";

export const User: React.FC = () => {
    const [usersArray, setusersArray] = useState([]);
    const [isLoaded, setIsLoaded] = useState(false);

    async function refreshList() {
        setIsLoaded(true);
        const response = await fetch(api.API_URL + 'users');
        console.log(response);
        const data = await response.json();
        console.log(data);
        console.log(typeof(data));
        setusersArray(data);
    }

    useEffect(() => {
        refreshList();
        setIsLoaded(false);
    });

    console.log(isLoaded);
    if (isLoaded) {
        return <p>Loading ...</p>;
    } else {
        return <div>
            <h3>This is users Page</h3>
            <table className="table table-striped">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Email</th>
                        <th>Department</th>
                        <th>Manager</th>
                        <th>Role</th>
                        {/* <th>Actions</th> */}
                    </tr>
                </thead>
                <tbody>
                    {usersArray.map(user => (
                        <tr key = {user["Id"]}>
                            <td><img src={user["Avatar"]}/></td>
                            <td>{user["Name"]}</td>
                            <td>{user["Email"]}</td>
                            <td>{user["Department"]}</td>
                            <td>{user["Manager"]}</td>
                            <td>{user["Role"]["Name"]}</td>
                            {/* <button type="button" className="btn btn-light mr-1"></button> */}
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    }
    
}