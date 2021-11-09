import React from 'react';

class LifeCycleComponent extends React.Component {

    constructor(props) {

        super(props);

        console.log("In LifeCycleComponent.constructor");

        this.state = { title: "" };

    }

    componentDidMount() {  

        // console.log("In LifeCycleComponent.componentDidMount");
        fetch(  'https://jsonplaceholder.typicode.com/todos/1')
                .then(response => response.json())
                .then(json => {
                    console.log(json.title);
                    this.setState({ title: json.title });
                    console.log("Component state has been modified.");
                });
        console.log("Fetch has been made.");
    }
                                                
    

    render() {
        console.log("In LifeCycleComponent.render");
        return (
            <div>
                <h1>Customer List</h1> 
                <p>Title: {this.state.title}</p>
            </div>
            
        ); 

    }

}

export default LifeCycleComponent;