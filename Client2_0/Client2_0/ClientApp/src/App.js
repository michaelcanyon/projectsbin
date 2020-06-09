import React, { Component } from 'react';
import axios from "C:\Users\hrani\OneDrive\Документы\GitHub\projectsbin\Coursal_IT_2020_spring\ClientApp\react-api\node_modules\axios"

export default class App extends Component {
    state = {
        posts: [],
        IsLoaded: false,
    }

    async componentDidMount() {
        //fetch('http://localhost:5000/api/Post/posts')
        //    .then(res => res.json())
        //    .then((data) => {
        //        this.setState({ posts: data })
        //    })
        //    .catch(console.log)
        await axios.get('https://localhost:5001/api/Post/posts')
            .then(res => res.data)
            .then((data) => {
                this.setState({ IsLoaded: true, posts: data })
            })
            .catch(console.log);
    }
    render() {
        return (
            <div className="App">
                <header className="App-header">
                    <h3>List of Posts</h3>
                    <ul>
                        {this.state.posts.map((post) => (
                            <li key="{post.id}">{post.title} - {post.text}</li>
                        ))}
                    </ul>
                </header>
            </div>
        );
    }
}
